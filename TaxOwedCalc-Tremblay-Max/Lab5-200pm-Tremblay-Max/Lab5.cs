using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_200pm_Tremblay_Max
{
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //closes the application
            this.Close();

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            //declare the variable to store income and tax
            Decimal income = Decimal.Parse(txtTaxableIncome.Text);
            decimal tax = .0m;

            //use if else statements to comopute the tax amount
            if (income <= 9250)
                tax = (int)(income * .10m);
            else if (income > 9250 && income <= 37500)
                tax = 925.50m + (int)((income - 9250) * .15m);
            else if (income > 37500 && income <= 90750)
                tax = 5150.25m + (int)((income - 37500) * .25m);
            else if (income > 90750 && income <= 189400)
                tax = 18490.25m + (int)((income - 90750) * .28m);
            else if (income > 189400 && income <= 411500)
                tax = 46075.25m + (int)((income - 189400) * .33m);
            else if (income > 411500 && income <= 413200)
                tax = 119401.25m + (int)((income - 411500) * .35m);
            else if (income > 413200)
                tax = 119998.25m + (int)((income - 413200) * .396m);

            //convert tax to string and display 
            txtTaxOwed.Text = tax.ToString("c");

            //keep focus on the input box
            txtTaxableIncome.Focus();
        }
    }
}
