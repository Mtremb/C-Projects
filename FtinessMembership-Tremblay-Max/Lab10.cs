using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_200pm_Tremblay_Max
{
    public partial class Lab10 : Form
    {
        public Lab10()
        {
            InitializeComponent();
        }
        
        //method to clear totals
        private void ClearTotals()
        {
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

        }
        
        //method to clear discounts
        private void ClearDiscounts()
        {
            chkDiscount1.Checked = false;
            chkDiscount2.Checked = false;
            chkDiscount3.Checked = false;
        }

        //method to assign the strings to check boxes based on the radio button chosen
        private void MainType_CheckedChanged(object sender , EventArgs e)
        {
            if (rdoAdult.Checked)
            {
                grpDiscounts.Text = "Discount (less $5.00 each)";
                chkDiscount1.Text = "Military";
                chkDiscount2.Text = "Senior";
                chkDiscount3.Text = "One Year Contract";

            } else if (rdoFamily.Checked)
            {
                grpDiscounts.Text = "Discount (less $4.00 each)";
                chkDiscount1.Text = "One Year Contract";
                chkDiscount2.Text = "4 or more Members";
                chkDiscount3.Text = "Military";

            } else if (rdoYouth.Checked)
            {
                grpDiscounts.Text = "Discount (less $3.00 each)";
                chkDiscount1.Text = "High School Graduate";
                chkDiscount2.Text = "College Graduate";
                chkDiscount3.Text = "One Year Contract";
            }

            ClearDiscounts();
            ClearTotals();
        }

        //method to clear totals and to be assigned to check boxes
        private void ChangeAddOns(object sender, EventArgs e)
        {
            ClearTotals();
        }

        
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            //initiate variables
            int discounts = 0;
            decimal subtotal = 0m;
            decimal total = 0m;
            decimal tax = 0.075m;
            decimal taxAmount = 0m;

            //accumulated discounts
            if (chkDiscount1.Checked)
                discounts += 1;
            if (chkDiscount2.Checked)
                discounts += 1;
            if (chkDiscount3.Checked)
                discounts += 1;

            //calculate subtotals based on boxes checked
            if (rdoAdult.Checked)
            {
                subtotal = 30.00m - (discounts * 5.00m);
            } else if (rdoFamily.Checked)
            {
                subtotal = 40.00m - (discounts * 4.00m);
            } else if (rdoYouth.Checked)
            {
                subtotal = 25.00m - (discounts * 3.00m);
            }

            taxAmount = subtotal * tax;
            total = taxAmount + subtotal;

            //display information in text boxes
            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = taxAmount.ToString("c");
            txtTotal.Text = total.ToString("c");
        }

        //close application
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
