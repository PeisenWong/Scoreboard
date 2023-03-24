
namespace RBCScoreBoard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnExport = new System.Windows.Forms.Button();
            this.bttnReset = new System.Windows.Forms.Button();
            this.bttnPause = new System.Windows.Forms.Button();
            this.bttnFinish = new System.Windows.Forms.Button();
            this.bttnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.Countdown = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ScoreA = new System.Windows.Forms.NumericUpDown();
            this.lblScoreA = new System.Windows.Forms.Label();
            this.ChallengerA = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.END1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.END2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChallengerB = new System.Windows.Forms.Label();
            this.ScoreB = new System.Windows.Forms.NumericUpDown();
            this.lblScoreB = new System.Windows.Forms.Label();
            this.RoundNew = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreA)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bttnExport);
            this.panel1.Controls.Add(this.bttnReset);
            this.panel1.Controls.Add(this.bttnPause);
            this.panel1.Controls.Add(this.bttnFinish);
            this.panel1.Controls.Add(this.bttnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 581);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 74);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bttnExport
            // 
            this.bttnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnExport.BackColor = System.Drawing.Color.White;
            this.bttnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnExport.FlatAppearance.BorderSize = 0;
            this.bttnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExport.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnExport.Location = new System.Drawing.Point(956, 6);
            this.bttnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnExport.Name = "bttnExport";
            this.bttnExport.Size = new System.Drawing.Size(211, 68);
            this.bttnExport.TabIndex = 0;
            this.bttnExport.Tag = "";
            this.bttnExport.Text = "Export";
            this.bttnExport.UseVisualStyleBackColor = false;
            this.bttnExport.Click += new System.EventHandler(this.bttnExport_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnReset.BackColor = System.Drawing.Color.White;
            this.bttnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnReset.FlatAppearance.BorderSize = 0;
            this.bttnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnReset.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnReset.Location = new System.Drawing.Point(3, 4);
            this.bttnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(211, 68);
            this.bttnReset.TabIndex = 0;
            this.bttnReset.Tag = "";
            this.bttnReset.Text = "Back";
            this.bttnReset.UseVisualStyleBackColor = false;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // bttnPause
            // 
            this.bttnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnPause.BackColor = System.Drawing.Color.White;
            this.bttnPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnPause.FlatAppearance.BorderSize = 0;
            this.bttnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPause.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnPause.Location = new System.Drawing.Point(716, 6);
            this.bttnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnPause.Name = "bttnPause";
            this.bttnPause.Size = new System.Drawing.Size(211, 68);
            this.bttnPause.TabIndex = 0;
            this.bttnPause.Tag = "";
            this.bttnPause.Text = "Pause";
            this.bttnPause.UseVisualStyleBackColor = false;
            this.bttnPause.Click += new System.EventHandler(this.bttnPause_Click);
            // 
            // bttnFinish
            // 
            this.bttnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnFinish.BackColor = System.Drawing.Color.White;
            this.bttnFinish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnFinish.FlatAppearance.BorderSize = 0;
            this.bttnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnFinish.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnFinish.Location = new System.Drawing.Point(458, 6);
            this.bttnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnFinish.Name = "bttnFinish";
            this.bttnFinish.Size = new System.Drawing.Size(228, 68);
            this.bttnFinish.TabIndex = 0;
            this.bttnFinish.Tag = "";
            this.bttnFinish.Text = "Finish";
            this.bttnFinish.UseVisualStyleBackColor = false;
            this.bttnFinish.Click += new System.EventHandler(this.bttnFinish_Click);
            // 
            // bttnStart
            // 
            this.bttnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnStart.BackColor = System.Drawing.Color.White;
            this.bttnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnStart.FlatAppearance.BorderSize = 0;
            this.bttnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnStart.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnStart.Location = new System.Drawing.Point(222, 6);
            this.bttnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(228, 68);
            this.bttnStart.TabIndex = 0;
            this.bttnStart.Tag = "";
            this.bttnStart.Text = "Start";
            this.bttnStart.UseVisualStyleBackColor = false;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer
            // 
            this.Timer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.White;
            this.Timer.Location = new System.Drawing.Point(961, 137);
            this.Timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(97, 33);
            this.Timer.TabIndex = 4;
            this.Timer.Text = "Timer :";
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.White;
            this.MainLabel.Location = new System.Drawing.Point(233, 32);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(825, 72);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "UTM ROBOCON AUTOCAR CHALLENGE 2022";
            // 
            // Countdown
            // 
            this.Countdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Countdown.AutoSize = true;
            this.Countdown.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.ForeColor = System.Drawing.Color.White;
            this.Countdown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Countdown.Location = new System.Drawing.Point(949, 170);
            this.Countdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Countdown.Name = "Countdown";
            this.Countdown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Countdown.Size = new System.Drawing.Size(126, 96);
            this.Countdown.TabIndex = 5;
            this.Countdown.Text = "30";
            this.Countdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Countdown.Click += new System.EventHandler(this.Countdown_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnExit.BackColor = System.Drawing.Color.Red;
            this.bttnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttnExit.Location = new System.Drawing.Point(1136, 46);
            this.bttnExit.Margin = new System.Windows.Forms.Padding(4);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(31, 31);
            this.bttnExit.TabIndex = 6;
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ScoreA
            // 
            this.ScoreA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreA.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreA.Location = new System.Drawing.Point(348, 87);
            this.ScoreA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScoreA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ScoreA.Name = "ScoreA";
            this.ScoreA.Size = new System.Drawing.Size(80, 38);
            this.ScoreA.TabIndex = 0;
            this.ScoreA.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // lblScoreA
            // 
            this.lblScoreA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScoreA.AutoSize = true;
            this.lblScoreA.BackColor = System.Drawing.Color.Red;
            this.lblScoreA.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScoreA.Location = new System.Drawing.Point(60, 84);
            this.lblScoreA.Name = "lblScoreA";
            this.lblScoreA.Size = new System.Drawing.Size(83, 36);
            this.lblScoreA.TabIndex = 1;
            this.lblScoreA.Text = "Score";
            this.lblScoreA.Click += new System.EventHandler(this.LaghoriShot_Click);
            // 
            // ChallengerA
            // 
            this.ChallengerA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChallengerA.AutoSize = true;
            this.ChallengerA.BackColor = System.Drawing.Color.Red;
            this.ChallengerA.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengerA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChallengerA.Location = new System.Drawing.Point(176, 16);
            this.ChallengerA.Name = "ChallengerA";
            this.ChallengerA.Size = new System.Drawing.Size(98, 36);
            this.ChallengerA.TabIndex = 10;
            this.ChallengerA.Text = "Name 1";
            this.ChallengerA.Click += new System.EventHandler(this.lblR1Ctrl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.END1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ChallengerA);
            this.panel2.Controls.Add(this.ScoreA);
            this.panel2.Controls.Add(this.lblScoreA);
            this.panel2.Location = new System.Drawing.Point(70, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 231);
            this.panel2.TabIndex = 12;
            // 
            // END1
            // 
            this.END1.Location = new System.Drawing.Point(183, 165);
            this.END1.Name = "END1";
            this.END1.Size = new System.Drawing.Size(121, 46);
            this.END1.TabIndex = 23;
            this.END1.Text = "END";
            this.END1.UseVisualStyleBackColor = true;
            this.END1.Click += new System.EventHandler(this.END1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 42);
            this.label2.TabIndex = 22;
            this.label2.Text = "R2A BOH FALL COUNT";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(635, 459);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 22);
            this.numericUpDown1.TabIndex = 19;
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(0, 12);
            this.WindowsMediaPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(226, 45);
            this.WindowsMediaPlayer.TabIndex = 7;
            this.WindowsMediaPlayer.Visible = false;
            this.WindowsMediaPlayer.Enter += new System.EventHandler(this.bttnStart_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.END2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ChallengerB);
            this.panel3.Controls.Add(this.ScoreB);
            this.panel3.Controls.Add(this.lblScoreB);
            this.panel3.Location = new System.Drawing.Point(698, 282);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 231);
            this.panel3.TabIndex = 23;
            // 
            // END2
            // 
            this.END2.Location = new System.Drawing.Point(196, 165);
            this.END2.Name = "END2";
            this.END2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.END2.Size = new System.Drawing.Size(121, 46);
            this.END2.TabIndex = 24;
            this.END2.Text = "END";
            this.END2.UseVisualStyleBackColor = true;
            this.END2.Click += new System.EventHandler(this.END2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "R2A BOH FALL COUNT";
            // 
            // ChallengerB
            // 
            this.ChallengerB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChallengerB.AutoSize = true;
            this.ChallengerB.BackColor = System.Drawing.Color.DodgerBlue;
            this.ChallengerB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengerB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChallengerB.Location = new System.Drawing.Point(190, 16);
            this.ChallengerB.Name = "ChallengerB";
            this.ChallengerB.Size = new System.Drawing.Size(103, 36);
            this.ChallengerB.TabIndex = 10;
            this.ChallengerB.Text = "Name 2";
            // 
            // ScoreB
            // 
            this.ScoreB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreB.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreB.Location = new System.Drawing.Point(348, 87);
            this.ScoreB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScoreB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ScoreB.Name = "ScoreB";
            this.ScoreB.Size = new System.Drawing.Size(80, 38);
            this.ScoreB.TabIndex = 0;
            this.ScoreB.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // lblScoreB
            // 
            this.lblScoreB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScoreB.AutoSize = true;
            this.lblScoreB.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblScoreB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScoreB.Location = new System.Drawing.Point(60, 84);
            this.lblScoreB.Name = "lblScoreB";
            this.lblScoreB.Size = new System.Drawing.Size(83, 36);
            this.lblScoreB.TabIndex = 1;
            this.lblScoreB.Text = "Score";
            this.lblScoreB.Click += new System.EventHandler(this.label6_Click);
            // 
            // RoundNew
            // 
            this.RoundNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoundNew.AutoSize = true;
            this.RoundNew.Font = new System.Drawing.Font("Bahnschrift", 25F);
            this.RoundNew.ForeColor = System.Drawing.Color.White;
            this.RoundNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RoundNew.Location = new System.Drawing.Point(178, 189);
            this.RoundNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoundNew.Name = "RoundNew";
            this.RoundNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RoundNew.Size = new System.Drawing.Size(244, 51);
            this.RoundNew.TabIndex = 25;
            this.RoundNew.Text = "Preparation";
            this.RoundNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRound
            // 
            this.lblRound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.White;
            this.lblRound.Location = new System.Drawing.Point(247, 137);
            this.lblRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(105, 33);
            this.lblRound.TabIndex = 24;
            this.lblRound.Text = "Round :";
            this.lblRound.Click += new System.EventHandler(this.lblRound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1227, 655);
            this.Controls.Add(this.RoundNew);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bttnExport;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.Button bttnPause;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Button bttnExit;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Button bttnFinish;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NumericUpDown ScoreA;
        private System.Windows.Forms.Label lblScoreA;
        private System.Windows.Forms.Label ChallengerA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ChallengerB;
        private System.Windows.Forms.NumericUpDown ScoreB;
        private System.Windows.Forms.Label lblScoreB;
        private System.Windows.Forms.Label RoundNew;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button END1;
        private System.Windows.Forms.Button END2;
    }
}

