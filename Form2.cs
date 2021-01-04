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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnSurgeon_Click(object sender, EventArgs e)
        {
            SurgeonForm sf = new SurgeonForm();
            this.Hide();
            sf.ShowDialog();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            GeneralForm gf = new GeneralForm();
            this.Hide();
            gf.ShowDialog();

        }

        private void btnRadiologist_Click(object sender, EventArgs e)
        {
            RadiologistForm rf = new RadiologistForm();
            this.Hide();
            rf.ShowDialog();
        }

        

       

        private void btnInternist_Click(object sender, EventArgs e)
        {
            InternhistForm inf = new InternhistForm();
            this.Hide();
            inf.ShowDialog();
        }

        

        private void btnPediatrician_Click_1(object sender, EventArgs e)
        {
            PediatricianForm pf = new PediatricianForm();
            this.Hide();
            pf.ShowDialog();
        }

        private void btnOptometrist_Click_1(object sender, EventArgs e)
        {
            OptometristForm of = new OptometristForm();
            this.Hide();
            of.ShowDialog();
        }

        private void btnDentist_Click_1(object sender, EventArgs e)
        {
            DentistForm df = new DentistForm();
            this.Hide();
            df.ShowDialog();
        }

        private void btnRadiologist_Click_1(object sender, EventArgs e)
        {
            RadiologistForm rf = new RadiologistForm();
            this.Hide();
            rf.ShowDialog();
        }
    }
}
