namespace Lab10_200pm_Tremblay_Max
{
    partial class Lab10
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoYouth = new System.Windows.Forms.RadioButton();
            this.rdoFamily = new System.Windows.Forms.RadioButton();
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.grpDiscounts = new System.Windows.Forms.GroupBox();
            this.chkDiscount3 = new System.Windows.Forms.CheckBox();
            this.chkDiscount2 = new System.Windows.Forms.CheckBox();
            this.chkDiscount1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpDiscounts.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(270, 150);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(108, 23);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "&Submit Member";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(270, 227);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(108, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoYouth);
            this.groupBox1.Controls.Add(this.rdoFamily);
            this.groupBox1.Controls.Add(this.rdoAdult);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership Type";
            // 
            // rdoYouth
            // 
            this.rdoYouth.AutoSize = true;
            this.rdoYouth.Location = new System.Drawing.Point(7, 68);
            this.rdoYouth.Name = "rdoYouth";
            this.rdoYouth.Size = new System.Drawing.Size(121, 17);
            this.rdoYouth.TabIndex = 2;
            this.rdoYouth.Text = "Youth Member - $25";
            this.rdoYouth.UseVisualStyleBackColor = true;
            this.rdoYouth.CheckedChanged += new System.EventHandler(this.MainType_CheckedChanged);
            // 
            // rdoFamily
            // 
            this.rdoFamily.AutoSize = true;
            this.rdoFamily.Location = new System.Drawing.Point(7, 44);
            this.rdoFamily.Name = "rdoFamily";
            this.rdoFamily.Size = new System.Drawing.Size(122, 17);
            this.rdoFamily.TabIndex = 1;
            this.rdoFamily.Text = "Family Member - $40";
            this.rdoFamily.UseVisualStyleBackColor = true;
            this.rdoFamily.CheckedChanged += new System.EventHandler(this.MainType_CheckedChanged);
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Checked = true;
            this.rdoAdult.Location = new System.Drawing.Point(6, 21);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(117, 17);
            this.rdoAdult.TabIndex = 0;
            this.rdoAdult.TabStop = true;
            this.rdoAdult.Text = "Adult Member - $30";
            this.rdoAdult.UseVisualStyleBackColor = true;
            this.rdoAdult.CheckedChanged += new System.EventHandler(this.MainType_CheckedChanged);
            // 
            // grpDiscounts
            // 
            this.grpDiscounts.Controls.Add(this.chkDiscount3);
            this.grpDiscounts.Controls.Add(this.chkDiscount2);
            this.grpDiscounts.Controls.Add(this.chkDiscount1);
            this.grpDiscounts.Location = new System.Drawing.Point(201, 22);
            this.grpDiscounts.Name = "grpDiscounts";
            this.grpDiscounts.Size = new System.Drawing.Size(200, 100);
            this.grpDiscounts.TabIndex = 3;
            this.grpDiscounts.TabStop = false;
            this.grpDiscounts.Text = "Discount (less $5.00 each)";
            // 
            // chkDiscount3
            // 
            this.chkDiscount3.AutoSize = true;
            this.chkDiscount3.Location = new System.Drawing.Point(7, 68);
            this.chkDiscount3.Name = "chkDiscount3";
            this.chkDiscount3.Size = new System.Drawing.Size(114, 17);
            this.chkDiscount3.TabIndex = 2;
            this.chkDiscount3.Text = "One Year Contract";
            this.chkDiscount3.UseVisualStyleBackColor = true;
            this.chkDiscount3.CheckedChanged += new System.EventHandler(this.ChangeAddOns);
            // 
            // chkDiscount2
            // 
            this.chkDiscount2.AutoSize = true;
            this.chkDiscount2.Location = new System.Drawing.Point(7, 44);
            this.chkDiscount2.Name = "chkDiscount2";
            this.chkDiscount2.Size = new System.Drawing.Size(56, 17);
            this.chkDiscount2.TabIndex = 1;
            this.chkDiscount2.Text = "Senior";
            this.chkDiscount2.UseVisualStyleBackColor = true;
            this.chkDiscount2.CheckedChanged += new System.EventHandler(this.ChangeAddOns);
            // 
            // chkDiscount1
            // 
            this.chkDiscount1.AutoSize = true;
            this.chkDiscount1.Location = new System.Drawing.Point(7, 20);
            this.chkDiscount1.Name = "chkDiscount1";
            this.chkDiscount1.Size = new System.Drawing.Size(58, 17);
            this.chkDiscount1.TabIndex = 0;
            this.chkDiscount1.Text = "Military";
            this.chkDiscount1.UseVisualStyleBackColor = true;
            this.chkDiscount1.CheckedChanged += new System.EventHandler(this.ChangeAddOns);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.txtTax);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(94, 74);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(94, 50);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(94, 28);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tax (7.50%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // Lab10
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(415, 270);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpDiscounts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.submitBtn);
            this.Name = "Lab10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forever Fitness Memberships";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDiscounts.ResumeLayout(false);
            this.grpDiscounts.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoYouth;
        private System.Windows.Forms.RadioButton rdoFamily;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.GroupBox grpDiscounts;
        private System.Windows.Forms.CheckBox chkDiscount3;
        private System.Windows.Forms.CheckBox chkDiscount2;
        private System.Windows.Forms.CheckBox chkDiscount1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

