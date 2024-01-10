using ITEC275_A01;

namespace StoredProcedure_A01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BusinessLayer bl = new BusinessLayer();
            if (!bl.CheckConnection())
            {
                MessageBox.Show("Cannot connect to database. Please run CLI project first and run database setup before continuing.");
            }
        }

        private void btnSelectCustomersByCustomerID_Click(object sender, EventArgs e)
        {
            BusinessLayer bl = new BusinessLayer();
            InsertUserID inputForm = new InsertUserID();

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bl.SelectCustomersByCustomerID(inputForm.txtInput.Text.ToUpper());
            }
        }

        private void btnSelectProductsByPriceRange_Click(object sender, EventArgs e)
        {
            BusinessLayer bl = new BusinessLayer();
            InsertPriceRangeProducts inputForm = new InsertPriceRangeProducts();

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bl.SelectProductsByPriceRange(decimal.Parse(inputForm.txtMin.Text), decimal.Parse(inputForm.txtMax.Text));
            }
        }

        private void btnSelectAllOrdersWithDetail_Click(object sender, EventArgs e)
        {
            BusinessLayer bl = new BusinessLayer();
            dataGridView1.DataSource = bl.SelectAllOrdersWithOrderDetails();
        }

        private void btnInsertOrderForChai_Click(object sender, EventArgs e)
        {
            BusinessLayer bl = new BusinessLayer();
            InsertUserID inputForm = new InsertUserID();

            if (inputForm.ShowDialog() == DialogResult.OK
                && bl.InsertOrderByCustomerIDTenUnitsOfChaiAndRandomEmployee(inputForm.txtInput.Text.ToUpper()))
            {
                MessageBox.Show("Order Created Successfully.");
            }
        }

        private void btnUpdateProductUnitPrice_Click(object sender, EventArgs e)
        {
            BusinessLayer bl = new BusinessLayer();
            InsertProductIDAndUnitPrice inputForm = new InsertProductIDAndUnitPrice();

            if (inputForm.ShowDialog() == DialogResult.OK
                && bl.UpdateProductUnitPriceByProductID(int.Parse(inputForm.txtProductID.Text), decimal.Parse(inputForm.txtUnitPrice.Text)))
            {
                MessageBox.Show("Product Updated Successfully.");
            }
        }

        private void btnUpdateCustomersPhone_Click(object sender, EventArgs e)
        {
            BusinessLayer bl = new BusinessLayer();
            InsertCustomerIDAndPhone inputForm = new InsertCustomerIDAndPhone();

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                if(bl.UpdateCustomerPhoneByCustomerID(inputForm.txtCustomerID.Text.ToUpper(), inputForm.txtPhone.Text))
                {
                    MessageBox.Show("Customers Phone Number Updated Successfully.");
                }
                else
                {
                    MessageBox.Show("Customers Phone Number Failed to Update, phone number may be too long");
                }
            }
        }
    }
}
