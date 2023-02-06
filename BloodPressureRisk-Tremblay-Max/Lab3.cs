using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TremblayLab2
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void Lab2_Load(object sender, EventArgs e)
        {

        }

        private void TxthealthRisk_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //exit the program when pressed
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //create a decimal cariable to store the input
            decimal bloodPressure = Convert.ToDecimal(txtBP.Text);
            //create a string variable to store the output o user
            string healthRisk = "";            //calculate the blood pressure based on waht the user inputs            if (bloodPressure >= 200)
            {
                healthRisk = "High Risk";
            }
            else if (bloodPressure >= 180 && bloodPressure <= 199)
            {
                healthRisk = "Moderate Risk";
            }
            else if (bloodPressure >= 140 && bloodPressure <= 179)
            {
                healthRisk = "Mild Risk";
            }
            else if (bloodPressure >= 121 && bloodPressure <= 139)
            {
                healthRisk = "Low Risk";
            }
            else if (bloodPressure >= 80 && bloodPressure <= 120)
            {
                healthRisk = "Healthy";
            }
            else
            {
                healthRisk = "Error";
            }            //display results into the text box            txtHealthRisk.Text = healthRisk;
            //move focus back to the input box
            txtBP.Focus();
        }
    }
}
