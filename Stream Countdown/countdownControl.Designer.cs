namespace Stream_Countdown
{
    partial class countdownControl
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(countdownControl));
            this.num_hour = new System.Windows.Forms.NumericUpDown();
            this.num_minute = new System.Windows.Forms.NumericUpDown();
            this.num_seconds = new System.Windows.Forms.NumericUpDown();
            this.gb_start = new System.Windows.Forms.GroupBox();
            this.gb_current = new System.Windows.Forms.GroupBox();
            this.lbl_timenow = new System.Windows.Forms.Label();
            this.refresh_timer = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.gb_countdown = new System.Windows.Forms.GroupBox();
            this.lbl_countdown = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.tb_FileDirectory = new System.Windows.Forms.TextBox();
            this.btn_selectFile = new System.Windows.Forms.Button();
            this.cb_custom = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_advancedScript = new System.Windows.Forms.Button();
            this.rb_advancedText = new System.Windows.Forms.RadioButton();
            this.rb_finished = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_finished = new System.Windows.Forms.TextBox();
            this.tb_running = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cb_ampm = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_seconds)).BeginInit();
            this.gb_start.SuspendLayout();
            this.gb_current.SuspendLayout();
            this.gb_countdown.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_hour
            // 
            this.num_hour.Location = new System.Drawing.Point(8, 19);
            this.num_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.num_hour.Name = "num_hour";
            this.num_hour.Size = new System.Drawing.Size(33, 20);
            this.num_hour.TabIndex = 0;
            this.num_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_minute
            // 
            this.num_minute.Location = new System.Drawing.Point(47, 19);
            this.num_minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_minute.Name = "num_minute";
            this.num_minute.Size = new System.Drawing.Size(33, 20);
            this.num_minute.TabIndex = 1;
            this.num_minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_seconds
            // 
            this.num_seconds.Location = new System.Drawing.Point(86, 19);
            this.num_seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_seconds.Name = "num_seconds";
            this.num_seconds.Size = new System.Drawing.Size(33, 20);
            this.num_seconds.TabIndex = 2;
            this.num_seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb_start
            // 
            this.gb_start.Controls.Add(this.num_hour);
            this.gb_start.Controls.Add(this.num_seconds);
            this.gb_start.Controls.Add(this.num_minute);
            this.gb_start.Location = new System.Drawing.Point(12, 12);
            this.gb_start.Name = "gb_start";
            this.gb_start.Size = new System.Drawing.Size(126, 53);
            this.gb_start.TabIndex = 3;
            this.gb_start.TabStop = false;
            this.gb_start.Text = "Starting Time";
            // 
            // gb_current
            // 
            this.gb_current.Controls.Add(this.lbl_timenow);
            this.gb_current.Location = new System.Drawing.Point(144, 12);
            this.gb_current.Name = "gb_current";
            this.gb_current.Size = new System.Drawing.Size(126, 53);
            this.gb_current.TabIndex = 4;
            this.gb_current.TabStop = false;
            this.gb_current.Text = "Current Time";
            // 
            // lbl_timenow
            // 
            this.lbl_timenow.Location = new System.Drawing.Point(6, 21);
            this.lbl_timenow.Name = "lbl_timenow";
            this.lbl_timenow.Size = new System.Drawing.Size(114, 18);
            this.lbl_timenow.TabIndex = 5;
            this.lbl_timenow.Text = "CurrentTime";
            this.lbl_timenow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // refresh_timer
            // 
            this.refresh_timer.Interval = 50;
            this.refresh_timer.Tick += new System.EventHandler(this.refresh_timer_Tick);
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(153, 101);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(111, 23);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "Start Countdown";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // gb_countdown
            // 
            this.gb_countdown.Controls.Add(this.lbl_countdown);
            this.gb_countdown.Location = new System.Drawing.Point(12, 71);
            this.gb_countdown.Name = "gb_countdown";
            this.gb_countdown.Size = new System.Drawing.Size(126, 53);
            this.gb_countdown.TabIndex = 7;
            this.gb_countdown.TabStop = false;
            this.gb_countdown.Text = "Countdown";
            // 
            // lbl_countdown
            // 
            this.lbl_countdown.Location = new System.Drawing.Point(6, 21);
            this.lbl_countdown.Name = "lbl_countdown";
            this.lbl_countdown.Size = new System.Drawing.Size(114, 23);
            this.lbl_countdown.TabIndex = 8;
            this.lbl_countdown.Text = "Countdown";
            this.lbl_countdown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sfd
            // 
            this.sfd.FileName = "countdown";
            this.sfd.Filter = "Text-Files|*.txt|All Files|*:*";
            this.sfd.InitialDirectory = "%userprofile%\\Documents";
            // 
            // tb_FileDirectory
            // 
            this.tb_FileDirectory.Location = new System.Drawing.Point(12, 370);
            this.tb_FileDirectory.Name = "tb_FileDirectory";
            this.tb_FileDirectory.ReadOnly = true;
            this.tb_FileDirectory.Size = new System.Drawing.Size(260, 20);
            this.tb_FileDirectory.TabIndex = 8;
            // 
            // btn_selectFile
            // 
            this.btn_selectFile.Location = new System.Drawing.Point(12, 341);
            this.btn_selectFile.Name = "btn_selectFile";
            this.btn_selectFile.Size = new System.Drawing.Size(103, 23);
            this.btn_selectFile.TabIndex = 9;
            this.btn_selectFile.Text = "Select File";
            this.toolTip.SetToolTip(this.btn_selectFile, "Use the Following Characters:\r\n   %s\\tSeconds\r\n   %m\\tMinutes\r\n   %h\\tHours");
            this.btn_selectFile.UseVisualStyleBackColor = true;
            this.btn_selectFile.Click += new System.EventHandler(this.btn_selectFile_Click);
            // 
            // cb_custom
            // 
            this.cb_custom.AutoSize = true;
            this.cb_custom.Location = new System.Drawing.Point(6, 19);
            this.cb_custom.Name = "cb_custom";
            this.cb_custom.Size = new System.Drawing.Size(65, 17);
            this.cb_custom.TabIndex = 10;
            this.cb_custom.Text = "Activate";
            this.cb_custom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_advancedScript);
            this.groupBox1.Controls.Add(this.rb_advancedText);
            this.groupBox1.Controls.Add(this.rb_finished);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_finished);
            this.groupBox1.Controls.Add(this.tb_running);
            this.groupBox1.Controls.Add(this.cb_custom);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 181);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Text";
            // 
            // btn_advancedScript
            // 
            this.btn_advancedScript.Enabled = false;
            this.btn_advancedScript.Location = new System.Drawing.Point(6, 149);
            this.btn_advancedScript.Name = "btn_advancedScript";
            this.btn_advancedScript.Size = new System.Drawing.Size(246, 23);
            this.btn_advancedScript.TabIndex = 19;
            this.btn_advancedScript.Text = "Open Advanced Script Editor";
            this.btn_advancedScript.UseVisualStyleBackColor = true;
            this.btn_advancedScript.Click += new System.EventHandler(this.btn_advancedScript_Click);
            // 
            // rb_advancedText
            // 
            this.rb_advancedText.AutoSize = true;
            this.rb_advancedText.Location = new System.Drawing.Point(113, 39);
            this.rb_advancedText.Name = "rb_advancedText";
            this.rb_advancedText.Size = new System.Drawing.Size(125, 17);
            this.rb_advancedText.TabIndex = 18;
            this.rb_advancedText.Text = "More Advanced Text";
            this.rb_advancedText.UseVisualStyleBackColor = true;
            this.rb_advancedText.CheckedChanged += new System.EventHandler(this.rb_advancedText_CheckedChanged);
            // 
            // rb_finished
            // 
            this.rb_finished.AutoSize = true;
            this.rb_finished.Checked = true;
            this.rb_finished.Location = new System.Drawing.Point(113, 16);
            this.rb_finished.Name = "rb_finished";
            this.rb_finished.Size = new System.Drawing.Size(139, 17);
            this.rb_finished.TabIndex = 16;
            this.rb_finished.TabStop = true;
            this.rb_finished.Text = "Basic Finished Message";
            this.rb_finished.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "When Countdown finished";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "While running...";
            this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // tb_finished
            // 
            this.tb_finished.Location = new System.Drawing.Point(6, 123);
            this.tb_finished.Name = "tb_finished";
            this.tb_finished.Size = new System.Drawing.Size(246, 20);
            this.tb_finished.TabIndex = 12;
            // 
            // tb_running
            // 
            this.tb_running.Location = new System.Drawing.Point(6, 79);
            this.tb_running.Name = "tb_running";
            this.tb_running.Size = new System.Drawing.Size(246, 20);
            this.tb_running.TabIndex = 11;
            // 
            // cb_ampm
            // 
            this.cb_ampm.AutoSize = true;
            this.cb_ampm.Checked = true;
            this.cb_ampm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ampm.Location = new System.Drawing.Point(153, 78);
            this.cb_ampm.Name = "cb_ampm";
            this.cb_ampm.Size = new System.Drawing.Size(69, 17);
            this.cb_ampm.TabIndex = 12;
            this.cb_ampm.Text = "24 Hours";
            this.cb_ampm.UseVisualStyleBackColor = true;
            // 
            // countdownControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 402);
            this.Controls.Add(this.cb_ampm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_selectFile);
            this.Controls.Add(this.tb_FileDirectory);
            this.Controls.Add(this.gb_countdown);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.gb_current);
            this.Controls.Add(this.gb_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "countdownControl";
            this.Text = "Stream Countdown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_seconds)).EndInit();
            this.gb_start.ResumeLayout(false);
            this.gb_current.ResumeLayout(false);
            this.gb_countdown.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_hour;
        private System.Windows.Forms.NumericUpDown num_minute;
        private System.Windows.Forms.NumericUpDown num_seconds;
        private System.Windows.Forms.GroupBox gb_start;
        private System.Windows.Forms.GroupBox gb_current;
        private System.Windows.Forms.Label lbl_timenow;
        private System.Windows.Forms.Timer refresh_timer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox gb_countdown;
        private System.Windows.Forms.Label lbl_countdown;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.TextBox tb_FileDirectory;
        private System.Windows.Forms.Button btn_selectFile;
        private System.Windows.Forms.CheckBox cb_custom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_finished;
        private System.Windows.Forms.TextBox tb_running;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox cb_ampm;
        private System.Windows.Forms.Button btn_advancedScript;
        private System.Windows.Forms.RadioButton rb_advancedText;
        private System.Windows.Forms.RadioButton rb_finished;
    }
}

