using ROOT.CIMV2.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Very_Simple_IP_Configurator
{
    public class NetworkConfigurator
    {
        public List<NetworkAdapter> GetAllNetworkAdapter()
        {
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                using (ManagementObjectCollection queryCollection = searcher.Get())
                {
                    List<NetworkAdapter> lAdapter = new List<NetworkAdapter>();
                    foreach (ManagementObject m in queryCollection.Cast<ManagementObject>())
                    {
                        lAdapter.Add(new NetworkAdapter(m));
                    }
                    return lAdapter;
                }
            }
        }
        private NetworkAdapter GetNetworkAdapter(string nicName)
        {
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                using (ManagementObjectCollection queryCollection = searcher.Get())
                {
                    foreach (ManagementObject m in queryCollection.Cast<ManagementObject>().Where(x => x["GUID"].Equals(nicName)))
                    {
                        return new NetworkAdapter(m);
                    }
                    throw new Exception();
                }
            }
        }

        public void EnableNic(string nicName)
        {

            using (NetworkAdapter adapter = GetNetworkAdapter(nicName))
                adapter.Enable();

        }
        public void DisableNic(string nicName)
        {
            using (NetworkAdapter adapter = GetNetworkAdapter(nicName))
                adapter.Disable();
        }

        public string GetNicState(string nicName)
        {
            using (NetworkAdapter adapter = GetNetworkAdapter(nicName))
                return adapter.NetEnabled.ToString();
        }

        //rework
        public void RestartNic(string nicName)
        {
            DisableNic(nicName);
            Thread.Sleep(2000);
            EnableNic(nicName);
        }
        public void SetGatewayToNull(string nicId, IpAddressParam ipAddress)
        {
            NetworkInterface nic = NetworkInterface.GetAllNetworkInterfaces().Where(nw => nw.Id == nicId).FirstOrDefault();
            if (nic != null)
            {
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface ip set address \"" + nic.Name + "\" static " + ipAddress.IpAddress + " " + ipAddress.Subnetmask + " none");
                p.StartInfo = psi;
                p.Start();
                
            }
        }
        public static NetworkInterface GetNicByID(string ID)
        {
            IEnumerable<NetworkInterface> nics = NetworkInterface.GetAllNetworkInterfaces().Where(nw => nw.Id == ID);
            if (nics.Count() > 0)
                return nics.First();
            else
                return null;
        }
        private static ManagementObject GetNicManagementObject(string NicID)
        {
            using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                using (var networkConfigs = networkConfigMng.GetInstances())
                {
                    foreach (ManagementObject managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"] && managementObject["SettingId"].Equals(NicID)))
                    {
                        //there shouldn't be more than one object
                        return managementObject;
                    }
                    //if there is no object which should be unlikely
                    throw new Exception();
                    // return null;
                }
            }
        }

        public static void EnableIpDhcp(string nicName)
        {
            using (ManagementObject managementObject = GetNicManagementObject(nicName))
            {
                ManagementBaseObject enableDHCP = managementObject.InvokeMethod("EnableDHCP", null, null);
            }
        }

        public void EnableDnsDhcp(string nicName)
        {
            using (ManagementObject managementObject = GetNicManagementObject(nicName))
            {
                using (ManagementBaseObject newDNS = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                {
                    newDNS["DNSServerSearchOrder"] = null;
                    ManagementBaseObject setDNS = managementObject.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                }
            }
        }


        public void ReleaseDHCP(string NicID)
        {
            using (ManagementObject mObj = GetNicManagementObject(NicID))
            {
                mObj.InvokeMethod("ReleaseDHCPLease", null, null);
                mObj.InvokeMethod("RenewDHCPLease", null, null);
            }
        }

        public void SetIP(List<IpAddressParam> ipParam, List<GatewayParam> listGateway, string nicName)
        {
            using (ManagementObject managementObject = GetNicManagementObject(nicName))
            {
                using (var newIP = managementObject.GetMethodParameters("EnableStatic"))
                {
                    newIP["IPAddress"] = ipParam.Select(i => i.IpAddress).ToArray();
                    newIP["SubnetMask"] = ipParam.Select(s => s.Subnetmask).ToArray();

                    managementObject.InvokeMethod("EnableStatic", newIP, null);
                    if (listGateway.Count > 0)
                    {
                        using (var newGateway = managementObject.GetMethodParameters("SetGateways"))
                        {
                            newGateway["DefaultIPGateway"] = listGateway.Select(x => x.Gateway).ToArray();
                            newGateway["GatewayCostMetric"] = listGateway.Select(y => y.Metric).ToArray();
                            managementObject.InvokeMethod("SetGateways", newGateway, null);
                        }
                    }
                }
            }
        }


        public void SetNameservers(string NicID, List<string> dnsServers)
        {
            using (ManagementObject managementObject = GetNicManagementObject(NicID))
            {
                using (var newDNS = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                {
                    newDNS["DNSServerSearchOrder"] = dnsServers.ToArray();
                    managementObject.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                }
            }
        }
    }
}
