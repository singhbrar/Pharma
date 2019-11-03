using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy
{
     class POSDBAccess
    {
        private SqlCommand cmd;
        private string query;
        private SqlDataAdapter sda;
        private DataTable dt;
        private SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Inventory;Trusted_Connection=True;Integrated Security = true");

        private string transactionid;
        private int id;
        private string brandname;
        private string genericname;
        private string formulation;
        private double price;
        private int desiredQuantity;

        public int Id { get => id; set => id = value; }
        public string Brandname { get => brandname; set => brandname = value; }
        public string Genericname { get => genericname; set => genericname = value; }
        public string Formulation { get => formulation; set => formulation = value; }
        public double Price { get => price; set => price = value; }
        public int DesiredQuantity { get => desiredQuantity; set => desiredQuantity = value; }
        public string Transactionid { get => transactionid; set => transactionid = value; }

        public DataTable ViewPriceInquiry()
        {
            conn.Open();
            query = "select itemID, brandname, genericname, formulation, sellingprice, quantity from item";
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable ViewPOS()
        {
            conn.Open();
            query = "select itemID, brandname, genericname, formulation, price, quantity from postransactiontemp";
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable Get_Item(int itemid)
        {
            conn.Open();
            query = "select * from item where itemid like '"+itemid+"'";
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool SaveTransactionTemp()
        {
            try
            {
                conn.Open();
               // query = "insert into postransactiontemp values("",)";
                query = "insert into postransactiontemp values('" + transactionid + "','" + brandname + "','" + genericname + "','" + formulation + "'," + price + "," + desiredQuantity + ")";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                MessageBox.Show("hey");
                conn.Close();
                return false;
              
            }
        }
        public void AutoGenerateTransactionID()
        {
            conn.Open();
            query = "select count(*) from postransaction";
            cmd = new SqlCommand(query, conn);
            int count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            transactionid = "TRA-" + count.ToString("D10");
            conn.Close();
        }

    }


}
