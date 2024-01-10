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
    public partial class InsertPriceRangeProducts : Form
    {
        public InsertPriceRangeProducts()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMin.Text, out decimal min) && decimal.TryParse(txtMax.Text, out decimal max))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Inputs aren't of type decimal.");
            }
        }
    }
}
