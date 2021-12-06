using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Very_Simple_IP_Configurator
{
    public partial class FormIP : Form
    {
        public FormIP(string _nicId)
        {
            InitializeComponent();
            nicId = _nicId;
        }

        private string nicId;

        private void LoadCurrentIpSettings()
        {
            var nic = NetworkConfigurator.GetNicByID(nicId);
            {
                var ipProps = nic.GetIPProperties();

                if (ipProps.GetIPv4Properties().IsDhcpEnabled == false)
                {
                    var ipv4Addresses = ipProps.UnicastAddresses.Where(nw => nw.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                    var ipv4Gateways = ipProps.GatewayAddresses.Where(nw => nw.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                    var ipv4DnsServer = ipProps.DnsAddresses.Where(nw => nw.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                    InsertIP(ipv4Addresses);
                    InsertGateway(ipv4Gateways);
                    InsertDNS(ipv4DnsServer);
                }

            }
        }

        private void InsertIP(IEnumerable<UnicastIPAddressInformation> ipv4Addresses)
        {
            if (ipv4Addresses.Count() > 0)
            {
                if (ipv4Addresses.Count() > 1)
                    MessageBox.Show("There are multiple IPv4 configured. Your settings will be overwritten by this configuration!", "Warning");

                var firstIP = ipv4Addresses.First();
                textBoxStaticIp.Text = firstIP.Address.ToString();
                textBoxStaticSubnet.Text = firstIP.IPv4Mask.ToString();
            }
        }

        private void InsertGateway(IEnumerable<GatewayIPAddressInformation> gatewayIPAddresses)
        {
            if (gatewayIPAddresses.Count() > 0)
            {
                var firstGw = gatewayIPAddresses.First();
                textBoxStaticGateway.Text = firstGw.Address.ToString();
            }
        }

        private void InsertDNS(IEnumerable<IPAddress> DnsServer)
        {
            if (DnsServer.Count() > 0)
            {
                textBoxDns1.Text = DnsServer.ElementAt(0).ToString();
                if (DnsServer.Count() > 1)
                {
                    textBoxDns2.Text = DnsServer.ElementAt(1).ToString();
                }
            }
        }

        private bool ParseAll()
        {
            if (string.IsNullOrEmpty(textBoxStaticIp.Text))
                return false;
            else
            {
                if (parseIP(textBoxStaticIp.Text) == false)
                {
                    errorProvider1.SetError(textBoxStaticIp, "Wrong format");
                    return false;
                }
                if (!string.IsNullOrEmpty(textBoxStaticGateway.Text) && parseIP(textBoxStaticGateway.Text) == false)
                {
                    errorProvider1.SetError(textBoxStaticGateway, "Wrong format");
                    return false;
                }
                if (!string.IsNullOrEmpty(textBoxDns1.Text) && parseIP(textBoxDns1.Text) == false)
                {
                    errorProvider1.SetError(textBoxDns1, "Wrong format");
                    return false;
                }
                if (!string.IsNullOrEmpty(textBoxDns2.Text) && parseIP(textBoxDns2.Text) == false)
                {
                    errorProvider1.SetError(textBoxDns2, "Wrong format");
                    return false;
                }
                return true;
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (ParseAll())
            {
                var ip = GetIP();
                var gw = GetGateway();
                if (ip != null)
                {
                    Form1.NetworkConfigurator.SetIP(ip, gw, nicId);
                    if (gw == null)
                    {
                        Form1.NetworkConfigurator.SetGatewayToNull(nicId, ip.First());
                    }
                }
                var dns = GetDnsServer();
                if (dns == null)
                    Form1.NetworkConfigurator.EnableDnsDhcp(nicId);
                else
                    Form1.NetworkConfigurator.SetNameservers(nicId, dns);

                this.Close();

            }
        }
        public static bool parseIP(string IpAdress)
        {

            Regex reg = new Regex(@"^[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}$");
            if (!reg.IsMatch(IpAdress))
                return false;
            else
                return IPAddress.TryParse(IpAdress, out IPAddress result);

        }
        private List<IpAddressParam> GetIP()
        {
            if (string.IsNullOrEmpty(textBoxStaticIp.Text) || string.IsNullOrEmpty(textBoxStaticSubnet.Text))
                return null;
            else
                return new List<IpAddressParam> { (new IpAddressParam() { IpAddress = textBoxStaticIp.Text, Subnetmask = textBoxStaticSubnet.Text }) };
        }

        private List<GatewayParam> GetGateway()
        {
            if (string.IsNullOrEmpty(textBoxStaticGateway.Text))
                return null;
            else
                return new List<GatewayParam> { new GatewayParam() { Gateway = textBoxStaticGateway.Text, Metric = 1 } };
        }

        private List<string> GetDnsServer()
        {
            if (string.IsNullOrEmpty(textBoxDns1.Text))
                return null;
            else
            {
                List<string> list = new List<string>();
                list.Add(textBoxDns1.Text);
                if (!string.IsNullOrEmpty(textBoxDns2.Text))
                    list.Add(textBoxDns2.Text);

                return list;
            }
        }

        private void FormIP_Load(object sender, EventArgs e)
        {
            LoadCurrentIpSettings();

        }

        private void textBoxIpSettingCidr_TextChanged(object sender, EventArgs e)
        {
            int cidr;
            if (int.TryParse(textBoxIpSettingCidr.Text, out cidr))
            {
                if (cidr != -1)
                    textBoxStaticSubnet.Text = GetSubnetByCidr(cidr);
            }
            else
                textBoxIpSettingCidr.Clear();
        }

        public static int GetSubnetByMask(string mask)
        {
            switch (mask)
            {
                case "0.0.0.0":
                    return 0;
                case "128.0.0.0":
                    return 1;
                case "192.0.0.0":
                    return 2;
                case "224.0.0.0":
                    return 3;
                case "240.0.0.0":
                    return 4;
                case "248.0.0.0":
                    return 5;
                case "252.0.0.0":
                    return 6;
                case "254.0.0.0":
                    return 7;
                case "255.0.0.0":
                    return 8;
                case "255.128.0.0":
                    return 9;
                case "255.192.0.0":
                    return 10;
                case "255.224.0.0":
                    return 11;
                case "255.240.0.0":
                    return 12;
                case "255.248.0.0":
                    return 13;
                case "255.252.0.0":
                    return 14;
                case "255.254.0.0":
                    return 15;
                case "255.255.0.0":
                    return 16;
                case "255.255.128.0":
                    return 17;
                case "255.255.192.0":
                    return 18;
                case "255.255.224.0":
                    return 19;
                case "255.255.240.0":
                    return 20;
                case "255.255.248.0":
                    return 21;
                case "255.255.252.0":
                    return 22;
                case "255.255.254.0":
                    return 23;
                case "255.255.255.0":
                    return 24;
                case "255.255.255.128":
                    return 25;
                case "255.255.255.192":
                    return 26;
                case "255.255.255.224":
                    return 27;
                case "255.255.255.240":
                    return 28;
                case "255.255.255.248":
                    return 29;
                case "255.255.255.252":
                    return 30;
                case "255.255.255.254":
                    return 31;
                case "255.255.255.255":
                    return 32;
                default:
                    return -1;

            }
        }
        public static string GetSubnetByCidr(int iByte)
        {
            switch (iByte)
            {
                case 0:
                    return "0.0.0.0";
                case 1:
                    return "128.0.0.0";
                case 2:
                    return "192.0.0.0";
                case 3:
                    return "224.0.0.0";
                case 4:
                    return "240.0.0.0";
                case 5:
                    return "248.0.0.0";
                case 6:
                    return "252.0.0.0";
                case 7:
                    return "254.0.0.0";
                case 8:
                    return "255.0.0.0";
                case 9:
                    return "255.128.0.0";
                case 10:
                    return "255.192.0.0";
                case 11:
                    return "255.224.0.0";
                case 12:
                    return "255.240.0.0";
                case 13:
                    return "255.248.0.0";
                case 14:
                    return "255.252.0.0";
                case 15:
                    return "255.254.0.0";
                case 16:
                    return "255.255.0.0";
                case 17:
                    return "255.255.128.0";
                case 18:
                    return "255.255.192.0";
                case 19:
                    return "255.255.224.0";
                case 20:
                    return "255.255.240.0";
                case 21:
                    return "255.255.248.0";
                case 22:
                    return "255.255.252.0";
                case 23:
                    return "255.255.254.0";
                case 24:
                    return "255.255.255.0";
                case 25:
                    return "255.255.255.128";
                case 26:
                    return "255.255.255.192";
                case 27:
                    return "255.255.255.224";
                case 28:
                    return "255.255.255.240";
                case 29:
                    return "255.255.255.248";
                case 30:
                    return "255.255.255.252";
                case 31:
                    return "255.255.255.254";
                case 32:
                    return "255.255.255.255";
                default:
                    return string.Empty;

            }
        }

        private void textBoxStaticSubnet_TextChanged(object sender, EventArgs e)
        {
            int cidr = GetSubnetByMask(textBoxStaticSubnet.Text);
            if (cidr != -1)
                textBoxIpSettingCidr.Text = cidr.ToString();
            else
                textBoxIpSettingCidr.Text = string.Empty;
        }

        private void textBoxStaticIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIP_Shown(object sender, EventArgs e)
        {
            textBoxStaticIp.Focus();
        }

        private void FormIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
