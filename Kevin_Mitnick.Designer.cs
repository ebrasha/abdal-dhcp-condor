namespace Abdal_Security_Group_App
{
    partial class Kevin_Mitnick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kevin_Mitnick));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            visualStudio2022DarkTheme2 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            richTextBox_about_us = new RichTextBox();
            radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            ((System.ComponentModel.ISupportInitialize)radPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // richTextBox_about_us
            // 
            richTextBox_about_us.BackColor = Color.FromArgb(60, 60, 70);
            richTextBox_about_us.BorderStyle = BorderStyle.None;
            richTextBox_about_us.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_about_us.ForeColor = SystemColors.InactiveCaption;
            richTextBox_about_us.Location = new Point(145, 6);
            richTextBox_about_us.Name = "richTextBox_about_us";
            richTextBox_about_us.ReadOnly = true;
            richTextBox_about_us.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox_about_us.Size = new Size(311, 263);
            richTextBox_about_us.TabIndex = 9;
            richTextBox_about_us.Text = resources.GetString("richTextBox_about_us.Text");
            richTextBox_about_us.TextChanged += richTextBox_about_us_TextChanged;
            // 
            // radPictureBox1
            // 
            radPictureBox1.Image = Properties.Resources.Kevin;
            radPictureBox1.Location = new Point(4, 6);
            radPictureBox1.Name = "radPictureBox1";
            radPictureBox1.Size = new Size(123, 259);
            radPictureBox1.TabIndex = 8;
            radPictureBox1.ThemeName = "VisualStudio2022Dark";
            // 
            // Kevin_Mitnick
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 274);
            Controls.Add(richTextBox_about_us);
            Controls.Add(radPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Kevin_Mitnick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Why was the word \"Condor\" used?";
            ThemeName = "VisualStudio2022Dark";
            ((System.ComponentModel.ISupportInitialize)radPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme2;
        private RichTextBox richTextBox_about_us;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
    }
}
