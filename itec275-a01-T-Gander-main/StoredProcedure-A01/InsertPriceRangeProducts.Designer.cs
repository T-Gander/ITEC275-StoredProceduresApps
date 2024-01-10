namespace StoredProcedure_A01
{
    partial class InsertPriceRangeProducts
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
            txtMin = new TextBox();
            txtMax = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // txtMin
            // 
            txtMin.Location = new Point(46, 27);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 0;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(46, 56);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Price Range:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "Min";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Max";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(152, 55);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // InsertPriceRangeProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 85);
            Controls.Add(btnConfirm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Name = "InsertPriceRangeProducts";
            Text = "InsertPriceRangeProducts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConfirm;
        public TextBox txtMin;
        public TextBox txtMax;
    }
}