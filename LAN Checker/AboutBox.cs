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
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            productName.Text = Application.ProductName;
            version.Text = "Version: " + Application.ProductVersion;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(licenseText.Visible == false)
            {
                licenseText.Visible = true;
                button2.Text = "Hide";
            }
            else
            {
                licenseText.Visible = false;
                button2.Text = "License";
            }
            
        }
    }
}
