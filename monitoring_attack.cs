using Abdal_Security_Group_App.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Abdal_Security_Group_App
{
    public partial class monitoring_attack : Telerik.WinControls.UI.RadForm
    {
        public monitoring_attack()
        {
            InitializeComponent();
        }

        public void AttackMonitoringLogWriter(string attack_log)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    AttackLogBox.AppendText(attack_log + Environment.NewLine);
                    AttackLogBox.SelectionStart = AttackLogBox.Text.Length;
                    AttackLogBox.ScrollToCaret();
                }));
            }
            else
            {
                AttackLogBox.AppendText(attack_log + Environment.NewLine);
                AttackLogBox.SelectionStart = AttackLogBox.Text.Length;
                AttackLogBox.ScrollToCaret();
            }
        }

        private void monitoring_attack_Load(object sender, EventArgs e)
        {

        }

        private void monitoring_attack_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
