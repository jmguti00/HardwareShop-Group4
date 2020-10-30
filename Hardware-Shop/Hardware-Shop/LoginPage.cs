﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hardware_Shop
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            SendCode sc = new SendCode();
            this.Hide();
            sc.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BNB45KS\\MSSQLSERVER1;Initial Catalog=HandyHardwareShop;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM group4.LoginInfo WHERE ID = '" + txtID.Text + "' and Password = '" + txtPassword.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successfully");

                    this.Hide();

                    CustomerPage cp = new CustomerPage();
                    cp.Show();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}