using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoredProcedure_A01
{
    public partial class InsertProductIDAndUnitPrice : Form
    {
        public InsertProductIDAndUnitPrice()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductID.Text, out int ProductID) && decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("There is a problem with the inputs.");
            }
        }
    }
}
