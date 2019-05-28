using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace LAN_Checker
{
    public partial class DNS_To_IP : Form
    {
        public DNS_To_IP()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Visible = true;
                IPAddress[] addresses = Dns.GetHostAddresses(hostBox.Text);
                ipBox.Text = addresses[0].ToString();
                label3.Visible = false;
            }
            catch(System.Net.Sockets.SocketException exp)
            {
                MessageBox.Show(exp.Message.ToString(), "LAN Checker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label3.Visible = false;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
                label3.Visible = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
