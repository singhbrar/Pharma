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
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

     

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        

        private void label_Inventory_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage homepage = new Homepage();
            homepage.Show();
        }

       
    }
}
