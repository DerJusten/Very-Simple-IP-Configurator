using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Very_Simple_IP_Configurator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static NetworkConfigurator NetworkConfigurator;
        private string CurrentNicId;
 

        private void Form1_Load(object sender, EventArgs e)
        {
            NetworkConfigurator = new NetworkConfigurator();
            if (Properties.Settings.Default.showSettings == false)
                this.Height = this.Height - groupBox2.Height - 10;
            else
                customPbShowConf.Image = Properties.Resources.up_arrow_1_;
            CheckIfIsElevated();

            LoadCombobox(null);
            splitButton1.ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.Width = splitButton1.Width;


        }

        private void LoadIpConfig()
        {
            var nic = NetworkConfigurator.GetNicByID(CurrentNicId);
            if (nic != null)
            {

                var ipProps = nic.GetIPProperties();
                if (ipProps.GetIPv4Properties().IsDhcpEnabled)
                    labelMode.Text = "DHCP";
                else
                    labelMode.Text = "Static";

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Name:\t\t\t" + nic.Name);

                sb.AppendLine("MAC-Address:\t\t" + ConvertPhysicalAddressToString(nic.GetPhysicalAddress()));
                sb.AppendLine("Speed:\t\t\t" + ConvertToMbits(nic.Speed) + "MBit/s");
                sb.AppendLine("#############################################");
                var ipv4Addresses = ipProps.UnicastAddresses.Where(nw => nw.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                foreach (var item in ipv4Addresses)
                {
                    sb.AppendLine("IP-Address:\t\t" + item.Address.ToString());
                    sb.AppendLine("Subnetmask:\t\t" + item.IPv4Mask.ToString());
                }

                var ipv4Gateways = ipProps.GatewayAddresses.Where(nw => nw.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                foreach (var item in ipv4Gateways)
                {
                    sb.AppendLine("Gateway:\t\t\t" + item.Address.ToString());
                }
                var ipv4DnsServer = ipProps.DnsAddresses.Where(nw => nw.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                foreach (var item in ipv4DnsServer)
                {
                    sb.AppendLine("DNS-Server:\t\t" + item.ToString());
                }
                var dhcp = ipProps.DhcpServerAddresses.Where(nw => nw.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                foreach (var item in dhcp)
                {
                    sb.AppendLine("DHCP-Server:\t\t" + item.ToString());
                }
                if (dhcp.Count() > 0)
                    sb.AppendLine("DHCP Lease valid until:\t" + DateTime.Now.AddSeconds(ipv4Addresses.First().AddressValidLifetime));
                textBoxIpConfig.Text = sb.ToString();
            }
        }


        private void CheckIfIsElevated()
        {
            if (IsElevated)
            {
                this.Text += " (Administrator)";
                customPbUAC.Visible = false;
            }
            else
            {
                this.Text += " (non Administrator)";

                customPbUAC.Visible = true;
                buttonDHCP.Enabled = false;
                buttonDhcpRenew.Enabled = false;
                buttonStaticIP.Enabled = false;

                RunAppAsAdmin();
            }
        }
        private void LoadCombobox(string displayNic)
        {


            IEnumerable<NetworkInterface> nics = GetAllNics();
            //var nics2 = NetworkConfigurator.GetAllNetworkAdapter();
            //foreach (var item in nics2)
            //{
            //    item.
            //}
            comboBoxNetworkCard.DataSource = InsertNicsToDataTable(nics);
            comboBoxNetworkCard.ValueMember = "ID";
            comboBoxNetworkCard.DisplayMember = "Name";



            var nicWithGateway = nics.Where(nw => nw.OperationalStatus == OperationalStatus.Up && nw.GetIPProperties().GatewayAddresses.Count > 0);
            if (nicWithGateway.Count() > 0)
                if (string.IsNullOrEmpty(displayNic))
                    comboBoxNetworkCard.SelectedValue = nicWithGateway.First().Id;
                else
                {

                    comboBoxNetworkCard.SelectedValue = displayNic;
                }

        }

        public static IEnumerable<NetworkInterface> GetAllNics()
        {
            return NetworkInterface.GetAllNetworkInterfaces().Where(nw => nw.NetworkInterfaceType != NetworkInterfaceType.Loopback && nw.NetworkInterfaceType.ToString() != "53");
        }
        public static DataTable InsertNicsToDataTable(IEnumerable<NetworkInterface> Nics)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");

            foreach (NetworkInterface nic in Nics)
            {
            
                    dt.Rows.Add(nic.Id, nic.Description);
            }
            return dt;
        }

        private void buttonDHCP_Click(object sender, EventArgs e)
        {
            NetworkConfigurator.EnableIpDhcp(CurrentNicId);
            timerReload.Start();
        }
        private string ConvertPhysicalAddressToString(PhysicalAddress mac)
        {
            string _mac = mac.ToString();
            if (!string.IsNullOrEmpty(_mac))
            {
                _mac = Regex.Replace(_mac, ".{2}", "$0:");
                return _mac.Substring(0, _mac.Length - 1);
            }
            else
                return string.Empty;
        }
        private double ConvertToMbits(long speed)
        {
            return (double)(speed / Math.Pow(1000, 2));
        }
        private void buttonStaticIP_Click(object sender, EventArgs e)
        {

            using (FormIP fIP = new FormIP(CurrentNicId))
                fIP.ShowDialog();

            LoadIpConfig();
        }

        private void buttonDhcpRenew_Click(object sender, EventArgs e)
        {
            NetworkConfigurator.ReleaseDHCP(CurrentNicId);
            timerReload.Start();
        }

        private void comboBoxNetworkCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNetworkCard.SelectedItem != null)
            {
                CurrentNicId = comboBoxNetworkCard.SelectedValue.ToString();
                if (!CurrentNicId.Contains("System."))
                {
                    Properties.Settings.Default.latestNic = CurrentNicId;
                    Properties.Settings.Default.Save();
                }
                LoadIpConfig();
            }
            else
                CurrentNicId = string.Empty;

        }

        private void customPb1_Click(object sender, EventArgs e)
        {
            RunAppAsAdmin();
        }

        private void RunAppAsAdmin()
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.FileName = Application.ExecutablePath;
            proc.Verb = "runas";
            try
            {
                Process.Start(proc);
            }
            catch
            {
                // The user refused the elevation.
                // Do nothing and return directly ...
                return;
            }
            Application.Exit();
        }
        static bool IsElevated
        {
            get
            {
                return WindowsIdentity.GetCurrent().Owner
                  .IsWellKnown(WellKnownSidType.BuiltinAdministratorsSid);
            }
        }

        private void buttonScAdapterSettings_Click(object sender, EventArgs e)
        {
            Process.Start("ncpa.cpl");
        }

        private void customPbShowConf_Click(object sender, EventArgs e)
        {
            int h;
            if (Properties.Settings.Default.showSettings == false)
            {
                h = this.Height + groupBox2.Height + 10;
                this.MaximumSize = new Size(this.Width, h);
                this.Height = h;
                customPbShowConf.Image = Properties.Resources.up_arrow_1_;
                Properties.Settings.Default.showSettings = true;

            }
            else
            {
                h = this.Height - groupBox2.Height - 10;
                this.MaximumSize = new Size(this.Width, h);
                this.Height = h;
                customPbShowConf.Image = Properties.Resources.down_arrow;
                Properties.Settings.Default.showSettings = false;
            }

            Properties.Settings.Default.Save();
        }

        private void customPbRefresh_Click(object sender, EventArgs e)
        {
            LoadCombobox(CurrentNicId);
        }

        private void customPbRefreshIpconfig_Click(object sender, EventArgs e)
        {
            LoadIpConfig();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = Environment.SystemDirectory;
            proc.FileName = "ipconfig";
            proc.Arguments = "/flushdns";

            Process.Start(proc);
        }

        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/k route print");
        }

        private void aRPaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/k arp -a");
        }

        private void timerReload_Tick(object sender, EventArgs e)
        {
            LoadIpConfig();
            timerReload.Stop();
        }

        private void customPbNicEnable_Click(object sender, EventArgs e)
        {
            var nic =NetworkConfigurator.GetNicByID(CurrentNicId);
            if(nic != null)
            {
                if (nic.OperationalStatus == OperationalStatus.Down)
                    NetworkConfigurator.EnableNic(CurrentNicId);

                LoadCombobox(CurrentNicId);
            }
        }
    }



    public class IpAddressParam
    {
        public string IpAddress { get; set; }
        public string Subnetmask { get; set; }
    }

    public class GatewayParam
    {
        public string Gateway { get; set; } = null;
        public int Metric { get; set; } = 0;
    }
}
