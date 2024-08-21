namespace Abdal_Security_Group_App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2022DarkTheme();
            radMenu1 = new Telerik.WinControls.UI.RadMenu();
            menuItem_about_us = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_donate = new Telerik.WinControls.UI.RadMenuItem();
            irDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            EnDonationBtn = new Telerik.WinControls.UI.RadMenuItem();
            radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_github = new Telerik.WinControls.UI.RadMenuItem();
            menuItem_gitlab = new Telerik.WinControls.UI.RadMenuItem();
            desk_alert = new Telerik.WinControls.UI.RadDesktopAlert(components);
            bg_worker = new System.ComponentModel.BackgroundWorker();
            btn_start = new Telerik.WinControls.UI.RadButton();
            btn_exit = new PictureBox();
            btn_minimize = new PictureBox();
            CidrIpRange = new Telerik.WinControls.UI.RadTextBoxControl();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            DhcpClientPortLb = new Telerik.WinControls.UI.RadLabel();
            DhcpClientPort = new Telerik.WinControls.UI.RadTextBoxControl();
            DhcpServerPortLb = new Telerik.WinControls.UI.RadLabel();
            DhcpServerPort = new Telerik.WinControls.UI.RadTextBoxControl();
            DhcpLeaseTime = new Telerik.WinControls.UI.RadTimeSpanPicker();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            progressBar = new Telerik.WinControls.UI.RadProgressBar();
            radButton1 = new Telerik.WinControls.UI.RadButton();
            infinity_attackSwitch = new Telerik.WinControls.UI.RadToggleSwitch();
            bt_monitoing = new Telerik.WinControls.UI.RadButton();
            timer_infinity_attack = new System.Windows.Forms.Timer(components);
            materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            ((System.ComponentModel.ISupportInitialize)radMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CidrIpRange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DhcpClientPortLb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DhcpClientPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DhcpServerPortLb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DhcpServerPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DhcpLeaseTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).BeginInit();
            radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)progressBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infinity_attackSwitch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bt_monitoing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radMenu1
            // 
            radMenu1.Dock = DockStyle.Bottom;
            radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_about_us, menuItem_donate, radMenuItem3 });
            radMenu1.Location = new Point(0, 519);
            radMenu1.Name = "radMenu1";
            radMenu1.Size = new Size(616, 28);
            radMenu1.TabIndex = 0;
            radMenu1.ThemeName = "VisualStudio2022Dark";
            // 
            // menuItem_about_us
            // 
            menuItem_about_us.Image = Properties.Resources.user_16x16;
            menuItem_about_us.Name = "menuItem_about_us";
            menuItem_about_us.Text = "About Us";
            menuItem_about_us.Click += menuItem_about_us_Click;
            // 
            // menuItem_donate
            // 
            menuItem_donate.Image = Properties.Resources.dollar16x16;
            menuItem_donate.Items.AddRange(new Telerik.WinControls.RadItem[] { irDonationBtn, EnDonationBtn });
            menuItem_donate.Name = "menuItem_donate";
            menuItem_donate.Text = "Donate";
            // 
            // irDonationBtn
            // 
            irDonationBtn.Image = Properties.Resources.iran_16x16;
            irDonationBtn.Name = "irDonationBtn";
            irDonationBtn.Text = "Persian speaker";
            irDonationBtn.Click += irDonationBtn_Click;
            // 
            // EnDonationBtn
            // 
            EnDonationBtn.Image = Properties.Resources.United_Kingdom16x16;
            EnDonationBtn.Name = "EnDonationBtn";
            EnDonationBtn.Text = "English speaker";
            EnDonationBtn.Click += EnDonationBtn_Click;
            // 
            // radMenuItem3
            // 
            radMenuItem3.Image = Properties.Resources.git_pull_request16x16;
            radMenuItem3.Items.AddRange(new Telerik.WinControls.RadItem[] { menuItem_github, menuItem_gitlab });
            radMenuItem3.Name = "radMenuItem3";
            radMenuItem3.Text = "Source Code";
            // 
            // menuItem_github
            // 
            menuItem_github.Image = Properties.Resources.github;
            menuItem_github.Name = "menuItem_github";
            menuItem_github.Text = "Github";
            menuItem_github.Click += menuItem_github_Click;
            // 
            // menuItem_gitlab
            // 
            menuItem_gitlab.Image = Properties.Resources.gitlab_icon_rgb;
            menuItem_gitlab.Name = "menuItem_gitlab";
            menuItem_gitlab.Text = "Gitlab";
            menuItem_gitlab.Click += menuItem_gitlab_Click;
            // 
            // bg_worker
            // 
            bg_worker.DoWork += bg_worker_DoWork;
            bg_worker.ProgressChanged += bg_worker_ProgressChanged;
            bg_worker.RunWorkerCompleted += bg_worker_RunWorkerCompleted;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(16, 86);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(46, 24);
            btn_start.TabIndex = 1;
            btn_start.Text = "Start";
            btn_start.ThemeName = "VisualStudio2022Dark";
            btn_start.Click += btn_start_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.BackgroundImage = Properties.Resources.x_circle_21x21;
            btn_exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Location = new Point(7, 10);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(21, 21);
            btn_exit.TabIndex = 2;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.Transparent;
            btn_minimize.BackgroundImage = Properties.Resources.minus_circle_21x21;
            btn_minimize.BackgroundImageLayout = ImageLayout.Stretch;
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.Location = new Point(34, 10);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(21, 21);
            btn_minimize.TabIndex = 3;
            btn_minimize.TabStop = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // CidrIpRange
            // 
            CidrIpRange.Location = new Point(16, 58);
            CidrIpRange.Name = "CidrIpRange";
            CidrIpRange.NullText = "Exmp: 192.168.1.0/24";
            CidrIpRange.ShowNullText = true;
            CidrIpRange.Size = new Size(160, 22);
            CidrIpRange.TabIndex = 4;
            CidrIpRange.ThemeName = "VisualStudio2022Dark";
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(16, 34);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(128, 21);
            radLabel1.TabIndex = 5;
            radLabel1.Text = "Your Network CIDR ";
            radLabel1.ThemeName = "VisualStudio2022Dark";
            // 
            // DhcpClientPortLb
            // 
            DhcpClientPortLb.Location = new Point(184, 34);
            DhcpClientPortLb.Name = "DhcpClientPortLb";
            DhcpClientPortLb.Size = new Size(110, 21);
            DhcpClientPortLb.TabIndex = 7;
            DhcpClientPortLb.Text = "Dhcp Client Port ";
            DhcpClientPortLb.ThemeName = "VisualStudio2022Dark";
            // 
            // DhcpClientPort
            // 
            DhcpClientPort.Location = new Point(182, 58);
            DhcpClientPort.Name = "DhcpClientPort";
            DhcpClientPort.Size = new Size(110, 22);
            DhcpClientPort.TabIndex = 6;
            DhcpClientPort.Text = "68";
            DhcpClientPort.ThemeName = "VisualStudio2022Dark";
            DhcpClientPort.KeyPress += radTextBoxControl1_KeyPress;
            // 
            // DhcpServerPortLb
            // 
            DhcpServerPortLb.Location = new Point(300, 34);
            DhcpServerPortLb.Name = "DhcpServerPortLb";
            DhcpServerPortLb.Size = new Size(113, 21);
            DhcpServerPortLb.TabIndex = 7;
            DhcpServerPortLb.Text = "Dhcp Server Port ";
            DhcpServerPortLb.ThemeName = "VisualStudio2022Dark";
            // 
            // DhcpServerPort
            // 
            DhcpServerPort.Location = new Point(298, 58);
            DhcpServerPort.Name = "DhcpServerPort";
            DhcpServerPort.Size = new Size(113, 22);
            DhcpServerPort.TabIndex = 6;
            DhcpServerPort.Text = "67";
            DhcpServerPort.ThemeName = "VisualStudio2022Dark";
            DhcpServerPort.KeyPress += radTextBoxControl2_KeyPress;
            // 
            // DhcpLeaseTime
            // 
            DhcpLeaseTime.Format = "dd:hh:mm:ss";
            DhcpLeaseTime.Location = new Point(417, 58);
            DhcpLeaseTime.Name = "DhcpLeaseTime";
            DhcpLeaseTime.Size = new Size(100, 22);
            DhcpLeaseTime.TabIndex = 9;
            DhcpLeaseTime.TabStop = false;
            DhcpLeaseTime.ThemeName = "VisualStudio2022Dark";
            DhcpLeaseTime.Value = TimeSpan.Parse("00:00:50");
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(417, 34);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(82, 21);
            radLabel2.TabIndex = 8;
            radLabel2.Text = "IP leaseTime";
            radLabel2.ThemeName = "VisualStudio2022Dark";
            // 
            // radGroupBox1
            // 
            radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
            radGroupBox1.Controls.Add(progressBar);
            radGroupBox1.Controls.Add(radButton1);
            radGroupBox1.Controls.Add(infinity_attackSwitch);
            radGroupBox1.Controls.Add(bt_monitoing);
            radGroupBox1.Controls.Add(radLabel1);
            radGroupBox1.Controls.Add(radLabel2);
            radGroupBox1.Controls.Add(btn_start);
            radGroupBox1.Controls.Add(CidrIpRange);
            radGroupBox1.Controls.Add(DhcpLeaseTime);
            radGroupBox1.Controls.Add(DhcpClientPort);
            radGroupBox1.Controls.Add(DhcpClientPortLb);
            radGroupBox1.Controls.Add(DhcpServerPortLb);
            radGroupBox1.Controls.Add(DhcpServerPort);
            radGroupBox1.HeaderMargin = new Padding(1);
            radGroupBox1.HeaderText = "Attack Configuration";
            radGroupBox1.Location = new Point(13, 373);
            radGroupBox1.Name = "radGroupBox1";
            radGroupBox1.Size = new Size(590, 140);
            radGroupBox1.TabIndex = 10;
            radGroupBox1.Text = "Attack Configuration";
            radGroupBox1.ThemeName = "VisualStudio2022Dark";
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Bottom;
            progressBar.Location = new Point(2, 128);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(586, 10);
            progressBar.TabIndex = 14;
            progressBar.ThemeName = "MaterialTeal";
            // 
            // radButton1
            // 
            radButton1.Location = new Point(72, 86);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(46, 24);
            radButton1.TabIndex = 2;
            radButton1.Text = "Stop";
            radButton1.ThemeName = "VisualStudio2022Dark";
            radButton1.Click += radButton1_Click;
            // 
            // infinity_attackSwitch
            // 
            infinity_attackSwitch.Location = new Point(258, 86);
            infinity_attackSwitch.Name = "infinity_attackSwitch";
            infinity_attackSwitch.OffText = "Infinity Attack OFF";
            infinity_attackSwitch.OnText = "Infinity Attack ON";
            infinity_attackSwitch.Size = new Size(124, 24);
            infinity_attackSwitch.TabIndex = 13;
            infinity_attackSwitch.ValueChanged += infinity_attackSwitch_ValueChanged;
            // 
            // bt_monitoing
            // 
            bt_monitoing.Location = new Point(128, 86);
            bt_monitoing.Name = "bt_monitoing";
            bt_monitoing.Size = new Size(120, 24);
            bt_monitoing.TabIndex = 12;
            bt_monitoing.Text = "Attack Monitoring";
            bt_monitoing.ThemeName = "VisualStudio2022Dark";
            bt_monitoing.Click += bt_monitoing_Click;
            // 
            // timer_infinity_attack
            // 
            timer_infinity_attack.Enabled = true;
            timer_infinity_attack.Interval = 5000;
            timer_infinity_attack.Tick += timer_infinity_attack_Tick;
            // 
            // Main
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(616, 547);
            Controls.Add(radGroupBox1);
            Controls.Add(btn_minimize);
            Controls.Add(btn_exit);
            Controls.Add(radMenu1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ThemeName = "VisualStudio2022Dark";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)radMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)CidrIpRange).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DhcpClientPortLb).EndInit();
            ((System.ComponentModel.ISupportInitialize)DhcpClientPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)DhcpServerPortLb).EndInit();
            ((System.ComponentModel.ISupportInitialize)DhcpServerPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)DhcpLeaseTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radGroupBox1).EndInit();
            radGroupBox1.ResumeLayout(false);
            radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)progressBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)infinity_attackSwitch).EndInit();
            ((System.ComponentModel.ISupportInitialize)bt_monitoing).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2022DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menuItem_about_us;
        private Telerik.WinControls.UI.RadMenuItem menuItem_donate;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem menuItem_github;
        private Telerik.WinControls.UI.RadMenuItem menuItem_gitlab;
        private Telerik.WinControls.UI.RadDesktopAlert desk_alert;
        private System.ComponentModel.BackgroundWorker bg_worker;
        private Telerik.WinControls.UI.RadButton btn_start;
        private PictureBox btn_exit;
        private PictureBox btn_minimize;
        private Telerik.WinControls.UI.RadMenuItem irDonationBtn;
        private Telerik.WinControls.UI.RadMenuItem EnDonationBtn;
        private Telerik.WinControls.UI.RadTextBoxControl CidrIpRange;
        private Telerik.WinControls.UI.RadTextBoxControl DhcpClientPort;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel DhcpClientPortLb;
        private Telerik.WinControls.UI.RadLabel DhcpServerPortLb;
        private Telerik.WinControls.UI.RadTextBoxControl DhcpServerPort;
        private Telerik.WinControls.UI.RadTimeSpanPicker DhcpLeaseTime;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton bt_monitoing;
        private Telerik.WinControls.UI.RadToggleSwitch infinity_attackSwitch;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Timer timer_infinity_attack;
        private Telerik.WinControls.UI.RadProgressBar progressBar;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
    }
}
