using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Doctor_Finder_Windows_App
{
    public partial class SignupFrom : Form
    {
        public SignupFrom()
        {
            InitializeComponent();
        }
       
        private void BtnSignup1_Click(object sender, EventArgs e)
        {
            // Add a new User to Server 

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`( `firstname`, `lastname`, `dateofbirth`, `gender`, `email`, `password`) VALUES (@fn , @ln ,@dob , @gen , @usn ,@pass)",db.getConnection());


            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtFirstName.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = txtLastName.Text;
            command.Parameters.Add("@dob", MySqlDbType.VarChar).Value = toolStripComboBox3.Text;
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtMobileNumber.Text;
            command.Parameters.Add("pass", MySqlDbType.VarChar).Value = txtPassword.Text;

            // Open the Connection
            db.openconnection();
            if (!checktextboxes())
            {
                if (CheckUsername())
                {
                    MessageBox.Show("This Phone Number or Email Address is ALREADY exists Please use a different one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {


                    // execute the query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account Created Successfully","",MessageBoxButtons.OK   ,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please Fill your Form to Continue","Try Again",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            // Close the Connection

            db.closeconnection();


        }
        //Checking if the Username is Already Exists
        public Boolean CheckUsername()
        {
            DB db = new DB();

            string username = txtMobileNumber.Text;
            

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email`=@usn ", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);
            // Here Checking
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        //Checking if Text Boxes contains the default value
        public Boolean checktextboxes()
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string email = txtMobileNumber.Text;
            string dateofbirth = toolStripComboBox3.Text;
            string gender = comboBox1.Text;
            if (fname.Equals("") || lname.Equals("") || email.Equals("") || dateofbirth.Equals("Year") || gender.Equals("Type"))
            {
                return true;
            }
            

            return false;
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
