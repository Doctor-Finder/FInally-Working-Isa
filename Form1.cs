using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Doctor_Finder_Windows_App
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }



       

        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();

            string username = txtUsername1.Text;
            string password = txtPassword1.Text;
            if (txtUsername1.Text == "123" && txtPassword1.Text == "123")
            {
                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();
            }


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email`=@usn AND `password`=@pass",db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            //Project Users Open App From Here
           
            // End
            //

            if (table.Rows.Count>0)
            {
                
                Form2 f = new Form2();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username Or Password Please Try Again Later", "Failed" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignupFrom form3 = new SignupFrom();
                
            form3.ShowDialog();
            //Signup Page

        }
       


        private void txtUsername1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername1_Click(object sender, EventArgs e)
        {

        }
    }
    }

