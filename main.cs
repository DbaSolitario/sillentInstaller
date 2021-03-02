using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sillentInstaller
{
    public partial class main : MetroFramework.Forms.MetroForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            silentInstallerByJson json = new silentInstallerByJson();
            json.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            silentInstallerByLink link = new silentInstallerByLink();
            link.ShowDialog();
        }
    }
}
