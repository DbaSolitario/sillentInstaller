using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sillentInstaller
{
    public partial class silentInstallerByLink : MetroFramework.Forms.MetroForm
    {
        public silentInstallerByLink()
        {
            InitializeComponent();
            //RunInstall( @"C:\npp.7.9.3.Installer.exe");
            //GetSubDirectories(@"C:\Softwares");
        }

        public void GetSubDirectories(string mainFolder)

        {
            try
            {
                string root = mainFolder;

                // Get all subdirectories

                string[] subdirectoryEntries = Directory.GetDirectories(root);

                // Loop through them to see if they have any other subdirectories

                foreach (string subdirectory in subdirectoryEntries)

                    LoadSubDirs(subdirectory);
            }
            catch(System.IO.DirectoryNotFoundException eIO)
            {
                MessageBox.Show("Directory Not Found", "DIR error", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
            }
            catch (Exception e)
            {
                MessageBox.Show("Runtime error " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void LoadSubDirs(string dir)

        {
            try
            {
                string[] subdirectoryEntries = Directory.GetDirectories(dir);
                DirectoryInfo d = new DirectoryInfo(dir);
                FileInfo[] Files = d.GetFiles("*.exe");
                if (Files.Length > 0)
                {
                    foreach (FileInfo file in Files)
                    {
                        lstPrograms.Items.Add(dir + @"\" + file);
                    }
                }

                foreach (var subdirectory in subdirectoryEntries)
                {
                    LoadSubDirs(subdirectory);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public void RunInstall(string appPath)
        {
            try
            {
                Console.WriteLine("Starting to install application");
                Process process = new Process();
                process.StartInfo.FileName = appPath;
                process.StartInfo.Arguments = string.Format(" /quiet /i ALLUSERS=1");
                process.Start();
                process.WaitForExit();
                Console.WriteLine("Application installed successfully! " + appPath);
                //return (appPath);
                lstInstalled.Items.Add(appPath);
                //return true; //Return True if process ended successfully
            }
            catch(Exception e)
            {
                Console.WriteLine("There was a problem installing the application! " + e.Message);
                //return "Error";
                //return false;  //Return False if process ended unsuccessfully
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            lstInstalled.Items.Clear();
            for (int i = 0; i < lstPrograms.Items.Count; i++)
            {
                if (lstPrograms.GetItemChecked(i))
                {
                    RunInstall((string)lstPrograms.Items[i]);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDir.Text))
            {
                lstPrograms.Items.Clear();
                lstInstalled.Items.Clear();
                GetSubDirectories(txtDir.Text);
            }
        }
    }
}
