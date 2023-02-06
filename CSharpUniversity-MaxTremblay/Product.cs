using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TremblayCSharpUniversity
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void textBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                this.textBooksBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.textBookDataSet);
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            productCodeToolStripTextBox.Focus();


        }

        private void getProductDataToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBooksTableAdapter.GetProductData(this.textBookDataSet.TextBooks, productCodeToolStripTextBox.Text);
                if (textBooksBindingSource.Count == 0)
                {
                    MessageBox.Show("Textbook code must be entered", "Product code not found");
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public bool ValidData()
        {
            if (productCodeTextBox.Text == "")
            {
                MessageBox.Show("Textbook code must be entered", "Product code entry error");
                return false;
            }
            else if (descriptionTextBox.Text == "")
            {
                MessageBox.Show("Textbook description must be entered", "Textbook description entry error");
                return false;
            }
            else if (unitPriceTextBox.Text == "")
            {
                MessageBox.Show("Unit price must be entered", "Unit price entry error");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ReadOnlyFalse()
        {
            productCodeTextBox.ReadOnly = false;
            descriptionTextBox.ReadOnly = false;
            unitPriceTextBox.ReadOnly = false;
        }

        private void ReadOnlyTrue(){
            productCodeTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            unitPriceTextBox.ReadOnly = true;
        }

            


        private void toolStripBtnGetAll_Click(object sender, EventArgs e)
        {
            try
            {


                // TODO: This line of code loads data into the 'textBookDataSet.TextBooks' table. You can move, or remove it, as needed.
                this.textBooksTableAdapter.Fill(this.textBookDataSet.TextBooks);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ReadOnlyFalse();
            bindingNavigatorAddNewItem.Visible = false;
            bindingNavigatorDeleteItem.Visible = false;
            getProductDataToolStripButton.Visible = false;
        }
    }
}
