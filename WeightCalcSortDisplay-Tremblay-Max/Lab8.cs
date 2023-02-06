using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_230_Tremblay_Max
{
    public partial class Lab8 : Form
    {
        //declare an array for the weights display
        int[] weightArray = new int[20];

        public Lab8()
        {
            InitializeComponent();
        }

        //create 2 variables to store input
        int weightTotal = 0;
        int weightCount = 0;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //create trry catch block and call the isvalid method to validate all data
            try
            {
                if (IsValidData())
                {

                    //create 2 variables to store input when using the add event
                    int weight = Convert.ToInt32(txtWeight.Text);
                    int averageWeight = 0;

                    //perform calculations for weight total, count and average. and add to array 
                    weightArray[weightCount] = weight;
                    weightTotal += weight;
                    weightCount += 1;
                    averageWeight = weightTotal / weightCount;

                    //convert and display the data in the corresponding text boxes
                    txtWeightTotal.Text = weightTotal.ToString();
                    txtWeightCount.Text = weightCount.ToString();
                    txtAverage.Text = averageWeight.ToString();

                    //clear the weight input box and set focus to it for user convenience
                    txtWeight.Clear();
                    this.ActiveControl = txtWeight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //close application
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //clear the variables and text boxes for next use and set focus to weight box for convenience. and reset the array
            weightTotal = 0;
            weightCount = 0;

            txtWeight.Text = "";
            txtAverage.Text = "";
            txtWeightCount.Text = "";
            txtWeightTotal.Text = "";
            weightArray = new int[20];

            this.ActiveControl = txtWeight;
        }

        //method tocheck that textboxes have data entered and display error message if not
        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field", "Entry error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        //method to check that textbox is an integer, and error message if not
        public bool IsInt(TextBox textBox, string name)
        {
            int number = 0;
            if (int.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer value", "Error entry");
                textBox.Focus();
                return false;
            }
        }

        //method to check that the number entered is within a certain range, error message if not
        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max, "Entery error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        //method to simplify usage of all above methods to validate data
        public bool IsValidData()
        {
            return
                //validate initial weight
                IsPresent(txtWeight, " Weight") &&
                IsInt(txtWeight, " Weight") &&
                IsWithinRange(txtWeight, " Weight", 0, 1000);
        }

        
        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            //declare string to hold display message and sort the array
            String displayMessage = "";
            Array.Sort(weightArray);

            //foreachloop to add the entrys to the display message
            foreach (int i in weightArray)
            {
                if (i != 0)
                {
                    displayMessage += i.ToString() + "\n";
                }
            }

            //messagebox to display message
            MessageBox.Show(displayMessage, " Sorted Weights");
            this.ActiveControl = txtWeight;

        }
    }
}
