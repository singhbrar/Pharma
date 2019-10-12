namespace Pharmacy
{
    partial class Accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Accounts_Close = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenericName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateArrived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Storage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Inventory_Delete = new System.Windows.Forms.Button();
            this.button_Accounts_AddUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_Accounts_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 54);
            this.panel1.TabIndex = 3;
            // 
            // label_Accounts_Close
            // 
            this.label_Accounts_Close.AutoSize = true;
            this.label_Accounts_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Accounts_Close.ForeColor = System.Drawing.Color.Black;
            this.label_Accounts_Close.Location = new System.Drawing.Point(1323, 17);
            this.label_Accounts_Close.Name = "label_Accounts_Close";
            this.label_Accounts_Close.Size = new System.Drawing.Size(20, 20);
            this.label_Accounts_Close.TabIndex = 7;
            this.label_Accounts_Close.Text = "X";
            this.label_Accounts_Close.Click += new System.EventHandler(this.label_Accounts_Close_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Teal;
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.label2);
            this.panel12.Controls.Add(this.panel2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 54);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1366, 66);
            this.panel12.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "USER ACCOUNTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(925, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "SEARCH:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(998, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 33);
            this.panel2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 16);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.BrandName,
            this.GenericName,
            this.ExpiryDate,
            this.DateArrived,
            this.PurchasedPrice,
            this.SellingPrice,
            this.BatchNumber,
            this.Storage,
            this.Quantity});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(222, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 555);
            this.dataGridView1.TabIndex = 5;
            // 
            // ItemId
            // 
            this.ItemId.HeaderText = "Item ID";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            // 
            // BrandName
            // 
            this.BrandName.HeaderText = "Brand Name";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            // 
            // GenericName
            // 
            this.GenericName.HeaderText = "Generic Name";
            this.GenericName.Name = "GenericName";
            this.GenericName.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "Expiry Date";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // DateArrived
            // 
            this.DateArrived.HeaderText = "Date Arrived";
            this.DateArrived.Name = "DateArrived";
            this.DateArrived.ReadOnly = true;
            // 
            // PurchasedPrice
            // 
            this.PurchasedPrice.HeaderText = "Purchased Price";
            this.PurchasedPrice.Name = "PurchasedPrice";
            this.PurchasedPrice.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "Batch Number";
            this.BatchNumber.Name = "BatchNumber";
            this.BatchNumber.ReadOnly = true;
            // 
            // Storage
            // 
            this.Storage.HeaderText = "Storage";
            this.Storage.Name = "Storage";
            this.Storage.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // button_Inventory_Delete
            // 
            this.button_Inventory_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Inventory_Delete.FlatAppearance.BorderSize = 0;
            this.button_Inventory_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Inventory_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inventory_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Inventory_Delete.Image = global::Pharmacy.Properties.Resources.inventory_3;
            this.button_Inventory_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Inventory_Delete.Location = new System.Drawing.Point(36, 228);
            this.button_Inventory_Delete.Name = "button_Inventory_Delete";
            this.button_Inventory_Delete.Size = new System.Drawing.Size(164, 63);
            this.button_Inventory_Delete.TabIndex = 7;
            this.button_Inventory_Delete.Text = "            Delete";
            this.button_Inventory_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Inventory_Delete.UseVisualStyleBackColor = false;
            // 
            // button_Accounts_AddUser
            // 
            this.button_Accounts_AddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Accounts_AddUser.FlatAppearance.BorderSize = 0;
            this.button_Accounts_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Accounts_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Accounts_AddUser.ForeColor = System.Drawing.Color.White;
            this.button_Accounts_AddUser.Image = global::Pharmacy.Properties.Resources.inventory_3;
            this.button_Accounts_AddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Accounts_AddUser.Location = new System.Drawing.Point(36, 159);
            this.button_Accounts_AddUser.Name = "button_Accounts_AddUser";
            this.button_Accounts_AddUser.Size = new System.Drawing.Size(164, 63);
            this.button_Accounts_AddUser.TabIndex = 6;
            this.button_Accounts_AddUser.Text = "            Add User";
            this.button_Accounts_AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Accounts_AddUser.UseVisualStyleBackColor = false;
            this.button_Accounts_AddUser.Click += new System.EventHandler(this.button_Accounts_AddUser_Click);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button_Inventory_Delete);
            this.Controls.Add(this.button_Accounts_AddUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 0);
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Accounts_Close;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Accounts_AddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenericName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateArrived;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Storage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button button_Inventory_Delete;
    }
}

