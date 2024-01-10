namespace StoredProcedure_A01
{
    partial class InsertUserID
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
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(118, 11);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 12);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 1;
            // 
            // InsertUserID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 43);
            Controls.Add(txtInput);
            Controls.Add(btnConfirm);
            Name = "InsertUserID";
            Text = "InsertUserID";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        public TextBox txtInput;
    }
}