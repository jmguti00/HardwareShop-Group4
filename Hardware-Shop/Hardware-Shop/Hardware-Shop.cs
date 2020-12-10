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

        private void btnReports_Click(object sender, EventArgs e)
        {
            //hide the Hardware-Shop page
            this.Hide();

            //opens the LoginPage
            ProductInventory invenotry = new ProductInventory();
            invenotry.Show();
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
            string vissionStatment = "We envision reaching every customer in our community excelling with customer service along with providing product delivery on time." +
                                     "\n\nBy 2025 we will: \n" +
                                     "\n* Be in EVERY city" +
                                     "\n* Expand our footprint" +
                                     "\n* Achieve all of our customer’s satisfactions";

            lblInfo.Text = vissionStatment;
        }

        private void btnContactNumbers_Click(object sender, EventArgs e)
        {
            string contactInfo = "Manager: Mike Tyson, Phone Number: (956) 399-0101\n" +
                                 "\nSupervisor: Joe Burrow, Phone Number: (956) 399-0102\n" +
                                 "\nHR Department: Floyd Mayweather Jr., Phone Number: (956) 399-0103\n" +
                                 "\nCustomer Service Phone Number: (956) 399-0104";

            lblInfo.Text = contactInfo;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();

            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
