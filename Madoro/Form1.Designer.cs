namespace Madoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_PomodoroDuration = new System.Windows.Forms.TextBox();
            this.textbox_LongBreakDuration = new System.Windows.Forms.TextBox();
            this.textbox_NumOfPomosForLongBreak = new System.Windows.Forms.TextBox();
            this.textbox_TotalNumOfPomos = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_BreakDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pomodoro Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(458, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number Of Pomodoros Until Long Break";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(417, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Number Of Pomodoro Sessions";
            // 
            // textbox_PomodoroDuration
            // 
            this.textbox_PomodoroDuration.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_PomodoroDuration.ForeColor = System.Drawing.Color.Green;
            this.textbox_PomodoroDuration.Location = new System.Drawing.Point(537, 71);
            this.textbox_PomodoroDuration.Name = "textbox_PomodoroDuration";
            this.textbox_PomodoroDuration.Size = new System.Drawing.Size(71, 35);
            this.textbox_PomodoroDuration.TabIndex = 1;
            this.textbox_PomodoroDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_LongBreakDuration
            // 
            this.textbox_LongBreakDuration.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_LongBreakDuration.ForeColor = System.Drawing.Color.Teal;
            this.textbox_LongBreakDuration.Location = new System.Drawing.Point(537, 223);
            this.textbox_LongBreakDuration.Name = "textbox_LongBreakDuration";
            this.textbox_LongBreakDuration.Size = new System.Drawing.Size(71, 35);
            this.textbox_LongBreakDuration.TabIndex = 3;
            this.textbox_LongBreakDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_NumOfPomosForLongBreak
            // 
            this.textbox_NumOfPomosForLongBreak.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_NumOfPomosForLongBreak.ForeColor = System.Drawing.Color.Navy;
            this.textbox_NumOfPomosForLongBreak.Location = new System.Drawing.Point(537, 375);
            this.textbox_NumOfPomosForLongBreak.Name = "textbox_NumOfPomosForLongBreak";
            this.textbox_NumOfPomosForLongBreak.Size = new System.Drawing.Size(71, 35);
            this.textbox_NumOfPomosForLongBreak.TabIndex = 5;
            this.textbox_NumOfPomosForLongBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textbox_TotalNumOfPomos
            // 
            this.textbox_TotalNumOfPomos.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_TotalNumOfPomos.ForeColor = System.Drawing.Color.Purple;
            this.textbox_TotalNumOfPomos.Location = new System.Drawing.Point(537, 299);
            this.textbox_TotalNumOfPomos.Name = "textbox_TotalNumOfPomos";
            this.textbox_TotalNumOfPomos.Size = new System.Drawing.Size(71, 35);
            this.textbox_TotalNumOfPomos.TabIndex = 4;
            this.textbox_TotalNumOfPomos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(52)))), ((int)(((byte)(30)))));
            this.btn_Save.FlatAppearance.BorderSize = 5;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(52)))), ((int)(((byte)(30)))));
            this.btn_Save.Location = new System.Drawing.Point(78, 469);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(530, 56);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save Settings";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Break Duration";
            // 
            // textbox_BreakDuration
            // 
            this.textbox_BreakDuration.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_BreakDuration.ForeColor = System.Drawing.Color.Maroon;
            this.textbox_BreakDuration.Location = new System.Drawing.Point(537, 147);
            this.textbox_BreakDuration.Name = "textbox_BreakDuration";
            this.textbox_BreakDuration.Size = new System.Drawing.Size(71, 35);
            this.textbox_BreakDuration.TabIndex = 2;
            this.textbox_BreakDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Long Break Duration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(705, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_BreakDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_LongBreakDuration);
            this.Controls.Add(this.textbox_PomodoroDuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.textbox_TotalNumOfPomos);
            this.Controls.Add(this.textbox_NumOfPomosForLongBreak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Madoro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_PomodoroDuration;
        private System.Windows.Forms.TextBox textbox_LongBreakDuration;
        private System.Windows.Forms.TextBox textbox_NumOfPomosForLongBreak;
        private System.Windows.Forms.TextBox textbox_TotalNumOfPomos;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_BreakDuration;
        private System.Windows.Forms.Label label2;
    }
}

