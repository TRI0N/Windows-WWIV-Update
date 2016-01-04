/**************************************************************************/
/*                                                                        */
/*                              WWIV Version 5.x                          */
/*             Copyright © 2014-2016 WWIV Software Services               */
/*                                                                        */
/*    Licensed  under the  Apache License, Version  2.0 (the "License");  */
/*    you may not use this  file  except in compliance with the License.  */
/*    You may obtain a copy of the License at                             */
/*                                                                        */
/*                http://www.apache.org/licenses/LICENSE-2.0              */
/*                                                                        */
/*    Unless  required  by  applicable  law  or agreed to  in  writing,   */
/*    software  distributed  under  the  License  is  distributed on an   */
/*    "AS IS"  BASIS, WITHOUT  WARRANTIES  OR  CONDITIONS OF ANY  KIND,   */
/*    either  express  or implied.  See  the  License for  the specific   */
/*    language governing permissions and limitations under the License.   */
/*                                                                        */
/**************************************************************************/
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace windows_wwiv_update
{
    public partial class Form2 : Form
    {
        public Form2(string fetchVersion)
        {
            InitializeComponent();
            label2.Text = fetchVersion;

            // Update UI Cosmetics
            spinStatus.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            updateComplete.Visible = false;

            // Check For Running Instances Of WWIV Programs
            if (Process.GetProcessesByName("bbs").Length >= 1)
            {
                wwivStatus.ForeColor = System.Drawing.Color.Red;
                wwivStatus.Text = "ONLINE";
            }
            else
            {
                wwivStatus.ForeColor = System.Drawing.Color.Green;
                wwivStatus.Text = "OFFLINE";
            }
            if (Process.GetProcessesByName("WWIV5TelnetServer").Length >= 1)
            {
                telnetStatus.ForeColor = System.Drawing.Color.Red;
                telnetStatus.Text = "ONLINE";
            }
            else
            {
                telnetStatus.ForeColor = System.Drawing.Color.Green;
                telnetStatus.Text = "OFFLINE";
            }
            if (Process.GetProcessesByName("networkb").Length >= 1)
            {
                netStatus.ForeColor = System.Drawing.Color.Red;
                netStatus.Text = "ONLINE";
            }
            else
            {
                netStatus.ForeColor = System.Drawing.Color.Green;
                netStatus.Text = "OFFLINE";
            }
            if (wwivStatus.Text != "OFFLINE" || netStatus.Text != "OFFLINE" || telnetStatus.Text != "OFFLINE")
            {
                button2.Enabled = false;
                infoStatus.ForeColor = System.Drawing.Color.Red;
                infoStatus.Text = "All Systems Must Be Offline Before Update!";
            }
            else
            {
                button1.Enabled = false;
                infoStatus.ForeColor = System.Drawing.Color.Green;
                infoStatus.Text = "All Systems Are Offline... Ready To Update!";
            }
        }

        // Restart Button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Update WWIV Button
        private async void button2_Click(object sender, EventArgs e)
        {
            // Update UI Cosmetics
            string fetchVersion;
            fetchVersion = label2.Text;
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            spinStatus.Visible = true;

            // Sleep for 2 Seconds For UI To Build
            await Task.Delay(2000);

            // Make Sure Build Number Is NOT Null
            if (fetchVersion != null)
            {
                // Set Global Variables For Update
                string backupPath = @"C:\wwiv";
                string zipPath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Documents\" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + "_wwiv-backup.zip";
                string extractPath = @"C:\wwiv";
                string extractPath2 = Environment.GetEnvironmentVariable("SystemRoot") + @"\System32";
                string remoteUri = "http://build.wwivbbs.org/jenkins/job/wwiv/" + fetchVersion + "/label=windows/artifact/";
                string fileName = "wwiv-build-win-" + fetchVersion + ".zip", myStringWebResource = null;
                string updatePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads\wwiv-build-win-" + fetchVersion + ".zip";

                // Begin WWIV Backup
                ZipFile.CreateFromDirectory(backupPath, zipPath);

                // Fetch Latest Sucessful Build
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads\" + fileName);

                // Patch Existing WWIV Install
                using (ZipArchive archive = ZipFile.OpenRead(updatePath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        if (entry.FullName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
                        {
                            entry.ExtractToFile(Path.Combine(extractPath, entry.FullName), true);
                        }
                        if (entry.FullName.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
                        {
                            entry.ExtractToFile(Path.Combine(extractPath, entry.FullName), true);
                        }
                        if (entry.FullName.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
                        {
                            entry.ExtractToFile(Path.Combine(extractPath2, entry.FullName), true);
                        }
                    }
                }

                // Update Complete
                spinStatus.Visible = false;
                updateComplete.ForeColor = System.Drawing.Color.Green;
                updateComplete.Text = "WWIV 5 Build " + fetchVersion + " Is Complete!";

                // Update UI Cosmetics
                updateComplete.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }
        }

        // Launch WWIV With Network Button
        private void button4_Click(object sender, EventArgs e)
        {
            // Launch WWIV, WWIVnet and Latest Changes in Browser.
            string fetchVersion;
            fetchVersion = label2.Text;
            string wwivChanges = "http://build.wwivbbs.org/jenkins/job/wwiv/" + fetchVersion + "/label=windows/changes";
            Environment.CurrentDirectory = @"C:\wwiv";

            // Launch Telnet Server
            ProcessStartInfo telNet = new ProcessStartInfo("WWIV5TelnetServer.exe");
            telNet.WindowStyle = ProcessWindowStyle.Minimized;
            Process.Start(telNet);

            // Launch binkp.cmd for WWIVnet
            ProcessStartInfo binkP = new ProcessStartInfo("binkp.cmd");
            binkP.WindowStyle = ProcessWindowStyle.Minimized;
            Process.Start(binkP);

            // Launch Latest Realse Changes into Default Browser
            Process.Start(wwivChanges);

            // Exit Application
            Application.Exit();
        }

        // Launch WWIV Without Network Button
        private void button3_Click(object sender, EventArgs e)
        {
            // Launch WWIV, WWIVnet and Latest Changes in Browser.
            string fetchVersion;
            fetchVersion = label2.Text;
            string wwivChanges = "http://build.wwivbbs.org/jenkins/job/wwiv/" + fetchVersion + "/label=windows/changes";
            Environment.CurrentDirectory = @"C:\wwiv";

            // Launch Telnet Server
            ProcessStartInfo telNet = new ProcessStartInfo("WWIV5TelnetServer.exe");
            telNet.WindowStyle = ProcessWindowStyle.Minimized;
            Process.Start(telNet);

            // Launch Latest Realse Changes into Default Browser
            Process.Start(wwivChanges);

            // Exit Application
            Application.Exit();
        }

        // Exit Program Button
        private void button5_Click(object sender, EventArgs e)
        {
            // Exit Application
            Application.Exit();
        }
    }
}
