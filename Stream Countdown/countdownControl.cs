using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stream_Countdown
{
    public partial class countdownControl : Form
    {
        public static string scriptLocation = "";

        public static handleScript script;
        public static Time countdown;
        public static DateTime current_time = DateTime.Now;

        public static ScriptEditor scrEdit = new ScriptEditor();
        public static ScriptHelp scrHelp = new ScriptHelp();

        public static StreamWriter wAdvancedScript;
        public static StreamReader rAdvancedScript;

        private static bool isCounting = false;
        private static StreamWriter countdownFile;
        private static Time endTime;

        public countdownControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh_timer.Start();

            scriptLocation = Path.Combine(Path.GetDirectoryName(Application.StartupPath), "advancedScript.txt");

            if (!File.Exists(scriptLocation))
            {
                wAdvancedScript = new StreamWriter(scriptLocation);
                wAdvancedScript.Write("");
                wAdvancedScript.Close();
            }

            script = new handleScript(scriptLocation);

            cb_ampm.Checked = !Properties.Settings.Default.ampm;
            cb_custom.Checked = Properties.Settings.Default.CTEnabled;

            rb_finished.Checked = !Properties.Settings.Default.CTAdvanced;
            rb_advancedText.Checked = Properties.Settings.Default.CTAdvanced;

            num_hour.Value = Properties.Settings.Default.hour;
            num_minute.Value = Properties.Settings.Default.minute;
            num_seconds.Value = Properties.Settings.Default.second;

            tb_FileDirectory.Text = Properties.Settings.Default.lastFilePath;
            tb_running.Text = Properties.Settings.Default.CTText;
            tb_finished.Text = Properties.Settings.Default.CTEndText;

            if (Directory.Exists(tb_FileDirectory.Text.Remove(tb_FileDirectory.Text.LastIndexOf('\\') + 1)))
            {
                sfd.InitialDirectory = tb_FileDirectory.Text;
                btn_start.Enabled = true;
            }
            else
            {
                tb_FileDirectory.Text = "";
            }

            if (rb_advancedText.Checked)
            {

            }
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            if (isCounting)
            {
                btn_start.Text = "Start Countdown";
                num_hour.Enabled = true;
                num_minute.Enabled = true;
                num_seconds.Enabled = true;
                isCounting = false;
            }
            else
            {
                endTime = new Time((int)num_hour.Value, (int)num_minute.Value, (int)num_seconds.Value);
                countdown = endTime.timeDifference(current_time, endTime);

                lbl_countdown.Text = countdown.ToString();

                Write_Countdown();

                btn_start.Text = "Stop Countdown";
                num_hour.Enabled = false;
                num_minute.Enabled = false;
                num_seconds.Enabled = false;
                isCounting = true;
            }
        }

        private void btn_selectFile_Click(object sender, EventArgs e)
        {
            var result = sfd.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_FileDirectory.Text = sfd.FileName;
                Properties.Settings.Default.lastFilePath = sfd.FileName;
                btn_start.Enabled = true;
            }
        }

        private void btn_advancedScript_Click(object sender, EventArgs e)
        {
            scrEdit.ShowDialog();
        }


        private void Write_Countdown()
        {
            countdownFile = new StreamWriter(tb_FileDirectory.Text, false);

            if (cb_custom.Checked)
            {
                if (countdown.Hour == 0 && countdown.Minute == 0 && countdown.Second == 0 && (rb_finished.Checked || script.hasEnd))
                {
                    btn_start.PerformClick();

                    if (rb_finished.Checked)
                    {
                        countdownFile.Write(tb_finished.Text);
                    }
                    else
                    {
                        countdownFile.Write(script.getResult(countdown));
                    }
                }
                else
                {
                    if (rb_advancedText.Checked)
                    {
                        countdownFile.Write(countdown.ToString(script.getResult(countdown), !cb_ampm.Checked));
                    }
                    else
                    {
                        countdownFile.Write(countdown.ToString(tb_running.Text, !cb_ampm.Checked));
                    }
                }
            }
            else
            {
                countdownFile.Write(lbl_countdown.Text);
            }

            countdownFile.Close();
        }


        private void refresh_timer_Tick(object sender, EventArgs e)
        {
            if (current_time.Second != DateTime.Now.Second && isCounting)
            {
                countdown = endTime.timeDifference(current_time, endTime);

                lbl_countdown.Text = countdown.ToString(!cb_ampm.Checked);

                Write_Countdown();
            }
            current_time = DateTime.Now;
            lbl_timenow.Text = current_time.ToString("HH:mm:ss");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ampm = !cb_ampm.Checked;
            Properties.Settings.Default.CTEnabled = cb_custom.Checked;
            Properties.Settings.Default.CTAdvanced = rb_advancedText.Checked;

            Properties.Settings.Default.hour = (int)num_hour.Value;
            Properties.Settings.Default.minute = (int)num_minute.Value;
            Properties.Settings.Default.second = (int)num_seconds.Value;
            
            Properties.Settings.Default.CTText = tb_running.Text;
            Properties.Settings.Default.CTEndText = tb_finished.Text;
            Properties.Settings.Default.Save();
        }

        private void rb_advancedText_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_advancedText.Checked)
            {
                btn_advancedScript.Enabled = true;
                tb_finished.Enabled = false;
                tb_running.Enabled = false;
            }
            else
            {
                btn_advancedScript.Enabled = false;
                tb_finished.Enabled = true;
                tb_running.Enabled = true;
            }
        }
    }
}
