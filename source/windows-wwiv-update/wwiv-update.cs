﻿/**************************************************************************/
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
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;

namespace windows_wwiv_update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Declare and Initilize Set Build Number Variables to 0
            string wwivBuild5_1 = "0";
            string wwivBuild5_0 = "0";

            // Fetch Latest Build Number For WWIV 5.1
            WebClient wc = new WebClient();
            string htmlString1 = wc.DownloadString("http://build.wwivbbs.org/jenkins/job/wwiv/lastSuccessfulBuild/label=windows/");
            Match mTitle1 = Regex.Match(htmlString1, "(?:number.*?>)(?<buildNumber1>.*?)(?:<)");
            // Fetch Latest Build Number For WWIV 5.0
            string htmlString2 = wc.DownloadString("https://build.wwivbbs.org/jenkins/job/wwiv_5.0.0/lastSuccessfulBuild/label=windows/");
            Match mTitle2 = Regex.Match(htmlString2, "(?:number.*?>)(?<buildNumber2>.*?)(?:<)");
            {
                wwivBuild5_1 = mTitle1.Groups[1].Value;
                wwivBuild5_0 = mTitle2.Groups[1].Value;
            }
            version51.Text = wwivBuild5_1;
            version50.Text = wwivBuild5_0;
        }

        // Update to Newest WWIV 5.1
        private void update51_Click(object sender, EventArgs e)
        {
            string updateToNew51;
            updateToNew51 = version51.Text;
            if (updateToNew51 == null || string.IsNullOrWhiteSpace(updateToNew51))
            {
                if (MessageBox.Show("Error! Build Server Unavailable.", "Build Server Down", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    // User Clicked Retry
                    Application.Restart();
                }
                else
                {
                    // User Clicked Cancel
                    Application.Exit();
                }
            }
            else
            {
                // Begin Update 51
                string fetchVersion = updateToNew51;
                this.Hide();
                Form2 frm = new Form2(fetchVersion);
                frm.ShowDialog();
                this.Close();
            }
        }

        // Update to Newest WWIV 5.0
        private void update50_Click(object sender, EventArgs e)
        {
            string updateToNew50;
            updateToNew50 = version50.Text;
            if (updateToNew50 == null || string.IsNullOrWhiteSpace(updateToNew50))
            {
                if (MessageBox.Show("Error! Build Server Unavailable.", "Build Server Down", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    // User Clicked Retry
                    Application.Restart();
                }
                else
                {
                    // User Clicked Cancel
                    Application.Exit();
                }
            }
            else
            {
                // Begin Update 50
                string fetchVersion = updateToNew50;
                this.Hide();
                Form2 frm = new Form2(fetchVersion);
                frm.ShowDialog();
                this.Close();
            }
        }

        // Update to User Defined WWIV 5.x
        private void customUpdate_Click(object sender, EventArgs e)
        {
            const int MinLength = 4;
            string customBuildNumber;
            customBuildNumber = customBuild.Text;
            if (customBuildNumber == null || string.IsNullOrWhiteSpace(customBuildNumber) || customBuildNumber.Length < MinLength)
            {
                MessageBox.Show("Please Enter A Valid Build Number.", "Build Number Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Begin Update Custom Build
                string fetchVersion = customBuildNumber;
                this.Hide();
                Form2 frm = new Form2(fetchVersion);
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
