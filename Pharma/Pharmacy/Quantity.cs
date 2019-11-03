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
    public partial class Quantity : Form
    {
        public Quantity()
        {
            InitializeComponent();
            
        }
        private int id;
        public int Id { get => id; set => id = value; }

        private void button_AddtoPOS_Click(object sender, EventArgs e)
        {
           
        }
    }
}
