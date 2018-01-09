namespace Stream_Countdown
{
    partial class ScriptHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptHelp));
            this.tb_helpText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_helpText
            // 
            this.tb_helpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_helpText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_helpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_helpText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_helpText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_helpText.Location = new System.Drawing.Point(0, 0);
            this.tb_helpText.MaxLength = 0;
            this.tb_helpText.Multiline = true;
            this.tb_helpText.Name = "tb_helpText";
            this.tb_helpText.ReadOnly = true;
            this.tb_helpText.Size = new System.Drawing.Size(674, 550);
            this.tb_helpText.TabIndex = 0;
            this.tb_helpText.TabStop = false;
            this.tb_helpText.Text = resources.GetString("tb_helpText.Text");
            this.tb_helpText.WordWrap = false;
            // 
            // ScriptHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 550);
            this.Controls.Add(this.tb_helpText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScriptHelp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Script Editor Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_helpText;
    }
}