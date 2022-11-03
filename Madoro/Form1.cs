using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Madoro.Properties;

namespace Madoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textbox_PomodoroDuration.Text) > 0 &&
                    Convert.ToInt32(textbox_BreakDuration.Text) > 0 &&
                    Convert.ToInt32(textbox_LongBreakDuration.Text) > 0 &&
                    Convert.ToInt32(textbox_TotalNumOfPomos.Text) > 0 &&
                    Convert.ToInt32(textbox_NumOfPomosForLongBreak.Text) > 0
                    )
                {
                    Settings.Default["PomoDuration"] = Convert.ToInt32(textbox_PomodoroDuration.Text);
                    Settings.Default["BreakDuration"] = Convert.ToInt32(textbox_BreakDuration.Text);
                    Settings.Default["LongBreakDuration"] = Convert.ToInt32(textbox_LongBreakDuration.Text);
                    Settings.Default["NumOfPomos"] = Convert.ToInt32(textbox_TotalNumOfPomos.Text);
                    Settings.Default["NumOfPomosUntilLongBreak"] = Convert.ToInt32(textbox_NumOfPomosForLongBreak.Text);
                    Settings.Default.isFirstRun = false;
                    Settings.Default.Save();

                    Form2 form2Window = new Form2();
                    form2Window.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong. Make Sure All Fields Are Not Empty And Contain Only Positive " +
                    "Numbers.", "There is something not right!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                        
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong. Make Sure All Fields Are Not Empty And Contain Only Positive " +
                    "Numbers." + "\n\nError Info: " + ex.Message, "There is something not right!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
