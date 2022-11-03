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
            this.label_Pomodoro = new System.Windows.Forms.Label();
            this.label_Break = new System.Windows.Forms.Label();
            this.label_LongBreak = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.label_PomoSessions = new System.Windows.Forms.Label();
            this.label_LongBreaksTiming = new System.Windows.Forms.Label();
            this.btn_Start = new Madoro.RoundButton();
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.label_LongBreaksTiming);
            this.panel1.Controls.Add(this.label_PomoSessions);
            this.panel1.Controls.Add(this.btn_Pause);
            this.panel1.Controls.Add(this.btn_Start);
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
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pause.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.Location = new System.Drawing.Point(321, 439);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(100, 100);
            this.btn_Pause.TabIndex = 7;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
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
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(311, 299);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(120, 120);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(743, 697);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Madoro";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private RoundButton btn_Start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Label label_LongBreaksTiming;
        private System.Windows.Forms.Label label_PomoSessions;
    }
}