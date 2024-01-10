namespace StoredProcedure_A01
{
    partial class InsertCustomerIDAndPhone
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
            btnConfirm = new Button();
            txtPhone = new TextBox();
            label2 = new Label();
            txtCustomerID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(197, 35);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(91, 35);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 7;
            label2.Text = "Phone:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(91, 6);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "CustomerID:";
            // 
            // InsertCustomerIDAndPhone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 64);
            Controls.Add(btnConfirm);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtCustomerID);
            Controls.Add(label1);
            Name = "InsertCustomerIDAndPhone";
            Text = "InsertCustomerIDAndPhone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        public TextBox txtPhone;
        private Label label2;
        public TextBox txtCustomerID;
        private Label label1;
    }
}