using System.ComponentModel;
using System.Windows.Forms;

namespace CastlefightSyncro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.Box4 = new System.Windows.Forms.TextBox();
            this.Box5 = new System.Windows.Forms.TextBox();
            this.Box6 = new System.Windows.Forms.TextBox();
            this.Box7 = new System.Windows.Forms.TextBox();
            this.Box8 = new System.Windows.Forms.TextBox();
            this.Box9 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "SYNC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "RES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Box1
            // 
            this.Box1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Box1.Location = new System.Drawing.Point(12, 23);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(100, 20);
            this.Box1.TabIndex = 0;
            // 
            // Box2
            // 
            this.Box2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Box2.Location = new System.Drawing.Point(12, 49);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(100, 20);
            this.Box2.TabIndex = 2;
            // 
            // Box3
            // 
            this.Box3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Box3.Location = new System.Drawing.Point(12, 75);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(100, 20);
            this.Box3.TabIndex = 3;
            // 
            // Box4
            // 
            this.Box4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Box4.Location = new System.Drawing.Point(12, 101);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(100, 20);
            this.Box4.TabIndex = 4;
            // 
            // Box5
            // 
            this.Box5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Box5.Location = new System.Drawing.Point(12, 127);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(100, 20);
            this.Box5.TabIndex = 5;
            // 
            // Box6
            // 
            this.Box6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Box6.Location = new System.Drawing.Point(12, 153);
            this.Box6.Name = "Box6";
            this.Box6.Size = new System.Drawing.Size(100, 20);
            this.Box6.TabIndex = 6;
            // 
            // Box7
            // 
            this.Box7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Box7.Location = new System.Drawing.Point(12, 179);
            this.Box7.Name = "Box7";
            this.Box7.Size = new System.Drawing.Size(100, 20);
            this.Box7.TabIndex = 7;
            // 
            // Box8
            // 
            this.Box8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Box8.Location = new System.Drawing.Point(12, 205);
            this.Box8.Name = "Box8";
            this.Box8.Size = new System.Drawing.Size(100, 20);
            this.Box8.TabIndex = 8;
            // 
            // Box9
            // 
            this.Box9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Box9.Location = new System.Drawing.Point(12, 231);
            this.Box9.Name = "Box9";
            this.Box9.Size = new System.Drawing.Size(100, 20);
            this.Box9.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(145, 112);
            this.progressBar1.Maximum = 9;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 264);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Box9);
            this.Controls.Add(this.Box8);
            this.Controls.Add(this.Box7);
            this.Controls.Add(this.Box6);
            this.Controls.Add(this.Box5);
            this.Controls.Add(this.Box4);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Button button2;
        private TextBox Box1;
        private TextBox Box2;
        private TextBox Box3;
        private TextBox Box4;
        private TextBox Box5;
        private TextBox Box6;
        private TextBox Box7;
        private TextBox Box8;
        private TextBox Box9;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}

