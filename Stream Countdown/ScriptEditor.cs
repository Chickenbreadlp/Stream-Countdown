using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Stream_Countdown
{
    public partial class ScriptEditor : Form
    {
        private bool isLoading = false;

        public ScriptEditor()
        {
            InitializeComponent();
        }

        private void ScriptEditor_Load(object sender, EventArgs e)
        {
            isLoading = true;

            tb_editor.Text = "";

            countdownControl.rAdvancedScript = new StreamReader(countdownControl.scriptLocation);

            if (!countdownControl.rAdvancedScript.EndOfStream)
            {
                tb_editor.Text += countdownControl.rAdvancedScript.ReadLine();
            }

            while (!countdownControl.rAdvancedScript.EndOfStream)
            {
                tb_editor.Text += @"
" + countdownControl.rAdvancedScript.ReadLine();
            }

            countdownControl.rAdvancedScript.Close();


            tsb_addStandard.Visible = false;

            if (!tb_editor.Text.Contains("#Otherwise"))
            {
                tb_editor.Paste(@"

#Otherwise
'AddTextHere'");
            }

            if (tb_editor.Text.Contains("#End"))
            {
                tsb_addEnd.Visible = false;
            }
            else
            {
                tsb_addEnd.Visible = true;
            }

            tb_editor.Select(0, 0);

            isLoading = false;
        }

        #region Editor Buttons
        private void tsb_addStandard_Click(object sender, EventArgs e)
        {
            int index = tb_editor.SelectionStart;

            int line = tb_editor.GetLineFromCharIndex(index) + 1;
            int endOfLineIndex;

            endOfLineIndex = tb_editor.GetFirstCharIndexFromLine(line) - 2;

            if (tb_editor.Text != "")
            {
                if (index >= tb_editor.GetFirstCharIndexFromLine(line - 1) + tb_editor.Lines[line - 1].ToCharArray().Length - 1)
                {
                    endOfLineIndex = index;
                }
            }

            if (index == endOfLineIndex)
            {
                tb_editor.Paste(@"
");
            }

            tb_editor.Paste(@"#Otherwise
'AddTextHere'");

            if (tb_editor.Text != "" && index - tb_editor.GetFirstCharIndexFromLine(line) < 1)
            {
                tb_editor.Paste(@"
");
            }
        }

        private void tsb_addEnd_Click(object sender, EventArgs e)
        {
            int index = tb_editor.SelectionStart;

            int line = tb_editor.GetLineFromCharIndex(index) + 1;
            int endOfLineIndex;

            endOfLineIndex = tb_editor.GetFirstCharIndexFromLine(line) - 2;

            if (tb_editor.Text != "")
            {
                if (index >= tb_editor.GetFirstCharIndexFromLine(line - 1) + tb_editor.Lines[line - 1].ToCharArray().Length - 1)
                {
                    endOfLineIndex = index;
                }
            }

            if (index == endOfLineIndex)
            {
                tb_editor.Paste(@"
");
            }

            tb_editor.Paste(@"#End
'AddTextHere'");

            if (tb_editor.Text != "" && index - tb_editor.GetFirstCharIndexFromLine(line) < 1)
            {
                tb_editor.Paste(@"
");
            }
        }

        private void tsb_addCon_Click(object sender, EventArgs e)
        {
            int index = tb_editor.SelectionStart;

            int line = tb_editor.GetLineFromCharIndex(index);
            int endOfLineIndex;

            endOfLineIndex = tb_editor.GetFirstCharIndexFromLine(line + 1) - 2;

            if (tb_editor.Text != "")
            {
                if (index >= tb_editor.GetFirstCharIndexFromLine(line) + tb_editor.Lines[line].ToCharArray().Length - 1)
                {
                    endOfLineIndex = index;
                }
            }

            if (index == endOfLineIndex)
            {
                tb_editor.Paste(@"
");
            }

            tb_editor.Paste(@"#IF-type=value
'AddTextHere'");

            if (tb_editor.Text != "" && index - tb_editor.GetFirstCharIndexFromLine(line) < 1)
            {
                tb_editor.Paste(@"
");
            }
        }

        private void tsb_addMulti_Click(object sender, EventArgs e)
        {
            int index = tb_editor.SelectionStart;

            int line = tb_editor.GetLineFromCharIndex(index);
            int endOfLineIndex;

            endOfLineIndex = tb_editor.GetFirstCharIndexFromLine(line + 1) - 2;

            if (tb_editor.Text != "")
            {
                if (index >= tb_editor.GetFirstCharIndexFromLine(line) + tb_editor.Lines[line].ToCharArray().Length - 1)
                {
                    endOfLineIndex = index;
                }
            }

            if (index == endOfLineIndex)
            {
                tb_editor.Paste(@"
");
            }

            tb_editor.Paste(@"#MIF-type=value&type=value
'AddTextHere'");

            if (tb_editor.Text != "" && index - tb_editor.GetFirstCharIndexFromLine(line) < 1)
            {
                tb_editor.Paste(@"
");
            }
        }


        private void tsb_second_Click(object sender, EventArgs e)
        {
            tb_editor.Paste("seconds");
        }

        private void tsb_minute_Click(object sender, EventArgs e)
        {
            tb_editor.Paste("minutes");
        }

        private void tsb_hour_Click(object sender, EventArgs e)
        {
            tb_editor.Paste("hours");
        }


        private void tsb_sec_Click(object sender, EventArgs e)
        {
            tb_editor.Paste("%s");
        }

        private void tsb_secT_Click(object sender, EventArgs e)
        {
            tb_editor.Paste("%S");
        }


        private void tsb_min_Click(object sender, EventArgs e)
        {
            tb_editor.Paste("%m");
        }

        private void tsb_minT_Click(object sender, EventArgs e)
        {
            tb_editor.Paste("%M");
        }


        private void tsb_hou_Click(object sender, EventArgs e)
        {
            tb_editor.Paste("%h");
        }

        private void tsb_houT_Click(object sender, EventArgs e)
        {
            tb_editor.Paste("%H");
        }


        private void tsb_ampm_Click(object sender, EventArgs e)
        {
            tb_editor.Paste("%a");
        }
        #endregion

        private void tsb_help_Click(object sender, EventArgs e)
        {
            countdownControl.scrHelp.ShowDialog();
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            countdownControl.wAdvancedScript = new StreamWriter(countdownControl.scriptLocation);
            countdownControl.wAdvancedScript.Write(tb_editor.Text);
            countdownControl.wAdvancedScript.Close();
            countdownControl.script.loadScript();
        }

        private void tb_editor_TextChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                if (!tb_editor.Text.Contains("#Otherwise"))
                {
                    tb_editor.Text += @"

#Otherwise
'AddTextHere'";
                }

                if (tb_editor.Text.Contains("#End"))
                {
                    tsb_addEnd.Visible = false;
                }
                else
                {
                    tsb_addEnd.Visible = true;
                }
            }
        }
    }
}
