﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeLogin_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnHomeSignup_Click(object sender, EventArgs e)
        {
            SignupFrom s = new SignupFrom();
            this.Hide();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnReadMore_Click(object sender, EventArgs e)
        {
            DashboardForm.WelcomeForm f = new DashboardForm.WelcomeForm();
            this.Hide();
            f.Show();
        }

        private void btnHomeContactUs_Click(object sender, EventArgs e)
        {
            DashboardForm.ContactusForm c = new DashboardForm.ContactusForm();
            this.Hide();
            c.Show();

        }
    }
}
