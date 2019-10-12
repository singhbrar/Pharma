using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

     

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Inventory_AddProduct_Click(object sender, EventArgs e)
        {
            Add_Product add_product = new Add_Product();
            add_product.Show();

        }

        private void label_Inventory_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage homepage = new Homepage();
            homepage.Show();
        }
    }
}
