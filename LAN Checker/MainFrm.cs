using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Management;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.Sockets;
using System.Xml;

namespace LAN_Checker
{
    public partial class MainFrm : Form
    {
        /* Settings object xml */
        XmlDocument settingsxml = new XmlDocument();

        NetworkInterface[] Interfaces = NetworkInterface.GetAllNetworkInterfaces();

        public MainFrm()
        {
            InitializeComponent();
        }

        bool t;          // Timer START/STOP flag

        /* Chart Series*/
        Series s = new Series();
        Series s_download = new Series();
        Series s_upload = new Series();
   

        private void MainFrm_Load(object sender, EventArgs e)
        {
            /* Splash Screen Thread Opens */
            Thread splash = new Thread(new ThreadStart(SplashShow));
            splash.Start();
            Thread.Sleep(1000);

            Chart_init();
            OSChecker();

            /* Analysis Timer Start*/
            t = false;
            timer1.Start();

            /* Close Splash */
            splash.Abort();
            /* Set this window */
            this.Activate();
        }

        static void SplashShow()
        {
            Application.Run(new Splash());
        }

        private void OSChecker()
        {
            /* Check the Operating System version */

            var os = Environment.OSVersion;
            /* Windows XP Not Supported Alert */
            if(os.VersionString.Contains("Microsoft Windows NT 5.1"))
            {
                MessageBox.Show("Windows XP is not supported by this application, please upgrade your computer.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }

        private void Chart_init()
        {
            s = chart1.Series.Add("MB Transmitted");
            s.ChartType = SeriesChartType.Area;
            s.Color = Color.Violet;
            s.AxisLabel = " ";
            //s.IsVisibleInLegend = false; ---> Turn off the serie label 

            s_download = chart1.Series.Add("MB Downloaded");
            s_download.ChartType = SeriesChartType.Area;
            s_download.Color = Color.Green;
            //s_download.IsVisibleInLegend = false;

            s_upload = chart1.Series.Add("MB Uploaded");
            s_upload.ChartType = SeriesChartType.Area;
            s_upload.Color = Color.Red;
            //s_upload.IsVisibleInLegend = false;
        }

        private void Analysis()
        {
            GetDNS();
            GetLocalIP_DNS();
            GetHostInfo();
            GetPackets();
            progressBar();
            dataTransfer_Stats();
            Samba();
        }

        private void PortCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SocketConnection.SocketConnectionForm socketform = new SocketConnection.SocketConnectionForm();
            socketform.Show();
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to reset all the network settings? " +
                "This will erase all of your Windows Network parameters. PLEASE RUN THIS PROCEDURE LAUNCHING " +
                "LAN CHECKER WITH ADMINISTRATIVE RIGHTS!",
                "LAN Checker - Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                NetReset netreset = new NetReset();
                netreset.Show();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string networkCard;
        private void GetLocalIP_DNS()
        {
            try

            {
                foreach (NetworkInterface Interface in Interfaces)
                {
                    /* NICs BLACKLIST */
                    if (Interface.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
                    if (Interface.Name.Contains("isatap") == true) continue;
                    if (Interface.Name.Contains("VMware") == true) continue;
                    if (Interface.Name.Contains("Virtual") == true) continue;
                    if (Interface.Description.Contains("VMware") == true) continue;
                    /* End BlackList*/

                    UnicastIPAddressInformationCollection UnicastIPInfoCol = Interface.GetIPProperties().UnicastAddresses;
                    foreach (UnicastIPAddressInformation UnicatIPInfo in UnicastIPInfoCol)
                    {
                        localAddr.Text = UnicatIPInfo.Address.ToString();
                        subnetMask.Text = UnicatIPInfo.IPv4Mask.ToString();
                        NICname.Text = Interface.Description.ToString();
                        networkCard = Interface.Name.ToString();

                        long dec_speed = Interface.Speed / 1000000;
                        NICSpeed.Text = dec_speed.ToString() + " Mbps";

                        switch (Interface.OperationalStatus.ToString())
                        {
                            case "Up":
                                currentStatus.Text = "CONNECTED";
                                currentStatus.BackColor = Color.FromArgb(46, 204, 113);
                                break;
                            case "Down":
                                currentStatus.Text = "DISCONNECTED!";
                                currentStatus.BackColor = Color.FromArgb(231, 76, 60);
                                break;
                            default:
                                currentStatus.Text = Interface.OperationalStatus.ToString();
                                currentStatus.BackColor = Color.Yellow;
                                break;
                        }

                        var ipInterface = Interface.GetIPProperties();
                        var gatewayAddresses = ipInterface.GatewayAddresses;

                        if ((gatewayAddresses == null) || (gatewayAddresses.Count == 0))
                        {
                            gatewayIP.Text = "No Address";
                        }
                        else
                        {
                            foreach(var gatf in gatewayAddresses)
                            {
                                gatewayIP.Text = gatf.Address.ToString();
                            }
                        }

                        IPAddressCollection dnsServers = ipInterface.DnsAddresses;
                        foreach (IPAddress dns in dnsServers)
                        {
                            DNSAddress1.Text = dns.ToString();
                            break;
                        }

                        foreach (IPAddress dns in dnsServers)
                        {
                            DNSAddress2.Text = dns.ToString();
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString(), exp.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetHostInfo()
        {
                hostName.Text = Dns.GetHostName();
                ManagementObjectSearcher computer_system = new ManagementObjectSearcher("select * from " + "Win32_ComputerSystem");
                foreach (ManagementObject data in computer_system.Get())
                {
                    foreach (PropertyData PC in data.Properties)
                    {
                        try
                        {
                            workgroup.Text = data["Workgroup"].ToString();
                        }
                        catch(System.NullReferenceException)
                        {
                            label24.Text = "Domain: ";
                            workgroup.Text = data["Domain"].ToString();
                        }
                    }

                }
            }

        private void GetDNS()
        {

        }

        private void GetPackets()
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Analysis();
            statusLabel.Text = "Network Scanning...";
        }

        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");

        private void progressBar()
        {
            cpuBar.Value = Convert.ToInt32(cpuCounter.NextValue());
            ramBar.Value = Convert.ToInt32(ramCounter.NextValue()) / 100;

        }

        /* Graphic Counter */
        int i = 0;

        /* Statistics + Graphics + Network Usage Bar Graphic */
        private void dataTransfer_Stats()
        {
            String[] instancename = category.GetInstanceNames();

                foreach (string name in instancename)
                {

                    /* Chart and MB Transferred Black List */
                    if (name.Contains("isatap") == true) continue;
                    if (name.Contains("VMware") == true) continue;
                    if (name.Contains("Virtual") == true) continue;
                /* End of Black List */

                try
                {
                    PerformanceCounter TCPv4segmentsSec = new PerformanceCounter("TCPv4", "Segments/sec");
                    PerformanceCounter TCPv4segmentsReceived = new PerformanceCounter("TCPv4", "Segments Received/sec");
                    PerformanceCounter TCPv4segmentsTransmitted = new PerformanceCounter("TCPv4", "Segments Sent/sec");

                    PerformanceCounter UDPv4segmentsSec = new PerformanceCounter("UDPv4", "Datagrams/sec");
                    PerformanceCounter UDPv4segmentsReceived = new PerformanceCounter("UDPv4", "Datagrams Received/sec");
                    PerformanceCounter UDPv4segmentsTransmitted = new PerformanceCounter("UDPv4", "Datagrams Sent/sec");

                    PerformanceCounter TCPv6segmentsSec = new PerformanceCounter("TCPv6", "Segments/sec");
                    PerformanceCounter TCPv6segmentsReceived = new PerformanceCounter("TCPv6", "Segments Received/sec");
                    PerformanceCounter TCPv6segmentsTransmitted = new PerformanceCounter("TCPv6", "Segments Sent/sec");

                    PerformanceCounter UDPv6segmentsSec = new PerformanceCounter("UDPv6", "Datagrams/sec");
                    PerformanceCounter UDPv6segmentsReceived = new PerformanceCounter("UDPv6", "Datagrams Received/sec");
                    PerformanceCounter UDPv6segmentsTransmitted = new PerformanceCounter("UDPv6", "Datagrams Sent/sec");

                    PerformanceCounter currentBandwidth = new PerformanceCounter("Network Interface", "Current Bandwidth", name);

                    PerformanceCounter totalCounter = new PerformanceCounter("Network Interface", "Bytes Total/sec", name);
                    PerformanceCounter dataSentCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", name);
                    PerformanceCounter dataReceivedCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", name);

                    /* Conversion from B to MB */
                    decimal datasent = dataSentCounter.RawValue / 1000000;
                    decimal datarec = dataReceivedCounter.RawValue / 1000000;
                    decimal totmb = totalCounter.RawValue / 1000000;


                    recmb.Text = datarec.ToString();
                    sentmb.Text = datasent.ToString();
                    totalmb.Text = totmb.ToString();

                    TCPv4segsec.Text = TCPv4segmentsSec.RawValue.ToString();
                    TCPv4recpack.Text = TCPv4segmentsReceived.RawValue.ToString();
                    TCPv4sentpack.Text = TCPv4segmentsTransmitted.RawValue.ToString();

                    TCPv6segsec.Text = TCPv6segmentsSec.RawValue.ToString();
                    TCPv6recpack.Text = TCPv6segmentsReceived.RawValue.ToString();
                    TCPv6sentpack.Text = TCPv6segmentsTransmitted.RawValue.ToString();

                    UDPv4segsec.Text = UDPv4segmentsSec.RawValue.ToString();
                    UDPv4recpack.Text = UDPv4segmentsReceived.RawValue.ToString();
                    UDPv4sentpack.Text = UDPv4segmentsTransmitted.RawValue.ToString();

                    UDPv6segsec.Text = UDPv6segmentsSec.RawValue.ToString();
                    UDPv6recpack.Text = UDPv6segmentsReceived.RawValue.ToString();
                    UDPv6sentpack.Text = UDPv6segmentsTransmitted.RawValue.ToString();


                    /* Network Bar */
                    try
                    {
                        netBar.Value = Convert.ToInt32(currentBandwidth.NextValue()) / 1000000;
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        netBar.Value = Convert.ToInt32(currentBandwidth.NextValue()) / 10000000;
                    }

                    /* Graphic */
                    i++;
                    int f = Convert.ToInt32(totmb);
                    s.Points.AddXY(i, f);
                    s_download.Points.AddXY(i, Convert.ToInt32(datarec));
                    s_upload.Points.AddXY(i, Convert.ToInt32(datasent));
                }
                catch (Exception)
                {
                    MessageBox.Show("OS not supported by this application, please upgrade your system.", "LAN Checker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Samba()
        {
            try
            {
                /* Check italian bug!!!*/

                PerformanceCounter SMBSent = new PerformanceCounter("Server SMB", "Byte inviati/sec");
                PerformanceCounter SMBReceived = new PerformanceCounter("Server SMB", "Byte ricevuti/sec");

                SMB_sent.Text = (SMBSent.RawValue / 1000).ToString();
                SMB_rec.Text = (SMBReceived.RawValue / 1000).ToString();
                SMB_total.Text = ((SMBReceived.RawValue + SMBSent.RawValue) / 1000).ToString();

                SMB_sentM.Text = (SMBSent.RawValue / 1000000).ToString();
                SMB_recM.Text = (SMBReceived.RawValue / 1000000).ToString();
                SMB_totalM.Text = ((SMBReceived.RawValue + SMBSent.RawValue) / 1000000).ToString();
            }
            catch(Exception)
            {
                SMB_sent.Text = "0";
                SMB_rec.Text = "0";
                SMB_total.Text = "0";

                SMB_sentM.Text = "0";
                SMB_recM.Text = "0";
                SMB_totalM.Text = "0";
            }
        }
        

        private void DNSToIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DNS_To_IP hostconverter = new DNS_To_IP();
            hostconverter.Show();

        }

        private void PingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO 
            Ping ping = new Ping();
            ping.Show();
        }

        private void AboutLANCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void MainFrm_Deactivate(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (t == false)
            {
                timer1.Stop();
                button1.Text = "Start Analysis";
                button1.Image = Properties.Resources.start;
                statusLabel.Text = "Stopped.";
                t = true;
                Notify_Stop();

            }
            else
            {
                timer1.Start();
                button1.Text = "Stop Analysis";
                button1.Image = Properties.Resources.Stop;
                t = false;
                Notify_Start();
            }
        }

        private void Notify_Stop()
        {
            notifyIcon1.Text = "Analysis Stopped";
            notifyIcon1.BalloonTipText = "LAN Checker is not analyzing your network card";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.ShowBalloonTip(100);
        }

        private void Notify_Start()
        {
            notifyIcon1.Text = "Analysis OK";
            notifyIcon1.BalloonTipText = "LAN Checker is analyzing your network card";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(100);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SocketConnection.SocketConnectionForm socketform = new SocketConnection.SocketConnectionForm();
            socketform.Show();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }


        bool click = false;

        private void Button2_Click(object sender, EventArgs e)
        {

            if (click == false)
            {
                button2.Text = "Disable Full Screen";
                click = true;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                click = false;
                button2.Text = "Full Screen";
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
            }
        }

    }
}



