namespace LAN_Checker
{
    partial class MainFrm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dNSToIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLANCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sentmb = new System.Windows.Forms.TextBox();
            this.recmb = new System.Windows.Forms.TextBox();
            this.totalmb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.netBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.ramBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cpuBar = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.UDPv6sentpack = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.UDPv6recpack = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.UDPv6segsec = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TCPv6sentpack = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.TCPv6recpack = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.TCPv6segsec = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UDPv4sentpack = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.UDPv4recpack = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.UDPv4segsec = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TCPv4sentpack = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TCPv4recpack = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TCPv4segsec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.debugLabel = new System.Windows.Forms.Label();
            this.workgroup = new System.Windows.Forms.Label();
            this.hostName = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.DNSAddress2 = new System.Windows.Forms.Label();
            this.DNSAddress1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gatewayIP = new System.Windows.Forms.Label();
            this.subnetMask = new System.Windows.Forms.Label();
            this.localAddr = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NICSpeed = new System.Windows.Forms.Label();
            this.NICname = new System.Windows.Forms.Label();
            this.currentStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SMB_totalM = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.SMB_recM = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.SMB_sentM = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.SMB_total = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.SMB_rec = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.SMB_sent = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label43 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.checksToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // checksToolStripMenuItem
            // 
            this.checksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portCheckerToolStripMenuItem,
            this.toolStripSeparator1,
            this.dNSToIPToolStripMenuItem,
            this.pingToolStripMenuItem});
            this.checksToolStripMenuItem.Name = "checksToolStripMenuItem";
            this.checksToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.checksToolStripMenuItem.Text = "Tools";
            // 
            // portCheckerToolStripMenuItem
            // 
            this.portCheckerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("portCheckerToolStripMenuItem.Image")));
            this.portCheckerToolStripMenuItem.Name = "portCheckerToolStripMenuItem";
            this.portCheckerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.portCheckerToolStripMenuItem.Text = "Ports Sniffer";
            this.portCheckerToolStripMenuItem.Click += new System.EventHandler(this.PortCheckerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // dNSToIPToolStripMenuItem
            // 
            this.dNSToIPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dNSToIPToolStripMenuItem.Image")));
            this.dNSToIPToolStripMenuItem.Name = "dNSToIPToolStripMenuItem";
            this.dNSToIPToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dNSToIPToolStripMenuItem.Text = "Hostname to IP";
            this.dNSToIPToolStripMenuItem.Click += new System.EventHandler(this.DNSToIPToolStripMenuItem_Click);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pingToolStripMenuItem.Image")));
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pingToolStripMenuItem.Text = "Ping";
            this.pingToolStripMenuItem.Click += new System.EventHandler(this.PingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutLANCheckerToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutLANCheckerToolStripMenuItem
            // 
            this.aboutLANCheckerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutLANCheckerToolStripMenuItem.Image")));
            this.aboutLANCheckerToolStripMenuItem.Name = "aboutLANCheckerToolStripMenuItem";
            this.aboutLANCheckerToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aboutLANCheckerToolStripMenuItem.Text = "About LAN Checker";
            this.aboutLANCheckerToolStripMenuItem.Click += new System.EventHandler(this.AboutLANCheckerToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 775);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(978, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.sentmb);
            this.groupBox1.Controls.Add(this.recmb);
            this.groupBox1.Controls.Add(this.totalmb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(11, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 151);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Transfer Statistics";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.Color.DimGray;
            this.label40.Location = new System.Drawing.Point(9, 124);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(225, 15);
            this.label40.TabIndex = 12;
            this.label40.Text = "Since the network card has been enabled.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "MBs Sent (Upload)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "MBs Received (Download)";
            // 
            // sentmb
            // 
            this.sentmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.sentmb.Location = new System.Drawing.Point(165, 89);
            this.sentmb.Name = "sentmb";
            this.sentmb.ReadOnly = true;
            this.sentmb.Size = new System.Drawing.Size(173, 23);
            this.sentmb.TabIndex = 9;
            // 
            // recmb
            // 
            this.recmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.recmb.Location = new System.Drawing.Point(165, 60);
            this.recmb.Name = "recmb";
            this.recmb.ReadOnly = true;
            this.recmb.Size = new System.Drawing.Size(173, 23);
            this.recmb.TabIndex = 8;
            // 
            // totalmb
            // 
            this.totalmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.totalmb.Location = new System.Drawing.Point(165, 31);
            this.totalmb.Name = "totalmb";
            this.totalmb.ReadOnly = true;
            this.totalmb.Size = new System.Drawing.Size(173, 23);
            this.totalmb.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total MBs Transferred";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.netBar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ramBar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cpuBar);
            this.groupBox2.Location = new System.Drawing.Point(13, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 166);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer Performance";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(146, 15);
            this.label21.TabIndex = 32;
            this.label21.Text = "Network Bandwith (Mbps)";
            // 
            // netBar
            // 
            this.netBar.Location = new System.Drawing.Point(17, 125);
            this.netBar.Name = "netBar";
            this.netBar.Size = new System.Drawing.Size(321, 23);
            this.netBar.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Free Memory";
            // 
            // ramBar
            // 
            this.ramBar.Location = new System.Drawing.Point(17, 82);
            this.ramBar.Name = "ramBar";
            this.ramBar.Size = new System.Drawing.Size(321, 23);
            this.ramBar.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "CPU Usage";
            // 
            // cpuBar
            // 
            this.cpuBar.Location = new System.Drawing.Point(17, 40);
            this.cpuBar.Name = "cpuBar";
            this.cpuBar.Size = new System.Drawing.Size(321, 23);
            this.cpuBar.TabIndex = 29;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LAN Checker";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::LAN_Checker.Properties.Resources.gtech;
            this.pictureBox2.Location = new System.Drawing.Point(15, 634);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(342, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(175, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 51);
            this.button2.TabIndex = 18;
            this.button2.Text = "Full Screen";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(691, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 51);
            this.button5.TabIndex = 16;
            this.button5.Text = "Quit Application";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(519, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 51);
            this.button4.TabIndex = 14;
            this.button4.Text = "Reset Network";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(347, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 51);
            this.button3.TabIndex = 13;
            this.button3.Text = "Ports Sniffer";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::LAN_Checker.Properties.Resources.Stop;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Stop Analysis";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 712);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(958, 60);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(368, 224);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.Size = new System.Drawing.Size(603, 476);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "MB Transferred";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightGray;
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(970, 163);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IPv6 Packets";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label34);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 141);
            this.panel2.TabIndex = 15;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Gray;
            this.label34.Location = new System.Drawing.Point(43, 44);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(82, 40);
            this.label34.TabIndex = 13;
            this.label34.Text = "IPv6";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.UDPv6sentpack);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.UDPv6recpack);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.UDPv6segsec);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Location = new System.Drawing.Point(538, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 141);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "UDPv6";
            // 
            // UDPv6sentpack
            // 
            this.UDPv6sentpack.BackColor = System.Drawing.Color.White;
            this.UDPv6sentpack.Location = new System.Drawing.Point(158, 91);
            this.UDPv6sentpack.Name = "UDPv6sentpack";
            this.UDPv6sentpack.Size = new System.Drawing.Size(180, 23);
            this.UDPv6sentpack.TabIndex = 11;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(112, 15);
            this.label27.TabIndex = 10;
            this.label27.Text = "Datagrams Sent/sec";
            // 
            // UDPv6recpack
            // 
            this.UDPv6recpack.BackColor = System.Drawing.Color.White;
            this.UDPv6recpack.Location = new System.Drawing.Point(158, 61);
            this.UDPv6recpack.Name = "UDPv6recpack";
            this.UDPv6recpack.Size = new System.Drawing.Size(180, 23);
            this.UDPv6recpack.TabIndex = 9;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(136, 15);
            this.label28.TabIndex = 8;
            this.label28.Text = "Datagrams Received/sec";
            // 
            // UDPv6segsec
            // 
            this.UDPv6segsec.BackColor = System.Drawing.Color.White;
            this.UDPv6segsec.Location = new System.Drawing.Point(158, 32);
            this.UDPv6segsec.Name = "UDPv6segsec";
            this.UDPv6segsec.Size = new System.Drawing.Size(180, 23);
            this.UDPv6segsec.TabIndex = 7;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(14, 35);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 15);
            this.label29.TabIndex = 6;
            this.label29.Text = "Datagrams/sec";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TCPv6sentpack);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.TCPv6recpack);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.TCPv6segsec);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Location = new System.Drawing.Point(181, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(350, 141);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TCPv6";
            // 
            // TCPv6sentpack
            // 
            this.TCPv6sentpack.BackColor = System.Drawing.Color.White;
            this.TCPv6sentpack.Location = new System.Drawing.Point(158, 91);
            this.TCPv6sentpack.Name = "TCPv6sentpack";
            this.TCPv6sentpack.Size = new System.Drawing.Size(180, 23);
            this.TCPv6sentpack.TabIndex = 11;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(14, 94);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(107, 15);
            this.label30.TabIndex = 10;
            this.label30.Text = "Segments Sent/sec";
            // 
            // TCPv6recpack
            // 
            this.TCPv6recpack.BackColor = System.Drawing.Color.White;
            this.TCPv6recpack.Location = new System.Drawing.Point(158, 61);
            this.TCPv6recpack.Name = "TCPv6recpack";
            this.TCPv6recpack.Size = new System.Drawing.Size(180, 23);
            this.TCPv6recpack.TabIndex = 9;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(14, 64);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 15);
            this.label31.TabIndex = 8;
            this.label31.Text = "Segments Received/sec";
            // 
            // TCPv6segsec
            // 
            this.TCPv6segsec.BackColor = System.Drawing.Color.White;
            this.TCPv6segsec.Location = new System.Drawing.Point(158, 32);
            this.TCPv6segsec.Name = "TCPv6segsec";
            this.TCPv6segsec.Size = new System.Drawing.Size(180, 23);
            this.TCPv6segsec.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(14, 35);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(81, 15);
            this.label32.TabIndex = 6;
            this.label32.Text = "Segments/sec";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(970, 163);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IPv4 Packets";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label33);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 141);
            this.panel1.TabIndex = 13;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Gray;
            this.label33.Location = new System.Drawing.Point(43, 44);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(82, 40);
            this.label33.TabIndex = 13;
            this.label33.Text = "IPv4";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.UDPv4sentpack);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.UDPv4recpack);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.UDPv4segsec);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Location = new System.Drawing.Point(538, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 141);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UDPv4";
            // 
            // UDPv4sentpack
            // 
            this.UDPv4sentpack.BackColor = System.Drawing.Color.White;
            this.UDPv4sentpack.Location = new System.Drawing.Point(158, 91);
            this.UDPv4sentpack.Name = "UDPv4sentpack";
            this.UDPv4sentpack.Size = new System.Drawing.Size(180, 23);
            this.UDPv4sentpack.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 94);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 15);
            this.label22.TabIndex = 10;
            this.label22.Text = "Datagrams Sent/sec";
            // 
            // UDPv4recpack
            // 
            this.UDPv4recpack.BackColor = System.Drawing.Color.White;
            this.UDPv4recpack.Location = new System.Drawing.Point(158, 61);
            this.UDPv4recpack.Name = "UDPv4recpack";
            this.UDPv4recpack.Size = new System.Drawing.Size(180, 23);
            this.UDPv4recpack.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(136, 15);
            this.label25.TabIndex = 8;
            this.label25.Text = "Datagrams Received/sec";
            // 
            // UDPv4segsec
            // 
            this.UDPv4segsec.BackColor = System.Drawing.Color.White;
            this.UDPv4segsec.Location = new System.Drawing.Point(158, 32);
            this.UDPv4segsec.Name = "UDPv4segsec";
            this.UDPv4segsec.Size = new System.Drawing.Size(180, 23);
            this.UDPv4segsec.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 35);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 15);
            this.label26.TabIndex = 6;
            this.label26.Text = "Datagrams/sec";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TCPv4sentpack);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TCPv4recpack);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TCPv4segsec);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(181, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 141);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TCPv4";
            // 
            // TCPv4sentpack
            // 
            this.TCPv4sentpack.BackColor = System.Drawing.Color.White;
            this.TCPv4sentpack.Location = new System.Drawing.Point(158, 91);
            this.TCPv4sentpack.Name = "TCPv4sentpack";
            this.TCPv4sentpack.Size = new System.Drawing.Size(180, 23);
            this.TCPv4sentpack.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Segments Sent/sec";
            // 
            // TCPv4recpack
            // 
            this.TCPv4recpack.BackColor = System.Drawing.Color.White;
            this.TCPv4recpack.Location = new System.Drawing.Point(158, 61);
            this.TCPv4recpack.Name = "TCPv4recpack";
            this.TCPv4recpack.Size = new System.Drawing.Size(180, 23);
            this.TCPv4recpack.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Segments Received/sec";
            // 
            // TCPv4segsec
            // 
            this.TCPv4segsec.BackColor = System.Drawing.Color.White;
            this.TCPv4segsec.Location = new System.Drawing.Point(158, 32);
            this.TCPv4segsec.Name = "TCPv4segsec";
            this.TCPv4segsec.Size = new System.Drawing.Size(180, 23);
            this.TCPv4segsec.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Segments/sec";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.debugLabel);
            this.tabPage1.Controls.Add(this.workgroup);
            this.tabPage1.Controls.Add(this.hostName);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.DNSAddress2);
            this.tabPage1.Controls.Add(this.DNSAddress1);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.gatewayIP);
            this.tabPage1.Controls.Add(this.subnetMask);
            this.tabPage1.Controls.Add(this.localAddr);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.NICSpeed);
            this.tabPage1.Controls.Add(this.NICname);
            this.tabPage1.Controls.Add(this.currentStatus);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Network Analysis";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel.Location = new System.Drawing.Point(719, 45);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(0, 14);
            this.debugLabel.TabIndex = 28;
            // 
            // workgroup
            // 
            this.workgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workgroup.AutoSize = true;
            this.workgroup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workgroup.Location = new System.Drawing.Point(831, 115);
            this.workgroup.Name = "workgroup";
            this.workgroup.Size = new System.Drawing.Size(58, 15);
            this.workgroup.TabIndex = 27;
            this.workgroup.Text = "Unknown";
            // 
            // hostName
            // 
            this.hostName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostName.AutoSize = true;
            this.hostName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostName.Location = new System.Drawing.Point(831, 99);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(58, 15);
            this.hostName.TabIndex = 26;
            this.hostName.Text = "Unknown";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(755, 114);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 15);
            this.label24.TabIndex = 25;
            this.label24.Text = "Workgroup:";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(755, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 15);
            this.label23.TabIndex = 24;
            this.label23.Text = "Host Name:";
            // 
            // DNSAddress2
            // 
            this.DNSAddress2.AutoSize = true;
            this.DNSAddress2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNSAddress2.Location = new System.Drawing.Point(494, 109);
            this.DNSAddress2.Name = "DNSAddress2";
            this.DNSAddress2.Size = new System.Drawing.Size(58, 15);
            this.DNSAddress2.TabIndex = 23;
            this.DNSAddress2.Text = "Unknown";
            // 
            // DNSAddress1
            // 
            this.DNSAddress1.AutoSize = true;
            this.DNSAddress1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNSAddress1.Location = new System.Drawing.Point(494, 94);
            this.DNSAddress1.Name = "DNSAddress1";
            this.DNSAddress1.Size = new System.Drawing.Size(58, 15);
            this.DNSAddress1.TabIndex = 22;
            this.DNSAddress1.Text = "Unknown";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(755, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 15);
            this.label20.TabIndex = 21;
            this.label20.Text = "Host Informations";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(699, 79);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // gatewayIP
            // 
            this.gatewayIP.AutoSize = true;
            this.gatewayIP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gatewayIP.Location = new System.Drawing.Point(165, 123);
            this.gatewayIP.Name = "gatewayIP";
            this.gatewayIP.Size = new System.Drawing.Size(58, 15);
            this.gatewayIP.TabIndex = 19;
            this.gatewayIP.Text = "Unknown";
            // 
            // subnetMask
            // 
            this.subnetMask.AutoSize = true;
            this.subnetMask.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnetMask.Location = new System.Drawing.Point(165, 108);
            this.subnetMask.Name = "subnetMask";
            this.subnetMask.Size = new System.Drawing.Size(58, 15);
            this.subnetMask.TabIndex = 18;
            this.subnetMask.Text = "Unknown";
            // 
            // localAddr
            // 
            this.localAddr.AutoSize = true;
            this.localAddr.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localAddr.Location = new System.Drawing.Point(165, 93);
            this.localAddr.Name = "localAddr";
            this.localAddr.Size = new System.Drawing.Size(58, 15);
            this.localAddr.TabIndex = 17;
            this.localAddr.Text = "Unknown";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(446, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 15);
            this.label19.TabIndex = 16;
            this.label19.Text = "DNS 2:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(446, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 15);
            this.label18.TabIndex = 15;
            this.label18.Text = "DNS 1:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(446, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "DNS Parameters";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(390, 79);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(81, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "Gateway:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(81, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "Subnet Mask:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(81, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "IP Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(81, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Network Parameters";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // NICSpeed
            // 
            this.NICSpeed.AutoSize = true;
            this.NICSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NICSpeed.Location = new System.Drawing.Point(167, 50);
            this.NICSpeed.Name = "NICSpeed";
            this.NICSpeed.Size = new System.Drawing.Size(58, 15);
            this.NICSpeed.TabIndex = 7;
            this.NICSpeed.Text = "Unknown";
            // 
            // NICname
            // 
            this.NICname.AutoSize = true;
            this.NICname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NICname.Location = new System.Drawing.Point(167, 33);
            this.NICname.Name = "NICname";
            this.NICname.Size = new System.Drawing.Size(58, 15);
            this.NICname.TabIndex = 6;
            this.NICname.Text = "Unknown";
            // 
            // currentStatus
            // 
            this.currentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.currentStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStatus.Location = new System.Drawing.Point(495, 33);
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.ReadOnly = true;
            this.currentStatus.Size = new System.Drawing.Size(179, 23);
            this.currentStatus.TabIndex = 5;
            this.currentStatus.Text = "NO NETWORK CARD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(81, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Speed:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(81, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Network Card Informations";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(978, 191);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.label43);
            this.tabPage2.Controls.Add(this.SMB_totalM);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.SMB_recM);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.SMB_sentM);
            this.tabPage2.Controls.Add(this.label42);
            this.tabPage2.Controls.Add(this.SMB_total);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.SMB_rec);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.SMB_sent);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 163);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "SMB Server";
            // 
            // SMB_totalM
            // 
            this.SMB_totalM.BackColor = System.Drawing.Color.White;
            this.SMB_totalM.Location = new System.Drawing.Point(650, 36);
            this.SMB_totalM.Name = "SMB_totalM";
            this.SMB_totalM.Size = new System.Drawing.Size(180, 23);
            this.SMB_totalM.TabIndex = 30;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(548, 39);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(64, 15);
            this.label37.TabIndex = 29;
            this.label37.Text = "MB Total/s";
            // 
            // SMB_recM
            // 
            this.SMB_recM.BackColor = System.Drawing.Color.White;
            this.SMB_recM.Location = new System.Drawing.Point(650, 90);
            this.SMB_recM.Name = "SMB_recM";
            this.SMB_recM.Size = new System.Drawing.Size(180, 23);
            this.SMB_recM.TabIndex = 28;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(548, 93);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(85, 15);
            this.label41.TabIndex = 27;
            this.label41.Text = "MB Received/s";
            // 
            // SMB_sentM
            // 
            this.SMB_sentM.BackColor = System.Drawing.Color.White;
            this.SMB_sentM.Location = new System.Drawing.Point(650, 63);
            this.SMB_sentM.Name = "SMB_sentM";
            this.SMB_sentM.Size = new System.Drawing.Size(180, 23);
            this.SMB_sentM.TabIndex = 26;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(548, 66);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(61, 15);
            this.label42.TabIndex = 25;
            this.label42.Text = "MB Sent/s";
            // 
            // SMB_total
            // 
            this.SMB_total.BackColor = System.Drawing.Color.White;
            this.SMB_total.Location = new System.Drawing.Point(342, 36);
            this.SMB_total.Name = "SMB_total";
            this.SMB_total.Size = new System.Drawing.Size(180, 23);
            this.SMB_total.TabIndex = 24;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(240, 39);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(60, 15);
            this.label36.TabIndex = 23;
            this.label36.Text = "KB Total/s";
            // 
            // SMB_rec
            // 
            this.SMB_rec.BackColor = System.Drawing.Color.White;
            this.SMB_rec.Location = new System.Drawing.Point(342, 90);
            this.SMB_rec.Name = "SMB_rec";
            this.SMB_rec.Size = new System.Drawing.Size(180, 23);
            this.SMB_rec.TabIndex = 22;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(240, 93);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(81, 15);
            this.label39.TabIndex = 21;
            this.label39.Text = "KB Received/s";
            // 
            // SMB_sent
            // 
            this.SMB_sent.BackColor = System.Drawing.Color.White;
            this.SMB_sent.Location = new System.Drawing.Point(342, 63);
            this.SMB_sent.Name = "SMB_sent";
            this.SMB_sent.Size = new System.Drawing.Size(180, 23);
            this.SMB_sent.TabIndex = 20;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(240, 66);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(57, 15);
            this.label38.TabIndex = 19;
            this.label38.Text = "KB Sent/s";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label35);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 141);
            this.panel3.TabIndex = 14;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Gray;
            this.label35.Location = new System.Drawing.Point(35, 56);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(90, 40);
            this.label35.TabIndex = 14;
            this.label35.Text = "SMB";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(115, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(240, 132);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(216, 15);
            this.label43.TabIndex = 31;
            this.label43.Text = "This is only for Windows 10 Computers.";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(978, 797);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAN Checker v. 0.73";
            this.Deactivate += new System.EventHandler(this.MainFrm_Deactivate);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLANCheckerToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem checksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portCheckerToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sentmb;
        private System.Windows.Forms.TextBox recmb;
        private System.Windows.Forms.TextBox totalmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem dNSToIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar ramBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar cpuBar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ProgressBar netBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox UDPv4sentpack;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox UDPv4recpack;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox UDPv4segsec;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TCPv4sentpack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TCPv4recpack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TCPv4segsec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label workgroup;
        private System.Windows.Forms.Label hostName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label DNSAddress2;
        private System.Windows.Forms.Label DNSAddress1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label gatewayIP;
        private System.Windows.Forms.Label subnetMask;
        private System.Windows.Forms.Label localAddr;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label NICSpeed;
        private System.Windows.Forms.Label NICname;
        private System.Windows.Forms.TextBox currentStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox UDPv6sentpack;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox UDPv6recpack;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox UDPv6segsec;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox TCPv6sentpack;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox TCPv6recpack;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox TCPv6segsec;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox SMB_rec;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox SMB_sent;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox SMB_total;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox SMB_totalM;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox SMB_recM;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox SMB_sentM;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Label label43;
    }
}

