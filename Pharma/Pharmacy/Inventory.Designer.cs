namespace Pharmacy
{
    partial class Inventory
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
            this.label_Inventory_Close = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Inventory_Delete = new System.Windows.Forms.Button();
            this.button_Inventory_AddProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_Inventory_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 54);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_Inventory_Close
            // 
            this.label_Inventory_Close.AutoSize = true;
            this.label_Inventory_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Inventory_Close.ForeColor = System.Drawing.Color.Black;
            this.label_Inventory_Close.Location = new System.Drawing.Point(1323, 17);
            this.label_Inventory_Close.Name = "label_Inventory_Close";
            this.label_Inventory_Close.Size = new System.Drawing.Size(20, 20);
            this.label_Inventory_Close.TabIndex = 7;
            this.label_Inventory_Close.Text = "X";
            this.label_Inventory_Close.Click += new System.EventHandler(this.label_Inventory_Close_Click);
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
            this.label3.Location = new System.Drawing.Point(33, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "INVENTORY";
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
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 16);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(222, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 555);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.button_Inventory_Delete.Location = new System.Drawing.Point(37, 297);
            this.button_Inventory_Delete.Name = "button_Inventory_Delete";
            this.button_Inventory_Delete.Size = new System.Drawing.Size(164, 63);
            this.button_Inventory_Delete.TabIndex = 7;
            this.button_Inventory_Delete.Text = "            Delete";
            this.button_Inventory_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Inventory_Delete.UseVisualStyleBackColor = false;
            this.button_Inventory_Delete.Click += new System.EventHandler(this.button_Inventory_Delete_Click);
            // 
            // button_Inventory_AddProduct
            // 
            this.button_Inventory_AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Inventory_AddProduct.FlatAppearance.BorderSize = 0;
            this.button_Inventory_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Inventory_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inventory_AddProduct.ForeColor = System.Drawing.Color.White;
            this.button_Inventory_AddProduct.Image = global::Pharmacy.Properties.Resources.inventory_3;
            this.button_Inventory_AddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Inventory_AddProduct.Location = new System.Drawing.Point(36, 159);
            this.button_Inventory_AddProduct.Name = "button_Inventory_AddProduct";
            this.button_Inventory_AddProduct.Size = new System.Drawing.Size(164, 63);
            this.button_Inventory_AddProduct.TabIndex = 6;
            this.button_Inventory_AddProduct.Text = "            Add Product";
            this.button_Inventory_AddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Inventory_AddProduct.UseVisualStyleBackColor = false;
            this.button_Inventory_AddProduct.Click += new System.EventHandler(this.button_Inventory_AddProduct_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Pharmacy.Properties.Resources.inventory_3;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(37, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 63);
            this.button1.TabIndex = 8;
            this.button1.Text = "          Update Product";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Inventory_Delete);
            this.Controls.Add(this.button_Inventory_AddProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 0);
            this.Name = "Inventory";
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
        private System.Windows.Forms.Label label_Inventory_Close;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Inventory_AddProduct;
        private System.Windows.Forms.Button button_Inventory_Delete;
        private System.Windows.Forms.Button button1;
    }
}

