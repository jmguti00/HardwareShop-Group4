using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Shop
{
    public partial class Hardware_Shop : Form
    {
        public static user User = new user();

        public Hardware_Shop()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //assigns Customer to User.userName
            User.userName = "Customer";

            //hide the Hardware-Shop page
            this.Hide();

            //opens the LoginPage
            LoginPage lp = new LoginPage();
            lp.Show();
        }

        public class user
        {
            public string userName { get; set; }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            //assigns Manager to User.userName
            User.userName = "Manager";
            
            //hide the Hardware-Shop page
            this.Hide();

            //opens the LoginPage
            LoginPage lp = new LoginPage();
            lp.Show();
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            //assigns Supervisor to User.userName
            User.userName = "Supervisor";

            //hide the Hardware-Shop page
            this.Hide();

            //opens the LoginPage
            LoginPage lp = new LoginPage();
            lp.Show();
        }
    }
}
