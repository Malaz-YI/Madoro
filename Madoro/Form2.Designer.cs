namespace Madoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label_Pomodoro = new System.Windows.Forms.Label();
            this.label_Break = new System.Windows.Forms.Label();
            this.label_LongBreak = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkbox_Minimize = new System.Windows.Forms.CheckBox();
            this.btn_Start = new Madoro.RoundButton();
            this.label_LongBreaksTiming = new System.Windows.Forms.Label();
            this.label_PomoSessions = new System.Windows.Forms.Label();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.myNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Pomodoro
            // 
            this.label_Pomodoro.AutoSize = true;
            this.label_Pomodoro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pomodoro.Location = new System.Drawing.Point(16, 28);
            this.label_Pomodoro.Name = "label_Pomodoro";
            this.label_Pomodoro.Size = new System.Drawing.Size(209, 22);
            this.label_Pomodoro.TabIndex = 0;
            this.label_Pomodoro.Text = "Pomodoro Duration: X";
            // 
            // label_Break
            // 
            this.label_Break.AutoSize = true;
            this.label_Break.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Break.Location = new System.Drawing.Point(16, 65);
            this.label_Break.Name = "label_Break";
            this.label_Break.Size = new System.Drawing.Size(171, 22);
            this.label_Break.TabIndex = 1;
            this.label_Break.Text = "Break Duration: Y";
            // 
            // label_LongBreak
            // 
            this.label_LongBreak.AutoSize = true;
            this.label_LongBreak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LongBreak.Location = new System.Drawing.Point(16, 102);
            this.label_LongBreak.Name = "label_LongBreak";
            this.label_LongBreak.Size = new System.Drawing.Size(221, 22);
            this.label_LongBreak.TabIndex = 2;
            this.label_LongBreak.Text = "Long Break Duration: Z";
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timer.Location = new System.Drawing.Point(274, 166);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(204, 75);
            this.label_Timer.TabIndex = 3;
            this.label_Timer.Text = "00:00";
            this.label_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Webdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(646, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "@";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.checkbox_Minimize);
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Controls.Add(this.label_LongBreaksTiming);
            this.panel1.Controls.Add(this.label_PomoSessions);
            this.panel1.Controls.Add(this.btn_Pause);
            this.panel1.Controls.Add(this.label_Pomodoro);
            this.panel1.Controls.Add(this.label_LongBreak);
            this.panel1.Controls.Add(this.label_Timer);
            this.panel1.Controls.Add(this.label_Break);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 697);
            this.panel1.TabIndex = 7;
            // 
            // checkbox_Minimize
            // 
            this.checkbox_Minimize.AutoSize = true;
            this.checkbox_Minimize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_Minimize.Location = new System.Drawing.Point(189, 562);
            this.checkbox_Minimize.Name = "checkbox_Minimize";
            this.checkbox_Minimize.Size = new System.Drawing.Size(365, 26);
            this.checkbox_Minimize.TabIndex = 8;
            this.checkbox_Minimize.Text = "Hide In System Tray When Minimized";
            this.checkbox_Minimize.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(236)))), ((int)(((byte)(141)))));
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(312, 280);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(120, 120);
            this.btn_Start.TabIndex = 11;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label_LongBreaksTiming
            // 
            this.label_LongBreaksTiming.AutoSize = true;
            this.label_LongBreaksTiming.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LongBreaksTiming.Location = new System.Drawing.Point(17, 654);
            this.label_LongBreaksTiming.Name = "label_LongBreaksTiming";
            this.label_LongBreaksTiming.Size = new System.Drawing.Size(102, 15);
            this.label_LongBreaksTiming.TabIndex = 9;
            this.label_LongBreaksTiming.Text = "Long Breaks: L";
            // 
            // label_PomoSessions
            // 
            this.label_PomoSessions.AutoSize = true;
            this.label_PomoSessions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PomoSessions.Location = new System.Drawing.Point(17, 624);
            this.label_PomoSessions.Name = "label_PomoSessions";
            this.label_PomoSessions.Size = new System.Drawing.Size(180, 15);
            this.label_PomoSessions.TabIndex = 8;
            this.label_PomoSessions.Text = "Pomodoro Sessions Left: K";
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Pause.FlatAppearance.BorderSize = 0;
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pause.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.Location = new System.Drawing.Point(323, 423);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(100, 100);
            this.btn_Pause.TabIndex = 7;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // myNotification
            // 
            this.myNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.myNotification.BalloonTipText = "Madoro Will Be Minimized";
            this.myNotification.BalloonTipTitle = "Madoro";
            this.myNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotification.Icon")));
            this.myNotification.Text = "Madoro";
            this.myNotification.Visible = true;
            this.myNotification.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myNotification_MouseDoubleClick);
            this.myNotification.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myNotification_MouseDoubleClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(743, 697);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Madoro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Pomodoro;
        private System.Windows.Forms.Label label_Break;
        private System.Windows.Forms.Label label_LongBreak;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Label label_LongBreaksTiming;
        private System.Windows.Forms.Label label_PomoSessions;
        private RoundButton btn_Start;
        private System.Windows.Forms.CheckBox checkbox_Minimize;
        private System.Windows.Forms.NotifyIcon myNotification;
    }
}