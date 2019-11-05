namespace Pharmacy
{
    partial class Quantity
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.textbox_DesiredQuantity = new System.Windows.Forms.TextBox();
            this.button_AddtoPOS = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.textbox_DesiredQuantity);
            this.panel8.Location = new System.Drawing.Point(63, 81);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(203, 131);
            this.panel8.TabIndex = 31;
            // 
            // textbox_DesiredQuantity
            // 
            this.textbox_DesiredQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_DesiredQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_DesiredQuantity.Location = new System.Drawing.Point(-8, 28);
            this.textbox_DesiredQuantity.Name = "textbox_DesiredQuantity";
            this.textbox_DesiredQuantity.Size = new System.Drawing.Size(224, 73);
            this.textbox_DesiredQuantity.TabIndex = 0;
            this.textbox_DesiredQuantity.Text = "0";
            this.textbox_DesiredQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_AddtoPOS
            // 
            this.button_AddtoPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_AddtoPOS.FlatAppearance.BorderSize = 0;
            this.button_AddtoPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddtoPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddtoPOS.ForeColor = System.Drawing.Color.White;
            this.button_AddtoPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddtoPOS.Location = new System.Drawing.Point(63, 219);
            this.button_AddtoPOS.Name = "button_AddtoPOS";
            this.button_AddtoPOS.Size = new System.Drawing.Size(203, 41);
            this.button_AddtoPOS.TabIndex = 32;
            this.button_AddtoPOS.Text = "ADD TO POS";
            this.button_AddtoPOS.UseVisualStyleBackColor = false;
            this.button_AddtoPOS.Click += new System.EventHandler(this.button_AddtoPOS_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Teal;
            this.panel12.Controls.Add(this.panel2);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(339, 66);
            this.panel12.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(440, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 33);
            this.panel2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 16);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "INPUT QUANTITY";
            // 
            // Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 289);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.button_AddtoPOS);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantity";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textbox_DesiredQuantity;
        private System.Windows.Forms.Button button_AddtoPOS;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}