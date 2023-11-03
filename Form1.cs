using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Windows;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;

namespace UProject
{
    public partial class Form1 : Form
    {
        int i;
        int j;
        int k;

        string[] electro = { "78.157.42.100", "78.157.42.101" };
        string[] shecan = { "178.22.122.100", "185.51.200.2" };
        string[] radar = { "10.202.10.10", "10.202.10.11" };
        string[] charsadse = { "10.202.10.202", "10.202.10.102" };
        string[] google = { "8.8.8.8", "8.8.4.4" };
        string[] cloudflare = { "1.1.1.1", "1.0.0.1" };
        string[] opendns = { "208.67.222.222", "208.67.220.220" };
        string[] quad9 = { "9.9.9.9", "149.112.112.112" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btntaklol_Click(object sender, EventArgs e)
        {
            flush();
            btncolorred();
            if (i % 2 == 0)
                {
                    try
                    {
                        string Takon = "142.251.214.142 google.com\r\n142.251.214.142 www.google.com\r\n99.86.249.52 d392eissrffsyf.cloudfront.net\r\n13.227.171.80 d28xe8vt774jo5.cloudfront.net\r\n188.34.189.154 eu.vg.ac.pvp.net\r\n162.55.170.151 ap.vg.ac.pvp.net\r\n23.88.123.180 na.vg.ac.pvp.net\r\n148.251.160.254 pd.eu.a.pvp.net\r\n148.251.160.254 shared.eu.a.pvp.net\r\n2.16.107.96 wildrift.secure.dyn.riotcdn.net\r\n172.217.16.150 i.ytimg.com\r\n185.207.107.146 lolstatic-a.akamaihd.net\r\n148.251.160.254 glz-eu-1.eu.a.pvp.net\r\n148.251.160.254 euc.pp.riotgames.com\r\n188.34.182.50 gew-spclient.spotify.com\r\n148.251.160.254 data.riotgames.com\r\n162.55.42.221 eu.mm.among.us\r\n162.55.42.221 as.mm.among.us\r\n162.55.42.221 na.mm.among.us\r\n23.88.123.180 s2s.adjust.com\r\n148.251.160.254 insights-collector.newrelic.com\r\n148.251.160.254 metric-api.newrelic.com\r\n2.16.107.96 riot-client.secure.dyn.riotcdn.net\r\n20.72.192.30 lonelyfish.intlgame.com\r\n20.72.192.30 lonelyfish-pass.intlgame.com\r\n148.251.160.254 clientconfig.rpg.riotgames.com\r\n52.143.83.243 lonelyfish-dr.intlgame.com\r\n2.16.107.96 lol.secure.dyn.riotcdn.net\r\n148.251.160.254 usw.pp.riotgames.com\r\n148.251.160.254 sieve.services.riotcdn.net\r\n23.88.123.180 azevm7mcof9i3-ats.iot.us-east-1.amazonaws.com\r\n188.34.182.50 api.spotify.com\r\n188.34.189.154 glz-na-1.na.a.pvp.net\r\n2.16.107.96 riot-client.dyn.riotcdn.net\r\n208.110.86.67 auth.riotgames.com\r\n162.62.70.224 mgl.lobby.igamecj.com\r\n148.251.160.254 riot-geo.pas.si.riotgames.com\r\n188.34.182.50 api-partner.spotify.com\r\n148.251.160.254 static.xx.fbcdn.net\r\n23.196.216.57 origin.warframe.com\r\n205.185.216.42 content.warframe.com\r\n2.16.107.96 ks-foundation.secure.dyn.riotcdn.net\r\n104.26.1.182 warframe.market\r\n188.34.189.154 pd.na.a.pvp.net\r\n2.16.107.96 valorant.secure.dyn.riotcdn.net\r\n101.32.112.172 mgl.public.igamecj.com\r\n188.34.189.154 riot-geo.vts.si.riotgames.com\r\n188.34.189.154 shared.ap.a.pvp.net\r\n208.110.86.67 entitlements.auth.riotgames.com\r\n58.251.106.185 masterconn11.qq.com\r\n188.34.182.50 gew1-spclient.spotify.com\r\n2.16.107.96 bacon.secure.dyn.riotcdn.net\r\n49.51.131.79 unifiedaccess.gameloop.com\r\n188.34.189.154 notify.xboxlive.com\r\n23.88.123.180 service.maestro.us-east-1.social.games.a2z.com\r\n104.17.165.5 pft.leagueoflegends.com\r\n104.16.200.67 euw.store.leagueoflegends.com\r\n104.18.182.64 eun.store.leagueoflegends.com\r\n104.18.182.64 na.store.leagueoflegends.com\r\n104.16.200.67 tr.store.leagueoflegends.com\r\n188.34.189.154 glz-ap-1.ap.a.pvp.net\r\n148.251.160.254 shared.na.a.pvp.net\r\n188.34.182.50 spclient.wg.spotify.com\r\n188.34.189.154 pd.ap.a.pvp.net\r\n157.240.214.1 graph.facebook.com\r\n148.251.160.254 apse.pp.riotgames.com\r\n58.251.106.185 master.etl.desktop.qq.com\r\n148.251.160.254 playerpreferences.riotgames.com\r\n162.159.137.232 discord.com\r\n52.219.74.123 s3.eu-central-1.amazonaws.com\r\n49.51.230.43 steamdir3.ringofelysium.com\r\n49.51.228.124 steamdir6.ringofelysium.com\r\n49.51.232.37 steamdir9.ringofelysium.com\r\n162.62.70.106 lobby.igamecj.com\r\n162.62.115.68 public.igamecj.com\r\n148.251.160.254 xsts.auth.xboxlive.com\r\n";
                        File.WriteAllText("C:\\Windows\\System32\\drivers\\etc\\hosts", Takon);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Run Program as Administrator", "Administrator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    btntaklol.BackColor = Color.LightGreen;
                }
                else if (i % 2 == 1)
                {
                    try
                    {
                        string Takoff = "";
                        File.WriteAllText("C:\\Windows\\System32\\drivers\\etc\\hosts", Takoff);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Run Program as Administrator", "Administrator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    btntaklol.BackColor = Color.MediumVioletRed;
                }
                i++;
        }

        private void btnelectro_Click(object sender, EventArgs e)
        {
            flush();
            btncolorred();
            if (j % 2 == 0)
                {
                    try
                    {
                        DNSManager.SetDNS("78.157.42.100", "78.157.42.101");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Run Program as Administrator", "Administrator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    btnelectro.BackColor = Color.LightGreen;
                }
                else if (j % 2 == 1)
                {
                    try
                    {
                        UnsetDNS();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Run Program as Administrator", "Administrator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    btnelectro.BackColor = Color.MediumVioletRed;
                }
                j++;
        }

        private void btnshecan_Click(object sender, EventArgs e)
        {
            flush();
            btncolorred();
            if (k % 2 == 0)
                {
                    try
                    {
                        SetDNS("178.22.122.100");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Run Program as Administrator", "Administrator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    btnshecan.BackColor = Color.LightGreen;
                }
                else if (k % 2 == 1)
                {
                    try
                    {
                        UnsetDNS();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Run Program as Administrator", "Administrator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    btnshecan.BackColor = Color.MediumVioletRed;
                }
                k++;
        }

        private void btnradar_Click(object sender, EventArgs e)
        {

        }

        private void btn403_Click(object sender, EventArgs e)
        {

        }

        private void btngoogle_Click(object sender, EventArgs e)
        {

        }

        private void btncloudflare_Click(object sender, EventArgs e)
        {

        }

        private void btnopendns_Click(object sender, EventArgs e)
        {

        }

        private void btnquad9_Click(object sender, EventArgs e)
        {

        }

        private void cusdnsbtn_Click(object sender, EventArgs e)
        {
            flush();
            try
            {
                SetDNS(cusdnstxt1.Text);
                MessageBox.Show("your dns" + cusdnstxt1.Text + "has been set");
            }
            catch (Exception)
            {
                MessageBox.Show("Please Run Program as Administrator", "Administrator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Unset_Click(object sender, EventArgs e)
        {
            try
            {
                flush();
                MessageBox.Show("DNS catch removed");
            }
            catch (Exception)
            {
                MessageBox.Show("Please Run Program as Administrator", "Administrator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public static void flush()
        {
            UnsetDNS();
            File.WriteAllText("C:\\Windows\\System32\\drivers\\etc\\hosts", "");
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ipconfig /flushdns";
            process.StartInfo = startInfo;
            process.Start();
        }

        public void btncolorred()
        {
            btnshecan.BackColor = Color.MediumVioletRed;
            btnelectro.BackColor = Color.MediumVioletRed;
            btntaklol.BackColor = Color.MediumVioletRed;
            btngoogle.BackColor = Color.MediumVioletRed;
            btn403.BackColor = Color.MediumVioletRed;
            btnradar.BackColor = Color.MediumVioletRed;
            btnquad9.BackColor = Color.MediumVioletRed;
            btnopendns.BackColor = Color.MediumVioletRed;
            btncloudflare.BackColor = Color.MediumVioletRed;
        }

        class DNSManager
        {
            // A method to get the active network interface
            public static NetworkInterface GetActiveNetworkInterface()
            {
                var nic = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
                    a => a.OperationalStatus == OperationalStatus.Up &&
                    (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
                    a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork"));

                return nic;
            }

            // A method to set the primary and alternative DNS address of a given network interface
            public static void SetDNS(NetworkInterface ni, string primaryDNS, string alternativeDNS)
            {
                if (ni == null) return;

                ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection objMOC = objMC.GetInstances();

                foreach (ManagementObject objMO in objMOC)
                {
                    if ((bool)objMO["IPEnabled"])
                    {
                        if (objMO["Caption"].ToString().Contains(ni.Description))
                        {
                            ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                            if (objdns != null)
                            {
                                objdns["DNSServerSearchOrder"] = new string[] { primaryDNS, alternativeDNS };
                                objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                            }
                        }
                    }
                }
            }

            // A method to unset the DNS address of a given network interface
            public static void UnsetDNS(NetworkInterface ni)
            {
                if (ni == null) return;

                ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection objMOC = objMC.GetInstances();

                foreach (ManagementObject objMO in objMOC)
                {
                    if ((bool)objMO["IPEnabled"])
                    {
                        if (objMO["Caption"].ToString().Contains(ni.Description))
                        {
                            ManagementBaseObject objdns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                            if (objdns != null)
                            {
                                objdns["DNSServerSearchOrder"] = null;
                                objMO.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                            }
                        }
                    }
                }
            }
        }
    }
}
