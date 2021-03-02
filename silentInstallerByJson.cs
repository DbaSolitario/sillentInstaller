using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sillentInstaller
{
    public partial class silentInstallerByJson : Form
    {
        public silentInstallerByJson()
        {
            InitializeComponent();
        }


        private void silentInstallerByJson_Load(object sender, EventArgs e)
        {
            int width = this.Width;
            int heigth = this.Height;
            int lastWidth = 30;
            int lastHeigth = 30;

            using (StreamReader r = new StreamReader("config.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array.APPS)
                {

                    CheckBox chk = new CheckBox();
                    chk.Text = item.name;
                    chk.Location = new System.Drawing.Point( lastWidth, lastHeigth);
                    chk.MaximumSize = new Size(100,100);
                    this.Controls.Add(chk);
                    lastWidth += 100;
                    if(lastWidth >= width)
                    {
                        lastHeigth += 30;
                        lastWidth = 30;
                    }
                        
                    
                   
                }

            }
           
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            dynamic array;
            using (StreamReader r = new StreamReader("config.json"))
            {
                string json = r.ReadToEnd();
                array = JsonConvert.DeserializeObject(json);

            }
            

            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked )
                    {
                        foreach(var item in array.APPS)
                        {
                            if(item.name == cb.Text)
                            {
                                Console.WriteLine(item.url);
                                break;
                            }
                        }
                        Console.WriteLine(cb.Text);
                    }
                    
                }
            }
        }
    }
}
