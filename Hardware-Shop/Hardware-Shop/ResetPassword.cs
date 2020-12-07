using System;
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
    public partial class ResetPassword : Form
    {
        string username = SendCode.to;
        public ResetPassword()

        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResetPass.Text == txtResetPassVerify.Text)
                {
                    SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
                    SqlCommand cmd = new SqlCommand("UPDATE [group4bfa202330].[LoginInfo] SET [User_Password] = '" + txtResetPassVerify.Text + "' WHERE User_Name = '" + username + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Reset successfully");
                }
                else
                {
                    MessageBox.Show("The new password does not match, please re-enter same password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hardware_Shop hs = new Hardware_Shop();
            this.Hide();
            hs.Show();
        }
    }
}
