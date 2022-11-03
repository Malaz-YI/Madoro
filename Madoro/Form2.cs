using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Madoro.Properties;


namespace Madoro
{
    public partial class Form2 : Form
    {
        public int pomodoroDuration = Settings.Default.PomoDuration;
        //Test public int pomodoroDuration = 2;
        public int breakDuration = Settings.Default.BreakDuration;
        //Test public int breakDuration = 1;
        public int longBreakDuration = Settings.Default.LongBreakDuration;
        //Test public int longBreakDuration = 3;
        public int totalPomodorosCount = Settings.Default.NumOfPomos;
        //Test: public int totalPomodorosCount = 3;
        public int numOfPomosUnitlLong = Settings.Default.NumOfPomosUntilLongBreak;
        //Test public int numOfPomosUnitlLong = 2;
        public int pomosRunCount = 0;
        public int pomosLeftCount = 0;
        public int startFiresCount = 0;
        public int startingSeconds = 0;

        public Form2()
        {
            InitializeComponent();
        }

        #region Timer
        public System.Windows.Forms.Timer myCountdown = new System.Windows.Forms.Timer();
        public void TimerStart()
        {
            myCountdown.Tick -= MyCountdown_Tick;
            myCountdown.Enabled = true;
            myCountdown.Interval = 1000;
            myCountdown.Start();
            myCountdown.Tick += MyCountdown_Tick;
        }

        private void MyCountdown_Tick(object sender, EventArgs e)
        {
            // Run a Pomodoro timer only when the start button has been fired for an odd number of times
            // (as the breaks and pomodoros are alternating constantly, the break comes next at an even round.
            // And run it only when the max pomodorosCount is not met yet
            if (pomosRunCount < totalPomodorosCount && (startFiresCount % 2 == 0 || startFiresCount == 0))
            {
                startPomodoroSession();
            }
            else if (pomosRunCount % numOfPomosUnitlLong != 0 && pomosRunCount < totalPomodorosCount)
            {
                starBreakSession();
            }
            else if (pomosRunCount % numOfPomosUnitlLong == 0 && pomosRunCount < totalPomodorosCount)
            {
                starLongBreakSession();
            }
            else {
                myCountdown.Enabled = false;
                MessageBox.Show("End of The Whole Cycle");
                btn_Pause.Enabled = false;
            }
        }

        #endregion
        private void Form2_Load(object sender, EventArgs e)
        {
            label_Pomodoro.Text = "Pomodoro Duration: " + pomodoroDuration + " minutes";
            label_Break.Text = "Break Duration: " + breakDuration + " minutes";
            label_LongBreak.Text = "Long Break Duration: " + longBreakDuration + " minutes";
            pomosLeftCount = totalPomodorosCount;
            label_PomoSessions.Text = "Pomodoro Sessions Left: " + pomosLeftCount;
            label_LongBreaksTiming.Text = "Long Breaks: Will Start After Each " + numOfPomosUnitlLong + " Pomodoros.";

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            TimerStart();
            btn_Start.Enabled = false;
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if (myCountdown.Enabled)
            {
                myCountdown.Stop();
                myCountdown.Enabled = false;
                btn_Start.Text = "Continue";
                btn_Start.Enabled = true;
                btn_Start.Font = new Font("Arial Rounded MT Bold", 16);
            }
            
        }

        // Functions:
        public void startPomodoroSession()
        {
            label_Pomodoro.ForeColor = Color.Blue;
            if (pomodoroDuration > 0 || startingSeconds >= 0)
            {
                label_Timer.Text = pomodoroDuration.ToString("D2") + ":" + startingSeconds.ToString("D2");
                if (startingSeconds != 0)
                {
                    startingSeconds = startingSeconds - 1;
                }
                else if (startingSeconds == 0 && pomodoroDuration > 0)
                {
                    startingSeconds = 59;
                    pomodoroDuration = pomodoroDuration - 1;
                }
                else if (startingSeconds == 0 && pomodoroDuration == 0)
                {
                    label_Timer.Text = "00:00";
                    // Timer has ended:
                    myCountdown.Stop();
                    myCountdown.Enabled = false;
                    // Make  sound effect:
                    System.Media.SoundPlayer endSound = new System.Media.SoundPlayer(@".\Music\pomodoroEnd.wav");
                    endSound.Play();
                    // Enable Start button
                    btn_Start.Enabled = true;
                    btn_Start.Text = "Start";
                    btn_Start.Font = new Font("Arial Rounded MT Bold", 16);
                    // Increase Pomodoros Run Counter & Change Label Color
                    pomosRunCount++;
                    label_Pomodoro.ForeColor = Color.Black;
                    // Reset The Original Duration
                    pomodoroDuration = Settings.Default.PomoDuration;
                    // Decrease the visible (for show only) pomodoros left count:
                    pomosLeftCount--;
                    label_PomoSessions.Text = "Pomodoro Sessions Left: " + pomosLeftCount;
                    startFiresCount++;
                }
            }
        }
        public void starBreakSession() 
        {
            label_Break.ForeColor = Color.Blue;
            if (breakDuration > 0 || startingSeconds >= 0)
            {
                label_Timer.Text = breakDuration.ToString("D2") + ":" + startingSeconds.ToString("D2");
                if (startingSeconds != 0)
                {
                    startingSeconds = startingSeconds - 1;
                }
                else if (startingSeconds == 0 && breakDuration > 0)
                {
                    startingSeconds = 59;
                    breakDuration = breakDuration - 1;
                }
                else if (startingSeconds == 0 && breakDuration == 0)
                {
                    label_Timer.Text = "00:00";
                    // Timer has ended:
                    myCountdown.Stop();
                    myCountdown.Enabled = false;
                    // Make  sound effect:
                    System.Media.SoundPlayer endSound = new System.Media.SoundPlayer(@".\Music\breakEnd.wav");
                    endSound.Play();
                    // Enable Start button
                    btn_Start.Enabled = true;
                    btn_Start.Text = "Start";
                    btn_Start.Font = new Font("Arial Rounded MT Bold", 16);
                    label_Break.ForeColor = Color.Black;
                    // Reset The Original Duration
                    breakDuration = Settings.Default.BreakDuration;
                    startFiresCount++;

                }
            }
        }
        public void starLongBreakSession()
        {
            label_LongBreak.ForeColor = Color.Blue;
            if (longBreakDuration > 0 || startingSeconds >= 0)
            {
                label_Timer.Text = longBreakDuration.ToString("D2") + ":" + startingSeconds.ToString("D2");
                if (startingSeconds != 0)
                {
                    startingSeconds = startingSeconds - 1;
                }
                else if (startingSeconds == 0 && longBreakDuration > 0)
                {
                    startingSeconds = 59;
                    longBreakDuration = longBreakDuration - 1;
                }
                else if (startingSeconds == 0 && longBreakDuration == 0)
                {
                    label_Timer.Text = "00:00";
                    // Timer has ended:
                    myCountdown.Stop();
                    myCountdown.Enabled = false;
                    // Make  sound effect:
                    System.Media.SoundPlayer endSound = new System.Media.SoundPlayer(@".\Music\longBreakEnd.wav");
                    endSound.Play();
                    // Enable Start button
                    btn_Start.Enabled = true;
                    btn_Start.Text = "Start";
                    btn_Start.Font = new Font("Arial Rounded MT Bold", 16);
                    label_LongBreak.ForeColor = Color.Black;
                    // Reset The Original Duration
                    longBreakDuration = Settings.Default.LongBreakDuration;
                    startFiresCount++;

                }
            }
        }

        public void SendToTray()
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                myNotification.Visible = true;
                this.ShowInTaskbar = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1Window = new Form1();
            form1Window.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && checkbox_Minimize.Checked)
            {
                SendToTray();
                this.ShowInTaskbar = false;
            }
        }

        private void myNotification_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            myNotification.Visible = false;
        }
    }
}

