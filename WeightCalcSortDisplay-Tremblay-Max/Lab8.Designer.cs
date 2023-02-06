namespace Lab4_230_Tremblay_Max
{
    partial class Lab8
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblWeighttotal = new System.Windows.Forms.Label();
            this.lblWeightcount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtWeightTotal = new System.Windows.Forms.TextBox();
            this.txtWeightCount = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(189, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(189, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(38, 45);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight:";
            // 
            // lblWeighttotal
            // 
            this.lblWeighttotal.AutoSize = true;
            this.lblWeighttotal.Location = new System.Drawing.Point(21, 79);
            this.lblWeighttotal.Name = "lblWeighttotal";
            this.lblWeighttotal.Size = new System.Drawing.Size(67, 13);
            this.lblWeighttotal.TabIndex = 4;
            this.lblWeighttotal.Text = "Weight total:";
            // 
            // lblWeightcount
            // 
            this.lblWeightcount.AutoSize = true;
            this.lblWeightcount.Location = new System.Drawing.Point(14, 108);
            this.lblWeightcount.Name = "lblWeightcount";
            this.lblWeightcount.Size = new System.Drawing.Size(74, 13);
            this.lblWeightcount.TabIndex = 5;
            this.lblWeightcount.Text = "Weight count:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(32, 145);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "Average:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(99, 45);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(43, 20);
            this.txtWeight.TabIndex = 7;
            // 
            // txtWeightTotal
            // 
            this.txtWeightTotal.Location = new System.Drawing.Point(99, 79);
            this.txtWeightTotal.Name = "txtWeightTotal";
            this.txtWeightTotal.ReadOnly = true;
            this.txtWeightTotal.Size = new System.Drawing.Size(43, 20);
            this.txtWeightTotal.TabIndex = 8;
            // 
            // txtWeightCount
            // 
            this.txtWeightCount.Location = new System.Drawing.Point(99, 108);
            this.txtWeightCount.Name = "txtWeightCount";
            this.txtWeightCount.ReadOnly = true;
            this.txtWeightCount.Size = new System.Drawing.Size(43, 20);
            this.txtWeightCount.TabIndex = 9;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(99, 145);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(43, 20);
            this.txtAverage.TabIndex = 10;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(35, 182);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(107, 23);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "&Display Weights";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // Lab8
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(335, 261);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtWeightCount);
            this.Controls.Add(this.txtWeightTotal);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblWeightcount);
            this.Controls.Add(this.lblWeighttotal);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Name = "Lab8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forever Fitness Weight Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblWeighttotal;
        private System.Windows.Forms.Label lblWeightcount;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtWeightTotal;
        private System.Windows.Forms.TextBox txtWeightCount;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnDisplay;
    }
}

