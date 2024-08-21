using Abdal_Security_Group_App.Core;
using System.Diagnostics;
using System.Net;
using System.Reflection;

namespace Abdal_Security_Group_App
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        private bool stop_op_status = false;
        private string abdal_app_name = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0];
        private AbdalSoundPlayer ab_player = new AbdalSoundPlayer();
        private monitoring_attack mon_form = new monitoring_attack();
        private bool infinity_attack_stop = false;

        private string abdal_app_name_for_url = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0]
            .ToLower().Replace(' ', '-');


        public Main()
        {
            InitializeComponent();
            //change form title
            Version version = Assembly.GetExecutingAssembly().GetName().Version!;
            Text = abdal_app_name + " " + version.Major + "." + version.Minor;

            // Call Global Chilkat Unlock
            ChilkatMng.UnlockChilkat();
        }

        #region Dragable Form Start

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        #endregion

        private async void Main_Load(object sender, EventArgs e)
        {
            timer_infinity_attack.Enabled = false;
            await UpdateChecker.CheckForUpdateAsync();
        }

        private bool ValidateTextBoxes()
        {
            bool is_error = false;
            if (string.IsNullOrWhiteSpace(CidrIpRange.Text))
            {
                MessageBox.Show("Please enter a value for Cidr Ip Range.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                is_error = true;
            }

            if (string.IsNullOrWhiteSpace(DhcpClientPort.Text))
            {
                MessageBox.Show("Please enter a value for Dhcp Client Port.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                is_error = true;
            }

            if (string.IsNullOrWhiteSpace(DhcpServerPort.Text))
            {
                MessageBox.Show("Please enter a value for Dhcp Server Port.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                is_error = true;
            }

            return is_error;
        }

        private void menuItem_github_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://github.com/ebrasha/" + abdal_app_name_for_url)
                { UseShellExecute = true });
        }

        private void menuItem_gitlab_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://gitlab.com/Prof.Shafiei/" + abdal_app_name_for_url)
                { UseShellExecute = true });
        }

        private void menuItem_donate_Click(object sender, EventArgs e)
        {
        }

        private void menuItem_about_us_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            about_us about_form = new Abdal_Security_Group_App.about_us();
            about_form.ShowDialog();
            about_form.TopMost = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void bg_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Canceled Process By User!";
                this.desk_alert.Show();
                ab_player.sPlayer("cancel");
            }
            else if (e.Error != null)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = e.Error.Message;
                this.desk_alert.Show();


                ab_player.sPlayer("error");
            }
            else
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Done!";
                this.desk_alert.Show();

                if (stop_op_status)
                {
                    ab_player.sPlayerSync("cancel");
                }
                else
                {
                    ab_player.sPlayerSync("op-com");
                }

                ab_player.sPlayer("done");
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBoxes())
            {
                infinity_attack_stop = false;
                if (infinity_attackSwitch.Value)
                {
                    timer_infinity_attack.Enabled = true;
                }
                else
                {
                    timer_infinity_attack.Enabled = false;
                }

                if (bg_worker.IsBusy != true)
                {
                    ab_player.sPlayerSync("start");
                    bg_worker.RunWorkerAsync();
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void irDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://alphajet.ir/abdal-donation") { UseShellExecute = true });
        }

        private void EnDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://ebrasha.com/abdal-donation") { UseShellExecute = true });
        }

        public uint GetIntervalFromForm()
        {
            TimeSpan selectedTimeSpan = (TimeSpan)DhcpLeaseTime.Value;
            uint totalSeconds = (uint)selectedTimeSpan.TotalSeconds;
            return totalSeconds;
        }

        private void bg_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                string cidr = CidrIpRange.Text;

                (IPAddress startIP, int subnetMaskLength) = NetTools.ParseCIDR(cidr);
                List<IPAddress> ipRange = NetTools.GetIpRange(startIP, subnetMaskLength);
                progressBar.BeginInvoke(new Action(() => { progressBar.Maximum = ipRange.Count; }));

                progressBar.Value2 = 0;
                int ProgressBarCounter = 0;

                foreach (var ipAddress in ipRange)
                {
                    try
                    {
                        progressBar.Invoke((MethodInvoker)delegate
                        {
                            ProgressBarCounter++;
                            progressBar.Value2 = ProgressBarCounter;
                        });

                        // Send to Monitoring
                        AttackMonitoringLogTransfer($"Reserving IP: {ipAddress}");

                        string SendDhcpDiscoverResult = DhcpHub.SendDhcpDiscover(
                            ipAddress,
                            Convert.ToInt32(DhcpClientPort.Text),
                            Convert.ToInt32(DhcpServerPort.Text),
                            GetIntervalFromForm());

                        // Send result to Monitoring
                        AttackMonitoringLogTransfer(SendDhcpDiscoverResult);

                        if (infinity_attack_stop)
                        {
                            infinity_attack_stop = false;
                            ab_player.sPlayerSync("cancel");
                            AttackMonitoringLogTransfer("Cancel Attack By User!");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        // If an error occurs with a specific IP, continue with the next one
                        AttackMonitoringLogTransfer($"Error with IP {ipAddress}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                // General error handling
                AttackMonitoringLogTransfer($"Error in bg_worker_DoWork: {ex.Message}");
            }
        }


        private void AttackMonitoringLogTransfer(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AttackMonitoringLogTransfer), new object[] { message });
                return;
            }

            //Send to Mon
            mon_form.AttackMonitoringLogWriter(message);
        }

        private void radTextBoxControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radTextBoxControl2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bg_worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
        }

        private void bt_monitoing_Click(object sender, EventArgs e)
        {
            mon_form.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            infinity_attack_stop = true;
            timer_infinity_attack.Enabled = false;
        }


        private void infinity_attackSwitch_ValueChanged(object sender, EventArgs e)
        {
            if (infinity_attackSwitch.Value)
            {
                timer_infinity_attack.Enabled = true;
            }
            else
            {
                timer_infinity_attack.Enabled = false;
            }
        }

        private void timer_infinity_attack_Tick(object sender, EventArgs e)
        {
            if (bg_worker.IsBusy != true)
            {
                bg_worker.RunWorkerAsync();
            }
        }
    }
}