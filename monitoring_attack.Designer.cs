namespace Abdal_Security_Group_App
{
    partial class monitoring_attack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monitoring_attack));
            visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            AttackLogBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // AttackLogBox
            // 
            AttackLogBox.BackColor = Color.FromArgb(45, 45, 45);
            AttackLogBox.BorderStyle = BorderStyle.None;
            AttackLogBox.Dock = DockStyle.Fill;
            AttackLogBox.ForeColor = Color.Aqua;
            AttackLogBox.Location = new Point(0, 0);
            AttackLogBox.Name = "AttackLogBox";
            AttackLogBox.Size = new Size(704, 354);
            AttackLogBox.TabIndex = 9;
            AttackLogBox.Text = "";
            // 
            // monitoring_attack
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 354);
            Controls.Add(AttackLogBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "monitoring_attack";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attack Monitoring";
            ThemeName = "VisualStudio2012Dark";
            FormClosing += monitoring_attack_FormClosing;
            Load += monitoring_attack_Load;
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private RichTextBox AttackLogBox;
    }
}
