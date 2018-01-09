namespace Stream_Countdown
{
    partial class ScriptEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptEditor));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_addCon = new System.Windows.Forms.ToolStripButton();
            this.tsb_addStandard = new System.Windows.Forms.ToolStripButton();
            this.tsb_addEnd = new System.Windows.Forms.ToolStripButton();
            this.tsb_help = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_second = new System.Windows.Forms.ToolStripButton();
            this.tsb_minute = new System.Windows.Forms.ToolStripButton();
            this.tsb_hour = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_sec = new System.Windows.Forms.ToolStripButton();
            this.tsb_secT = new System.Windows.Forms.ToolStripButton();
            this.tsb_min = new System.Windows.Forms.ToolStripButton();
            this.tsb_minT = new System.Windows.Forms.ToolStripButton();
            this.tsb_hou = new System.Windows.Forms.ToolStripButton();
            this.tsb_houT = new System.Windows.Forms.ToolStripButton();
            this.tsb_ampm = new System.Windows.Forms.ToolStripButton();
            this.tb_editor = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsb_addMulti = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save,
            this.toolStripSeparator1,
            this.tsb_addCon,
            this.tsb_addMulti,
            this.tsb_addStandard,
            this.tsb_addEnd,
            this.tsb_help,
            this.toolStripSeparator2,
            this.tsb_second,
            this.tsb_minute,
            this.tsb_hour,
            this.toolStripSeparator3,
            this.tsb_sec,
            this.tsb_secT,
            this.tsb_min,
            this.tsb_minT,
            this.tsb_hou,
            this.tsb_houT,
            this.tsb_ampm});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(956, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = global::Stream_Countdown.Properties.Resources.Save_20x;
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "Save";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_addCon
            // 
            this.tsb_addCon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_addCon.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_addCon.Image = ((System.Drawing.Image)(resources.GetObject("tsb_addCon.Image")));
            this.tsb_addCon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addCon.Name = "tsb_addCon";
            this.tsb_addCon.Size = new System.Drawing.Size(32, 22);
            this.tsb_addCon.Text = "#IF";
            this.tsb_addCon.ToolTipText = "Adds a new Condition. May Contain placeholders.\r\nMay use Value Expressions";
            this.tsb_addCon.Click += new System.EventHandler(this.tsb_addCon_Click);
            // 
            // tsb_addStandard
            // 
            this.tsb_addStandard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_addStandard.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_addStandard.Image = ((System.Drawing.Image)(resources.GetObject("tsb_addStandard.Image")));
            this.tsb_addStandard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addStandard.Name = "tsb_addStandard";
            this.tsb_addStandard.Size = new System.Drawing.Size(81, 22);
            this.tsb_addStandard.Text = "#Otherwise";
            this.tsb_addStandard.Click += new System.EventHandler(this.tsb_addStandard_Click);
            // 
            // tsb_addEnd
            // 
            this.tsb_addEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_addEnd.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_addEnd.Image = ((System.Drawing.Image)(resources.GetObject("tsb_addEnd.Image")));
            this.tsb_addEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addEnd.Name = "tsb_addEnd";
            this.tsb_addEnd.Size = new System.Drawing.Size(39, 22);
            this.tsb_addEnd.Text = "#End";
            this.tsb_addEnd.Click += new System.EventHandler(this.tsb_addEnd_Click);
            // 
            // tsb_help
            // 
            this.tsb_help.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_help.Image = ((System.Drawing.Image)(resources.GetObject("tsb_help.Image")));
            this.tsb_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_help.Name = "tsb_help";
            this.tsb_help.Size = new System.Drawing.Size(36, 22);
            this.tsb_help.Text = "Help";
            this.tsb_help.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsb_help.Click += new System.EventHandler(this.tsb_help_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_second
            // 
            this.tsb_second.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_second.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_second.Image = ((System.Drawing.Image)(resources.GetObject("tsb_second.Image")));
            this.tsb_second.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_second.Name = "tsb_second";
            this.tsb_second.Size = new System.Drawing.Size(60, 22);
            this.tsb_second.Text = "seconds";
            this.tsb_second.Click += new System.EventHandler(this.tsb_second_Click);
            // 
            // tsb_minute
            // 
            this.tsb_minute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_minute.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_minute.Image = ((System.Drawing.Image)(resources.GetObject("tsb_minute.Image")));
            this.tsb_minute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_minute.Name = "tsb_minute";
            this.tsb_minute.Size = new System.Drawing.Size(60, 22);
            this.tsb_minute.Text = "minutes";
            this.tsb_minute.Click += new System.EventHandler(this.tsb_minute_Click);
            // 
            // tsb_hour
            // 
            this.tsb_hour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_hour.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_hour.Image = ((System.Drawing.Image)(resources.GetObject("tsb_hour.Image")));
            this.tsb_hour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_hour.Name = "tsb_hour";
            this.tsb_hour.Size = new System.Drawing.Size(46, 22);
            this.tsb_hour.Text = "hours";
            this.tsb_hour.Click += new System.EventHandler(this.tsb_hour_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_sec
            // 
            this.tsb_sec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_sec.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_sec.Image = ((System.Drawing.Image)(resources.GetObject("tsb_sec.Image")));
            this.tsb_sec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_sec.Name = "tsb_sec";
            this.tsb_sec.Size = new System.Drawing.Size(25, 22);
            this.tsb_sec.Text = "%s";
            this.tsb_sec.Click += new System.EventHandler(this.tsb_sec_Click);
            // 
            // tsb_secT
            // 
            this.tsb_secT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_secT.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_secT.Image = ((System.Drawing.Image)(resources.GetObject("tsb_secT.Image")));
            this.tsb_secT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_secT.Name = "tsb_secT";
            this.tsb_secT.Size = new System.Drawing.Size(25, 22);
            this.tsb_secT.Text = "%S";
            this.tsb_secT.Click += new System.EventHandler(this.tsb_secT_Click);
            // 
            // tsb_min
            // 
            this.tsb_min.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_min.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_min.Image = ((System.Drawing.Image)(resources.GetObject("tsb_min.Image")));
            this.tsb_min.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_min.Name = "tsb_min";
            this.tsb_min.Size = new System.Drawing.Size(25, 22);
            this.tsb_min.Text = "%m";
            this.tsb_min.Click += new System.EventHandler(this.tsb_min_Click);
            // 
            // tsb_minT
            // 
            this.tsb_minT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_minT.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_minT.Image = ((System.Drawing.Image)(resources.GetObject("tsb_minT.Image")));
            this.tsb_minT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_minT.Name = "tsb_minT";
            this.tsb_minT.Size = new System.Drawing.Size(25, 22);
            this.tsb_minT.Text = "%M";
            this.tsb_minT.Click += new System.EventHandler(this.tsb_minT_Click);
            // 
            // tsb_hou
            // 
            this.tsb_hou.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_hou.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_hou.Image = ((System.Drawing.Image)(resources.GetObject("tsb_hou.Image")));
            this.tsb_hou.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_hou.Name = "tsb_hou";
            this.tsb_hou.Size = new System.Drawing.Size(25, 22);
            this.tsb_hou.Text = "%h";
            this.tsb_hou.Click += new System.EventHandler(this.tsb_hou_Click);
            // 
            // tsb_houT
            // 
            this.tsb_houT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_houT.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_houT.Image = ((System.Drawing.Image)(resources.GetObject("tsb_houT.Image")));
            this.tsb_houT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_houT.Name = "tsb_houT";
            this.tsb_houT.Size = new System.Drawing.Size(25, 22);
            this.tsb_houT.Text = "%H";
            this.tsb_houT.Click += new System.EventHandler(this.tsb_houT_Click);
            // 
            // tsb_ampm
            // 
            this.tsb_ampm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_ampm.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_ampm.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ampm.Image")));
            this.tsb_ampm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ampm.Name = "tsb_ampm";
            this.tsb_ampm.Size = new System.Drawing.Size(25, 22);
            this.tsb_ampm.Text = "%a";
            this.tsb_ampm.Click += new System.EventHandler(this.tsb_ampm_Click);
            // 
            // tb_editor
            // 
            this.tb_editor.AcceptsReturn = true;
            this.tb_editor.AcceptsTab = true;
            this.tb_editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_editor.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_editor.Location = new System.Drawing.Point(0, 25);
            this.tb_editor.MaxLength = 0;
            this.tb_editor.Multiline = true;
            this.tb_editor.Name = "tb_editor";
            this.tb_editor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_editor.Size = new System.Drawing.Size(956, 503);
            this.tb_editor.TabIndex = 1;
            this.tb_editor.WordWrap = false;
            this.tb_editor.TextChanged += new System.EventHandler(this.tb_editor_TextChanged);
            // 
            // tsb_addMulti
            // 
            this.tsb_addMulti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_addMulti.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_addMulti.Image = ((System.Drawing.Image)(resources.GetObject("tsb_addMulti.Image")));
            this.tsb_addMulti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addMulti.Name = "tsb_addMulti";
            this.tsb_addMulti.Size = new System.Drawing.Size(39, 22);
            this.tsb_addMulti.Text = "#MIF";
            this.tsb_addMulti.ToolTipText = "Adds a new Condition. May Contain placeholders.\r\nMay use Value Expressions";
            this.tsb_addMulti.Click += new System.EventHandler(this.tsb_addMulti_Click);
            // 
            // ScriptEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 528);
            this.Controls.Add(this.tb_editor);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "ScriptEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ScriptEditor";
            this.Load += new System.EventHandler(this.ScriptEditor_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TextBox tb_editor;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_addCon;
        private System.Windows.Forms.ToolStripButton tsb_addStandard;
        private System.Windows.Forms.ToolStripButton tsb_addEnd;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton tsb_help;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_second;
        private System.Windows.Forms.ToolStripButton tsb_minute;
        private System.Windows.Forms.ToolStripButton tsb_hour;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_sec;
        private System.Windows.Forms.ToolStripButton tsb_min;
        private System.Windows.Forms.ToolStripButton tsb_hou;
        private System.Windows.Forms.ToolStripButton tsb_ampm;
        private System.Windows.Forms.ToolStripButton tsb_secT;
        private System.Windows.Forms.ToolStripButton tsb_minT;
        private System.Windows.Forms.ToolStripButton tsb_houT;
        private System.Windows.Forms.ToolStripButton tsb_addMulti;
    }
}