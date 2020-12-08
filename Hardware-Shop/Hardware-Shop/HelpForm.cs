using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hardware_Shop
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            TextReader reader = new StreamReader(@"C:\Users\julia\OneDrive\Desktop\Test Program\Hardware-Shop\Help Document.txt");

            richTextBox1.Text = reader.ReadToEnd();

            reader.Close();


        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            Hardware_Shop hs = new Hardware_Shop();
            hs.Show();
        }
    }
}
