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

        //btnCustomer click event to open LoginPage
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

        //create a public class named user
        public class user
        {
            public string userName { get; set; }
        }

        //btnManager click event to open LoginPage
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

        //btnSupervisor click event to open LoginPage
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            //hide the Hardware-Shop page
            this.Hide();

            //opens the LoginPage
            ProductInvenotry inventory = new ProductInvenotry();
            inventory.Show();
        }

        internal class CrystalReport1
        {
            public CrystalReport1()
            {
            }
        }

        private void btnMissionStatement_Click(object sender, EventArgs e)
        {
            string missionStatment = "\n\n  Our mission is to provide customers " +
                                      "with all their households \n  needs " +
                                      "making it readily available when " +
                                      "they need it the most. ";
            lblInfo.Text = missionStatment;
        }

        private void btnVisionStatement_Click(object sender, EventArgs e)
        {
            string vissionStatment = "We envision reaching every customer in our community excelling with customer service along with providing product delivery on time. By 2025 we will: " +
                                     "\n* Be in EVERY city" +
                                     "\n* Expand our footprint" +
                                     "\n* Achieve all of our customer’s satisfactions";

            lblInfo.Text = vissionStatment;
        }
    }
}
