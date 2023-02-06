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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.textBooksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.textBookDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'textBookDataSet.TextBooks' table. You can move, or remove it, as needed.
            this.textBooksTableAdapter.Fill(this.textBookDataSet.TextBooks);

        }
    }
}
