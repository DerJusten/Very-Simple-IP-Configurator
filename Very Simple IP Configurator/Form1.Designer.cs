
namespace Very_Simple_IP_Configurator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDHCP = new System.Windows.Forms.Button();
            this.buttonStaticIP = new System.Windows.Forms.Button();
            this.buttonDhcpRenew = new System.Windows.Forms.Button();
            this.labelHeaderNic = new System.Windows.Forms.Label();
            this.comboBoxNetworkCard = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitButton1 = new Very_Simple_IP_Configurator.SplitButton();
            this.customPbShowConf = new Very_Simple_IP_Configurator.CustomPb();
            this.labelMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customPbRefreshIpconfig = new Very_Simple_IP_Configurator.CustomPb();
            this.textBoxIpConfig = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRPaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.customPbRefresh = new Very_Simple_IP_Configurator.CustomPb();
            this.customPbUAC = new Very_Simple_IP_Configurator.CustomPb();
            this.timerReload = new System.Windows.Forms.Timer(this.components);
            this.customPbNicEnable = new Very_Simple_IP_Configurator.CustomPb();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPbShowConf)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPbRefreshIpconfig)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPbUAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPbNicEnable)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDHCP
            // 
            this.buttonDHCP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDHCP.Location = new System.Drawing.Point(21, 25);
            this.buttonDHCP.Name = "buttonDHCP";
            this.buttonDHCP.Size = new System.Drawing.Size(172, 60);
            this.buttonDHCP.TabIndex = 0;
            this.buttonDHCP.Text = "Enable DHCP";
            this.buttonDHCP.UseVisualStyleBackColor = true;
            this.buttonDHCP.Click += new System.EventHandler(this.buttonDHCP_Click);
            // 
            // buttonStaticIP
            // 
            this.buttonStaticIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaticIP.Location = new System.Drawing.Point(242, 25);
            this.buttonStaticIP.Name = "buttonStaticIP";
            this.buttonStaticIP.Size = new System.Drawing.Size(172, 60);
            this.buttonStaticIP.TabIndex = 1;
            this.buttonStaticIP.Text = "Enable/Edit static IP";
            this.buttonStaticIP.UseVisualStyleBackColor = true;
            this.buttonStaticIP.Click += new System.EventHandler(this.buttonStaticIP_Click);
            // 
            // buttonDhcpRenew
            // 
            this.buttonDhcpRenew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDhcpRenew.Location = new System.Drawing.Point(21, 96);
            this.buttonDhcpRenew.Name = "buttonDhcpRenew";
            this.buttonDhcpRenew.Size = new System.Drawing.Size(172, 60);
            this.buttonDhcpRenew.TabIndex = 2;
            this.buttonDhcpRenew.Text = "Renew DHCP";
            this.buttonDhcpRenew.UseVisualStyleBackColor = true;
            this.buttonDhcpRenew.Click += new System.EventHandler(this.buttonDhcpRenew_Click);
            // 
            // labelHeaderNic
            // 
            this.labelHeaderNic.AutoSize = true;
            this.labelHeaderNic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelHeaderNic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelHeaderNic.Location = new System.Drawing.Point(12, 9);
            this.labelHeaderNic.Name = "labelHeaderNic";
            this.labelHeaderNic.Size = new System.Drawing.Size(109, 21);
            this.labelHeaderNic.TabIndex = 14;
            this.labelHeaderNic.Text = "Networkcard";
            // 
            // comboBoxNetworkCard
            // 
            this.comboBoxNetworkCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNetworkCard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxNetworkCard.FormattingEnabled = true;
            this.comboBoxNetworkCard.Location = new System.Drawing.Point(12, 41);
            this.comboBoxNetworkCard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxNetworkCard.Name = "comboBoxNetworkCard";
            this.comboBoxNetworkCard.Size = new System.Drawing.Size(395, 29);
            this.comboBoxNetworkCard.TabIndex = 13;
            this.comboBoxNetworkCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxNetworkCard_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitButton1);
            this.groupBox1.Controls.Add(this.customPbShowConf);
            this.groupBox1.Controls.Add(this.labelMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonDhcpRenew);
            this.groupBox1.Controls.Add(this.buttonStaticIP);
            this.groupBox1.Controls.Add(this.buttonDHCP);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 205);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // splitButton1
            // 
            this.splitButton1.AutoSize = true;
            this.splitButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton1.Location = new System.Drawing.Point(242, 96);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.Size = new System.Drawing.Size(172, 60);
            this.splitButton1.TabIndex = 8;
            this.splitButton1.Text = "Network Adapter";
            this.splitButton1.UseVisualStyleBackColor = true;
            this.splitButton1.Click += new System.EventHandler(this.buttonScAdapterSettings_Click);
            // 
            // customPbShowConf
            // 
            this.customPbShowConf.Image = global::Very_Simple_IP_Configurator.Properties.Resources.down_arrow;
            this.customPbShowConf.Location = new System.Drawing.Point(378, 166);
            this.customPbShowConf.Name = "customPbShowConf";
            this.customPbShowConf.Size = new System.Drawing.Size(36, 32);
            this.customPbShowConf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPbShowConf.TabIndex = 7;
            this.customPbShowConf.TabStop = false;
            this.customPbShowConf.Click += new System.EventHandler(this.customPbShowConf_Click);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.Location = new System.Drawing.Point(95, 175);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(44, 17);
            this.labelMode.TabIndex = 6;
            this.labelMode.Text = "DHCP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP-Mode:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.customPbRefreshIpconfig);
            this.groupBox2.Controls.Add(this.textBoxIpConfig);
            this.groupBox2.Location = new System.Drawing.Point(11, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 204);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "IP-Configuration";
            // 
            // customPbRefreshIpconfig
            // 
            this.customPbRefreshIpconfig.Image = global::Very_Simple_IP_Configurator.Properties.Resources.reload_1_;
            this.customPbRefreshIpconfig.Location = new System.Drawing.Point(382, 14);
            this.customPbRefreshIpconfig.Name = "customPbRefreshIpconfig";
            this.customPbRefreshIpconfig.Size = new System.Drawing.Size(32, 29);
            this.customPbRefreshIpconfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPbRefreshIpconfig.TabIndex = 18;
            this.customPbRefreshIpconfig.TabStop = false;
            this.customPbRefreshIpconfig.Click += new System.EventHandler(this.customPbRefreshIpconfig_Click);
            // 
            // textBoxIpConfig
            // 
            this.textBoxIpConfig.Location = new System.Drawing.Point(21, 49);
            this.textBoxIpConfig.Multiline = true;
            this.textBoxIpConfig.Name = "textBoxIpConfig";
            this.textBoxIpConfig.ReadOnly = true;
            this.textBoxIpConfig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIpConfig.Size = new System.Drawing.Size(393, 149);
            this.textBoxIpConfig.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AutoSize = false;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.test2ToolStripMenuItem,
            this.aRPaToolStripMenuItem,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.Text = "ARP -a";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.testToolStripMenuItem.Text = "Flush DNS";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.test2ToolStripMenuItem.Text = "Route Print";
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
            // 
            // aRPaToolStripMenuItem
            // 
            this.aRPaToolStripMenuItem.Name = "aRPaToolStripMenuItem";
            this.aRPaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aRPaToolStripMenuItem.Text = "ARP -a";
            this.aRPaToolStripMenuItem.Click += new System.EventHandler(this.aRPaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // customPbRefresh
            // 
            this.customPbRefresh.Image = global::Very_Simple_IP_Configurator.Properties.Resources.reload_1_;
            this.customPbRefresh.Location = new System.Drawing.Point(413, 41);
            this.customPbRefresh.Name = "customPbRefresh";
            this.customPbRefresh.Size = new System.Drawing.Size(32, 29);
            this.customPbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPbRefresh.TabIndex = 17;
            this.customPbRefresh.TabStop = false;
            this.customPbRefresh.Click += new System.EventHandler(this.customPbRefresh_Click);
            // 
            // customPbUAC
            // 
            this.customPbUAC.Image = global::Very_Simple_IP_Configurator.Properties.Resources.imageres_78_2;
            this.customPbUAC.Location = new System.Drawing.Point(413, 4);
            this.customPbUAC.Name = "customPbUAC";
            this.customPbUAC.Size = new System.Drawing.Size(32, 32);
            this.customPbUAC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPbUAC.TabIndex = 3;
            this.customPbUAC.TabStop = false;
            this.customPbUAC.Click += new System.EventHandler(this.customPb1_Click);
            // 
            // timerReload
            // 
            this.timerReload.Interval = 1500;
            this.timerReload.Tick += new System.EventHandler(this.timerReload_Tick);
            // 
            // customPbNicEnable
            // 
            this.customPbNicEnable.Image = global::Very_Simple_IP_Configurator.Properties.Resources.reload_1_;
            this.customPbNicEnable.Location = new System.Drawing.Point(375, 4);
            this.customPbNicEnable.Name = "customPbNicEnable";
            this.customPbNicEnable.Size = new System.Drawing.Size(32, 32);
            this.customPbNicEnable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customPbNicEnable.TabIndex = 18;
            this.customPbNicEnable.TabStop = false;
            this.customPbNicEnable.Click += new System.EventHandler(this.customPbNicEnable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 496);
            this.Controls.Add(this.customPbNicEnable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.customPbRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelHeaderNic);
            this.Controls.Add(this.customPbUAC);
            this.Controls.Add(this.comboBoxNetworkCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Very Simple IP Configurator (v0.1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPbShowConf)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPbRefreshIpconfig)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customPbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPbUAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPbNicEnable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDHCP;
        private System.Windows.Forms.Button buttonStaticIP;
        private System.Windows.Forms.Button buttonDhcpRenew;
        private System.Windows.Forms.Label labelHeaderNic;
        private System.Windows.Forms.ComboBox comboBoxNetworkCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomPb customPbUAC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxIpConfig;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label label1;
        private CustomPb customPbShowConf;
        private CustomPb customPbRefresh;
        private CustomPb customPbRefreshIpconfig;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private SplitButton splitButton1;
        private System.Windows.Forms.ToolStripMenuItem aRPaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerReload;
        private CustomPb customPbNicEnable;
    }
}

