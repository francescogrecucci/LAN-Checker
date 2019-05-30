using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace LAN_Checker
{
    public partial class Ping : Form
    {
        public Ping()
        {
            InitializeComponent();
        }

        private void Ping_Load(object sender, EventArgs e)
        {
            
    }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
            PingOptions options = new PingOptions();

            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            try
            {
                PingReply reply = ping.Send(hostname.Text, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    statusBox.Text = reply.Status.ToString();
                    statusBox.BackColor = Color.LightGreen;

                    textBox1.Text = reply.Address.ToString();
                    textBox2.Text = reply.RoundtripTime.ToString();
                    textBox3.Text = reply.Options.Ttl.ToString();
                    textBox4.Text = reply.Buffer.Length.ToString();
                }
                else
                {
                    statusBox.Text = reply.Status.ToString();
                    statusBox.BackColor = Color.Red;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            catch (Exception)
            {
                statusBox.Text = "ERROR";
                statusBox.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
    }
