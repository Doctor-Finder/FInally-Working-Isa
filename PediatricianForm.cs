using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_Finder_Windows_App
{
    public partial class PediatricianForm : Form
    {
        public PediatricianForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table t = new table();
            this.Hide();
            t.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table t = new table();
            this.Hide();
            t.Show();
        }
    }
}
