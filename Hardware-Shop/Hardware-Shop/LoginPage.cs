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
            this.Hide();
            SendCode sc = new SendCode();
            sc.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM group4bfa202330.LoginInfo WHERE User_Name = '" + txtUserName.Text + "' and User_Password = '" + txtPassword.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Login successfully");

                    if (Hardware_Shop.User.userName == "Customer" && txtUserName.Text == "employee")
                    {
                        MessageBox.Show("Login successfully");

                        this.Hide();

                        CustomerPage cp = new CustomerPage();
                        cp.Show();
                    }
                    else if (Hardware_Shop.User.userName == "Manager" && txtUserName.Text =="manager")
                    {
                        MessageBox.Show("Login successfully");

                        this.Hide();

                        Add_Product_And_Picture addProductPicture = new Add_Product_And_Picture();
                        addProductPicture.Show();
                    }
                    else if (Hardware_Shop.User.userName == "Supervisor" && txtUserName.Text == "supervisor")
                    {
                        MessageBox.Show("Login successfully");

                        this.Hide();

                        EmployeePage ep = new EmployeePage();
                        ep.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password or user ID");
                    }

                }
                else
                {
                    MessageBox.Show("Wrong password or user ID");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hardware_Shop hs = new Hardware_Shop();
            hs.Show();
        }
    }
}
