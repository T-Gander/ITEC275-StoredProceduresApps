namespace StoredProcedure_A01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnSelectCustomersByCustomerID = new Button();
            btnSelectProductsByPriceRange = new Button();
            btnSelectAllOrdersWithDetail = new Button();
            btnInsertOrderForChai = new Button();
            btnUpdateProductUnitPrice = new Button();
            btnUpdateCustomersPhone = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 426);
            dataGridView1.TabIndex = 0;
            // 
            // btnSelectCustomersByCustomerID
            // 
            btnSelectCustomersByCustomerID.Location = new Point(794, 12);
            btnSelectCustomersByCustomerID.Name = "btnSelectCustomersByCustomerID";
            btnSelectCustomersByCustomerID.Size = new Size(146, 23);
            btnSelectCustomersByCustomerID.TabIndex = 1;
            btnSelectCustomersByCustomerID.Text = "Select Customers By ID";
            btnSelectCustomersByCustomerID.UseVisualStyleBackColor = true;
            btnSelectCustomersByCustomerID.Click += btnSelectCustomersByCustomerID_Click;
            // 
            // btnSelectProductsByPriceRange
            // 
            btnSelectProductsByPriceRange.Location = new Point(794, 41);
            btnSelectProductsByPriceRange.Name = "btnSelectProductsByPriceRange";
            btnSelectProductsByPriceRange.Size = new Size(146, 41);
            btnSelectProductsByPriceRange.TabIndex = 2;
            btnSelectProductsByPriceRange.Text = "Select Products By Price Range";
            btnSelectProductsByPriceRange.UseVisualStyleBackColor = true;
            btnSelectProductsByPriceRange.Click += btnSelectProductsByPriceRange_Click;
            // 
            // btnSelectAllOrdersWithDetail
            // 
            btnSelectAllOrdersWithDetail.Location = new Point(794, 88);
            btnSelectAllOrdersWithDetail.Name = "btnSelectAllOrdersWithDetail";
            btnSelectAllOrdersWithDetail.Size = new Size(146, 41);
            btnSelectAllOrdersWithDetail.TabIndex = 3;
            btnSelectAllOrdersWithDetail.Text = "Select All Orders With Detail";
            btnSelectAllOrdersWithDetail.UseVisualStyleBackColor = true;
            btnSelectAllOrdersWithDetail.Click += btnSelectAllOrdersWithDetail_Click;
            // 
            // btnInsertOrderForChai
            // 
            btnInsertOrderForChai.Location = new Point(794, 135);
            btnInsertOrderForChai.Name = "btnInsertOrderForChai";
            btnInsertOrderForChai.Size = new Size(146, 41);
            btnInsertOrderForChai.TabIndex = 4;
            btnInsertOrderForChai.Text = "Insert Order For 10 Chai";
            btnInsertOrderForChai.UseVisualStyleBackColor = true;
            btnInsertOrderForChai.Click += btnInsertOrderForChai_Click;
            // 
            // btnUpdateProductUnitPrice
            // 
            btnUpdateProductUnitPrice.Location = new Point(794, 182);
            btnUpdateProductUnitPrice.Name = "btnUpdateProductUnitPrice";
            btnUpdateProductUnitPrice.Size = new Size(146, 41);
            btnUpdateProductUnitPrice.TabIndex = 5;
            btnUpdateProductUnitPrice.Text = "Update Product Unit Price";
            btnUpdateProductUnitPrice.UseVisualStyleBackColor = true;
            btnUpdateProductUnitPrice.Click += btnUpdateProductUnitPrice_Click;
            // 
            // btnUpdateCustomersPhone
            // 
            btnUpdateCustomersPhone.Location = new Point(794, 229);
            btnUpdateCustomersPhone.Name = "btnUpdateCustomersPhone";
            btnUpdateCustomersPhone.Size = new Size(146, 41);
            btnUpdateCustomersPhone.TabIndex = 6;
            btnUpdateCustomersPhone.Text = "Update Customers Phone";
            btnUpdateCustomersPhone.UseVisualStyleBackColor = true;
            btnUpdateCustomersPhone.Click += btnUpdateCustomersPhone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 450);
            Controls.Add(btnUpdateCustomersPhone);
            Controls.Add(btnUpdateProductUnitPrice);
            Controls.Add(btnInsertOrderForChai);
            Controls.Add(btnSelectAllOrdersWithDetail);
            Controls.Add(btnSelectProductsByPriceRange);
            Controls.Add(btnSelectCustomersByCustomerID);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSelectCustomersByCustomerID;
        private Button btnSelectProductsByPriceRange;
        private Button btnSelectAllOrdersWithDetail;
        private Button btnInsertOrderForChai;
        private Button btnUpdateProductUnitPrice;
        private Button btnUpdateCustomersPhone;
    }
}
