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
            User.userName = "Customer";
            this.Hide();

            LoginPage lp = new LoginPage();
            lp.Show();
        }

        public class user
        {
            public string userName { get; set; }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {

            User.userName = "Manager";
            this.Hide();

            LoginPage lp = new LoginPage();
            lp.Show();
        }
    }
}
