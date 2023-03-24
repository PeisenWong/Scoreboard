
namespace RBCScoreBoard
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.MainLabel = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.statusDisp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TimeB = new System.Windows.Forms.Label();
            this.ScoreB = new System.Windows.Forms.Label();
            this.lblScoreB = new System.Windows.Forms.Label();
            this.NameB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeA = new System.Windows.Forms.Label();
            this.ScoreA = new System.Windows.Forms.Label();
            this.lblScoreA = new System.Windows.Forms.Label();
            this.NameA = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.White;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.MainLabel.Size = new System.Drawing.Size(2061, 175);
            this.MainLabel.TabIndex = 12;
            this.MainLabel.Text = "UTM ROBOCON AUTOCAR CHALLENGE 2022";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainLabel.Click += new System.EventHandler(this.MainLabel_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblMinutes
            // 
            this.lblMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinutes.Font = new System.Drawing.Font("Bahnschrift", 190F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.Color.White;
            this.lblMinutes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMinutes.Location = new System.Drawing.Point(0, 0);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMinutes.Size = new System.Drawing.Size(2061, 1102);
            this.lblMinutes.TabIndex = 9;
            this.lblMinutes.Text = "0 : 00";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinutes.Click += new System.EventHandler(this.lblMinutes_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(853, 187);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(144, 36);
            this.lblDateTime.TabIndex = 7;
            this.lblDateTime.Text = "date/time";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // statusDisp
            // 
            this.statusDisp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusDisp.Font = new System.Drawing.Font("Bahnschrift", 50F);
            this.statusDisp.ForeColor = System.Drawing.Color.White;
            this.statusDisp.Location = new System.Drawing.Point(0, 843);
            this.statusDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusDisp.Name = "statusDisp";
            this.statusDisp.Padding = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.statusDisp.Size = new System.Drawing.Size(2061, 259);
            this.statusDisp.TabIndex = 15;
            this.statusDisp.Text = "Preparation";
            this.statusDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusDisp.Click += new System.EventHandler(this.statusDisp_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.TimeB);
            this.panel2.Controls.Add(this.ScoreB);
            this.panel2.Controls.Add(this.lblScoreB);
            this.panel2.Controls.Add(this.NameB);
            this.panel2.Location = new System.Drawing.Point(1464, 187);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(570, 783);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TimeB
            // 
            this.TimeB.AutoSize = true;
            this.TimeB.Font = new System.Drawing.Font("Bahnschrift", 75F);
            this.TimeB.ForeColor = System.Drawing.Color.White;
            this.TimeB.Location = new System.Drawing.Point(140, 546);
            this.TimeB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeB.Name = "TimeB";
            this.TimeB.Size = new System.Drawing.Size(364, 150);
            this.TimeB.TabIndex = 23;
            this.TimeB.Text = "0 : 00";
            this.TimeB.Click += new System.EventHandler(this.TimeB_Click);
            // 
            // ScoreB
            // 
            this.ScoreB.AutoSize = true;
            this.ScoreB.Font = new System.Drawing.Font("Bahnschrift", 90F);
            this.ScoreB.ForeColor = System.Drawing.Color.White;
            this.ScoreB.Location = new System.Drawing.Point(230, 340);
            this.ScoreB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreB.Name = "ScoreB";
            this.ScoreB.Size = new System.Drawing.Size(158, 180);
            this.ScoreB.TabIndex = 22;
            this.ScoreB.Text = "0";
            this.ScoreB.Click += new System.EventHandler(this.ScoreB_Click);
            // 
            // lblScoreB
            // 
            this.lblScoreB.AutoSize = true;
            this.lblScoreB.Font = new System.Drawing.Font("Bahnschrift", 70F);
            this.lblScoreB.ForeColor = System.Drawing.Color.White;
            this.lblScoreB.Location = new System.Drawing.Point(117, 216);
            this.lblScoreB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreB.Name = "lblScoreB";
            this.lblScoreB.Size = new System.Drawing.Size(365, 140);
            this.lblScoreB.TabIndex = 21;
            this.lblScoreB.Text = "Score";
            this.lblScoreB.Click += new System.EventHandler(this.lblScoreB_Click);
            // 
            // NameB
            // 
            this.NameB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameB.Font = new System.Drawing.Font("Bahnschrift", 45F);
            this.NameB.ForeColor = System.Drawing.Color.White;
            this.NameB.Location = new System.Drawing.Point(0, 0);
            this.NameB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameB.Name = "NameB";
            this.NameB.Padding = new System.Windows.Forms.Padding(40, 50, 0, 0);
            this.NameB.Size = new System.Drawing.Size(550, 783);
            this.NameB.TabIndex = 20;
            this.NameB.Text = "Name2";
            this.NameB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.TimeA);
            this.panel1.Controls.Add(this.ScoreA);
            this.panel1.Controls.Add(this.lblScoreA);
            this.panel1.Controls.Add(this.NameA);
            this.panel1.Location = new System.Drawing.Point(17, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 784);
            this.panel1.TabIndex = 24;
            // 
            // TimeA
            // 
            this.TimeA.AutoSize = true;
            this.TimeA.Font = new System.Drawing.Font("Bahnschrift", 75F);
            this.TimeA.ForeColor = System.Drawing.Color.White;
            this.TimeA.Location = new System.Drawing.Point(83, 562);
            this.TimeA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeA.Name = "TimeA";
            this.TimeA.Size = new System.Drawing.Size(364, 150);
            this.TimeA.TabIndex = 23;
            this.TimeA.Text = "0 : 00";
            // 
            // ScoreA
            // 
            this.ScoreA.AutoSize = true;
            this.ScoreA.Font = new System.Drawing.Font("Bahnschrift", 90F);
            this.ScoreA.ForeColor = System.Drawing.Color.White;
            this.ScoreA.Location = new System.Drawing.Point(196, 356);
            this.ScoreA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreA.Name = "ScoreA";
            this.ScoreA.Size = new System.Drawing.Size(158, 180);
            this.ScoreA.TabIndex = 22;
            this.ScoreA.Text = "0";
            this.ScoreA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScoreA.Click += new System.EventHandler(this.ScoreA_Click);
            // 
            // lblScoreA
            // 
            this.lblScoreA.AutoSize = true;
            this.lblScoreA.Font = new System.Drawing.Font("Bahnschrift", 70F);
            this.lblScoreA.ForeColor = System.Drawing.Color.White;
            this.lblScoreA.Location = new System.Drawing.Point(82, 232);
            this.lblScoreA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreA.Name = "lblScoreA";
            this.lblScoreA.Size = new System.Drawing.Size(365, 140);
            this.lblScoreA.TabIndex = 21;
            this.lblScoreA.Text = "Score";
            this.lblScoreA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameA
            // 
            this.NameA.Font = new System.Drawing.Font("Bahnschrift", 45F);
            this.NameA.ForeColor = System.Drawing.Color.White;
            this.NameA.Location = new System.Drawing.Point(0, 0);
            this.NameA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameA.Name = "NameA";
            this.NameA.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.NameA.Size = new System.Drawing.Size(531, 784);
            this.NameA.TabIndex = 20;
            this.NameA.Text = "Name1";
            this.NameA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameA.Click += new System.EventHandler(this.NameA_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(2061, 1102);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusDisp);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblDateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label statusDisp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TimeB;
        private System.Windows.Forms.Label ScoreB;
        private System.Windows.Forms.Label lblScoreB;
        private System.Windows.Forms.Label NameB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TimeA;
        private System.Windows.Forms.Label ScoreA;
        private System.Windows.Forms.Label lblScoreA;
        private System.Windows.Forms.Label NameA;
    }
}