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
    public partial class PharmaPOS : Form
    {
        public PharmaPOS()
        {
            InitializeComponent();
        }
        POSDBAccess posDBAccess = new POSDBAccess();
     
        //private int id;
        //private string brandname;
        //private string genericname;
        //private string formulation;
        //private double price;
        //private int qty;
        //private double total;
        //private int desiredQuantity;
        //private int getid;


        //public int Id { get => id; set => id = value; }
        //public string Brandname { get => brandname; set => brandname = value; }
        //public string Genericname { get => genericname; set => genericname = value; }
        //public string Formulation { get => formulation; set => formulation = value; }
        //public double Price { get => price; set => price = value; }
        //public int Qty { get => qty; set => qty = value; }
        //public int Getid { get => getid; set => getid = value; }
        //public int DesiredQuantity { get => desiredQuantity; set => desiredQuantity = value; }

        private void button_POS_ProductInquiry_Click(object sender, EventArgs e)
        {

        }

        private void label_POS_Close_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Close();

        }

        private void button_POSProductInquiry_Click(object sender, EventArgs e)
        {
            ViewProductData();
            panel_ProductInquiry.Show();
        }

     
        public void ShowProduct()
        {
            //dataGridView_POS.Rows.Add(id, brandname, genericname, formulation, price, desiredQuantity, price + desiredQuantity);
        }

        private void PharmaPOS_Load(object sender, EventArgs e)
        {
            panel_ProductInquiry.Hide();
            panel_Quantity.Hide();

        }

        private void dataGridView_ProductInquiry_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            panel_ProductInquiry.Hide();
        }
        private void ViewProductData()
        {
            dataGridView_ProductInquiry.Rows.Clear();
            POSDBAccess product = new POSDBAccess();
            DataTable dt = product.ViewPriceInquiry();
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                string id = dt.Rows[index]["itemid"].ToString();
                string brandname = dt.Rows[index]["brandname"].ToString();
                string genericname = dt.Rows[index]["genericname"].ToString();
                string sellingprice = dt.Rows[index]["formulation"].ToString();
                string formulation = dt.Rows[index]["sellingprice"].ToString();
                string quantity = dt.Rows[index]["quantity"].ToString();
                dataGridView_ProductInquiry.Rows.Add(id, brandname, genericname, sellingprice, formulation, quantity);
            }
        }
        private void ViewPOSProduct()
        {
           
            DataTable dt = posDBAccess.ViewPOS();
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                string id = dt.Rows[index]["itemid"].ToString();
                string brandname = dt.Rows[index]["brandname"].ToString();
                string genericname = dt.Rows[index]["genericname"].ToString();
                string formulation = dt.Rows[index]["formulation"].ToString();
                double sellingprice = double.Parse(dt.Rows[index]["price"].ToString());
                int quantity = int.Parse(dt.Rows[index]["quantity"].ToString());
                dataGridView_POS.Rows.Add(id, brandname, genericname, formulation, sellingprice, quantity, sellingprice*quantity);
            }
        }
        private void dataGridView_ProductInquiry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_Quantity.Show();
            textbox_DesiredQuantity.Focus();
            this.AcceptButton = button_AddtoPOS;


        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel_Quantity.Hide();
            textbox_DesiredQuantity.Text = 1.ToString();
        }

        private void button_AddtoPOS_Click(object sender, EventArgs e)
        {

            AddtoPos();

            this.AcceptButton = button_AddtoPOS;
            panel_Quantity.Hide();
            textbox_DesiredQuantity.Text = 1.ToString();

        }
        

        private void AddtoPos()
        {
            posDBAccess.Transactionid = label_POSTransactionID.Text;
            posDBAccess.Brandname = dataGridView_ProductInquiry.CurrentRow.Cells[1].Value.ToString();
            posDBAccess.Genericname = dataGridView_ProductInquiry.CurrentRow.Cells[2].Value.ToString();
            posDBAccess.Formulation = dataGridView_ProductInquiry.CurrentRow.Cells[3].Value.ToString();
            posDBAccess.Price = double.Parse(dataGridView_ProductInquiry.CurrentRow.Cells[4].Value.ToString());
            posDBAccess.DesiredQuantity = int.Parse(textbox_DesiredQuantity.Text.ToString());

            posDBAccess.SaveTransactionTemp();
            dataGridView_POS.Rows.Clear();
            ViewPOSProduct();

            //int id = int.Parse(dataGridView_ProductInquiry.CurrentRow.Cells[0].Value.ToString());
            //string brandname = Brandname = dataGridView_ProductInquiry.CurrentRow.Cells[1].Value.ToString();
            //string genericname = Genericname = dataGridView_ProductInquiry.CurrentRow.Cells[2].Value.ToString();
            //string formulation = Formulation = dataGridView_ProductInquiry.CurrentRow.Cells[3].Value.ToString();
            //double price = Price = double.Parse(dataGridView_ProductInquiry.CurrentRow.Cells[4].Value.ToString());
            //int desiredquantity = DesiredQuantity = int.Parse(textbox_DesiredQuantity.Text.ToString());
            //dataGridView_POS.Rows.Add(id, brandname, genericname, formulation, price, desiredquantity, price * desiredquantity);
            //return true;
        }

        private void ProductIfExist()
        { 
            for(int i = 0; i<dataGridView_POS.Rows.Count; i++)
            {
                if (dataGridView_POS.Rows[i].Cells[0].Value.ToString() == dataGridView_ProductInquiry.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Duplicate");
                }
            }
           
        }
     
        private void dataGridView_POS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_Quantity.Show();
            textbox_DesiredQuantity.Focus();
            this.AcceptButton = button_AddtoPOS;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button_POSNewTransaction_Click(object sender, EventArgs e)
        {
            posDBAccess.AutoGenerateTransactionID();
            label_POSTransactionID.Text = posDBAccess.Transactionid;
            
        }

        private void dataGridView_POS_Paint(object sender, PaintEventArgs e)
        {
            label_BigSubTotal.Text = 12345.ToString();
        }
    }
}
