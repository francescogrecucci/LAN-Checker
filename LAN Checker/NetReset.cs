using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LAN_Checker
{
    public partial class NetReset : Form
    {
        public NetReset()
        {
            InitializeComponent();
        }

        private void NetReset_Load(object sender, EventArgs e)
        {
        }

        private void reset()
        {
            procedureLabel.Text = "Starting Reset...";
            progressBar1.Value = 0;

            winsock_reset();
            procedureLabel.Text = "Executing \"netsh winsock reset\" command...";
            progressBar1.Value = 20;

            ip_reset();
            procedureLabel.Text = "Executing \"netsh int ip reset\" command...";
            progressBar1.Value = 40;

            ipconfig_release();
            ipconfig_renew();
            procedureLabel.Text = "Refreshing IP address...";
            progressBar1.Value = 60;

            ipconfig_flushdns();
            procedureLabel.Text = "Flushing DNS...";
            progressBar1.Value = 80;

            procedureLabel.Text = "Procedure Complete!";
            progressBar1.Value = 100;
            MessageBox.Show("Reset Complete. Please Restart your Computer.", "LAN Checker - Reset",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void winsock_reset()
        {
            string strCmdText = "/C netsh winsock reset";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void ip_reset()
        {
            string strCmdText = "/C netsh int ip reset";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void ipconfig_release()
        {
            string strCmdText = "/C ipconfig /release";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void ipconfig_renew()
        {
            string strCmdText = "/C ipconfig /renew";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void ipconfig_flushdns()
        {
            string strCmdText = "/C ipconfig /flushdns";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void NetReset_Shown(object sender, EventArgs e)
        {
            reset();
            this.Close();
        }
    }
}
