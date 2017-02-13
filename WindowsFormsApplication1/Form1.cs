using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using NCalc;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private int _bar;
        private int _diff;
        //-------------------------------------------------//

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("war3");
            if (pname.Length == 0)
            {
                MessageBox.Show(@"wc3 is not running");
            }
            else
            {
                List<Building> buildings = GetBuildings();
                if (buildings.Count == 0) return;
                buildings.Sort((x, y) => y.Resp.CompareTo(x.Resp));
                DoActions(buildings[0].Number);
                for (int i = 0; i < buildings.Count - 1; i++)
                {
                    _diff = (buildings[i].Resp - buildings[i + 1].Resp) * 1000;
                    if (_diff == 0)
                    {
                        _diff = 100;
                    }
                    Thread.Sleep(_diff);
                    DoActions(buildings[i + 1].Number);                                               
                }
                label1.Text = @"end of sync";
            }
        }
        

        public void DoActions(int which)
        {
            Process[] processes = Process.GetProcessesByName("war3");
            Process warcraft = processes[0];
            IntPtr proc = warcraft.MainWindowHandle;
            SetForegroundWindow(proc);
            progressBar1.Value += 1;
            Thread.Sleep(300);
            VirtualKeyCode keyForPress;
            Enum.TryParse($"VK_{which}", out keyForPress);
            InputSimulator.SimulateKeyPress(keyForPress);
            Thread.Sleep(100);
            InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_Q);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("war3");
            if (processes.Length == 0)
            {
                MessageBox.Show(@"wc3 is not running");
            }
            else
            {
                List<Building> buildings = GetBuildings();
                Process warcraft = processes[0];
                IntPtr p = warcraft.MainWindowHandle;
                SetForegroundWindow(p);
                progressBar1.Value = 0;
                foreach (var building in buildings)
                {
                    VirtualKeyCode keyForPress = (VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), "VK_" + building.Number);
                    Thread.Sleep(300);
                    InputSimulator.SimulateKeyPress(keyForPress);
                    Thread.Sleep(100);
                    for (int j = 1; j <= 3; j++)
                    {
                        InputSimulator.SimulateKeyPress(VirtualKeyCode.ESCAPE);
                        progressBar1.Value++;
                    }
                }
            }
        }

        private List<Building> GetBuildings()
        {
            var buildings = new List<Building>();
            label1.Text = ("");
            var regexItem = new Regex("[0-9]+");
            progressBar1.Value = 0;
            _bar = 0;
            for (int i = 1; i <= 9; i++)
            {
                TextBox boxS = (TextBox)Controls["Box" + i];
                if (!string.IsNullOrEmpty(boxS.Text))
                {
                    if (regexItem.IsMatch(boxS.Text))
                    {
                        _bar += 1;
                        progressBar1.Maximum = _bar;

                        Expression exp = new Expression(boxS.Text);
                        try
                        {
                            var result = (int)exp.Evaluate();
                            buildings.Add(new Building { Name = "building#" + i, Number = i, Resp = 15 + result / 20 });
                            //MessageBox.Show(""+Buildings[0].Resp);                           
                        }
                        catch (EvaluationException)
                        {
                            MessageBox.Show(@"wc3 is not running");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"wc3 is not running");
                    }
                }
            }

            return buildings;
        }
    }
}
