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
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();

            lblOrderFor.Text = CustomerPage.newCustomer.ToString();
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnToolsAccessories_Click(object sender, EventArgs e)
        {
            ToolsAndAccessories TaA = new ToolsAndAccessories();
            TaA.Show();
            this.Hide();
        }

        private void btnHomeReno_Click(object sender, EventArgs e)
        {
            HomeRenovations homeRenovations = new HomeRenovations();
            homeRenovations.Show();
            this.Hide();
        }

        private void btnLawnGarden_Click(object sender, EventArgs e)
        {
            LawnAndGarden lawnAndGarden = new LawnAndGarden();
            lawnAndGarden.Show();
            this.Hide();
        }

        private void btnBuildingConstruction_Click(object sender, EventArgs e)
        {
            BuildingAndConstuction BaC = new BuildingAndConstuction();
            BaC.Show();
            this.Hide();
        }

        private void btnReturnToCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPage cp = new CustomerPage();
            cp.Show();
        }
    }
}
