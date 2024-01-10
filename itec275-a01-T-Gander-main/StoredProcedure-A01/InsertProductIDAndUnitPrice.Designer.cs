namespace StoredProcedure_A01
{
    partial class InsertProductIDAndUnitPrice
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
            label1 = new Label();
            txtProductID = new TextBox();
            txtUnitPrice = new TextBox();
            label2 = new Label();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "ProductID:";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(78, 6);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(100, 23);
            txtProductID.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(78, 35);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(100, 23);
            txtUnitPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Unit Price:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(184, 35);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // InsertProductIDAndUnitPrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 65);
            Controls.Add(btnConfirm);
            Controls.Add(txtUnitPrice);
            Controls.Add(label2);
            Controls.Add(txtProductID);
            Controls.Add(label1);
            Name = "InsertProductIDAndUnitPrice";
            Text = "Update Product Unit Price";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnConfirm;
        public TextBox txtProductID;
        public TextBox txtUnitPrice;
    }
}