namespace TremblayCSharpUniversity
{
    partial class Product
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.textBookDataSet = new TremblayCSharpUniversity.TextBookDataSet();
            this.textBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBooksTableAdapter = new TremblayCSharpUniversity.TextBookDataSetTableAdapters.TextBooksTableAdapter();
            this.tableAdapterManager = new TremblayCSharpUniversity.TextBookDataSetTableAdapters.TableAdapterManager();
            this.textBooksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textBooksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.getProductDataToolStrip = new System.Windows.Forms.ToolStrip();
            this.productCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.productCodeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.getProductDataToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnGetAll = new System.Windows.Forms.ToolStripButton();
            productCodeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBooksBindingNavigator)).BeginInit();
            this.textBooksBindingNavigator.SuspendLayout();
            this.getProductDataToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new System.Drawing.Point(12, 135);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(75, 13);
            productCodeLabel.TabIndex = 1;
            productCodeLabel.Text = "Product Code:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 161);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(12, 187);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 5;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // textBookDataSet
            // 
            this.textBookDataSet.DataSetName = "TextBookDataSet";
            this.textBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBooksBindingSource
            // 
            this.textBooksBindingSource.DataMember = "TextBooks";
            this.textBooksBindingSource.DataSource = this.textBookDataSet;
            // 
            // textBooksTableAdapter
            // 
            this.textBooksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TextBooksTableAdapter = this.textBooksTableAdapter;
            this.tableAdapterManager.UpdateOrder = TremblayCSharpUniversity.TextBookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBooksBindingNavigator
            // 
            this.textBooksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.textBooksBindingNavigator.BindingSource = this.textBooksBindingSource;
            this.textBooksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.textBooksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.textBooksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.textBooksBindingNavigatorSaveItem});
            this.textBooksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.textBooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.textBooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.textBooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.textBooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.textBooksBindingNavigator.Name = "textBooksBindingNavigator";
            this.textBooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.textBooksBindingNavigator.Size = new System.Drawing.Size(481, 25);
            this.textBooksBindingNavigator.TabIndex = 0;
            this.textBooksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // textBooksBindingNavigatorSaveItem
            // 
            this.textBooksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textBooksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("textBooksBindingNavigatorSaveItem.Image")));
            this.textBooksBindingNavigatorSaveItem.Name = "textBooksBindingNavigatorSaveItem";
            this.textBooksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.textBooksBindingNavigatorSaveItem.Text = "Save Data";
            this.textBooksBindingNavigatorSaveItem.Click += new System.EventHandler(this.textBooksBindingNavigatorSaveItem_Click);
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textBooksBindingSource, "ProductCode", true));
            this.productCodeTextBox.Location = new System.Drawing.Point(93, 132);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.ReadOnly = true;
            this.productCodeTextBox.Size = new System.Drawing.Size(77, 20);
            this.productCodeTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textBooksBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(93, 158);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(286, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textBooksBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(93, 184);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.ReadOnly = true;
            this.unitPriceTextBox.Size = new System.Drawing.Size(77, 20);
            this.unitPriceTextBox.TabIndex = 6;
            // 
            // getProductDataToolStrip
            // 
            this.getProductDataToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productCodeToolStripLabel,
            this.productCodeToolStripTextBox,
            this.getProductDataToolStripButton,
            this.toolStripBtnGetAll});
            this.getProductDataToolStrip.Location = new System.Drawing.Point(0, 25);
            this.getProductDataToolStrip.Name = "getProductDataToolStrip";
            this.getProductDataToolStrip.Size = new System.Drawing.Size(481, 25);
            this.getProductDataToolStrip.TabIndex = 7;
            this.getProductDataToolStrip.TabStop = true;
            this.getProductDataToolStrip.Text = "getProductDataToolStrip";
            // 
            // productCodeToolStripLabel
            // 
            this.productCodeToolStripLabel.Name = "productCodeToolStripLabel";
            this.productCodeToolStripLabel.Size = new System.Drawing.Size(80, 22);
            this.productCodeToolStripLabel.Text = "ProductCode:";
            // 
            // productCodeToolStripTextBox
            // 
            this.productCodeToolStripTextBox.Name = "productCodeToolStripTextBox";
            this.productCodeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // getProductDataToolStripButton
            // 
            this.getProductDataToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getProductDataToolStripButton.Name = "getProductDataToolStripButton";
            this.getProductDataToolStripButton.Size = new System.Drawing.Size(95, 22);
            this.getProductDataToolStripButton.Text = "GetProductData";
            this.getProductDataToolStripButton.Click += new System.EventHandler(this.getProductDataToolStripButton_Click);
            // 
            // toolStripBtnGetAll
            // 
            this.toolStripBtnGetAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnGetAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnGetAll.Image")));
            this.toolStripBtnGetAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGetAll.Name = "toolStripBtnGetAll";
            this.toolStripBtnGetAll.Size = new System.Drawing.Size(96, 22);
            this.toolStripBtnGetAll.Text = "Get All Products";
            this.toolStripBtnGetAll.Click += new System.EventHandler(this.toolStripBtnGetAll_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 261);
            this.Controls.Add(this.getProductDataToolStrip);
            this.Controls.Add(productCodeLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.textBooksBindingNavigator);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBooksBindingNavigator)).EndInit();
            this.textBooksBindingNavigator.ResumeLayout(false);
            this.textBooksBindingNavigator.PerformLayout();
            this.getProductDataToolStrip.ResumeLayout(false);
            this.getProductDataToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBookDataSet textBookDataSet;
        private System.Windows.Forms.BindingSource textBooksBindingSource;
        private TextBookDataSetTableAdapters.TextBooksTableAdapter textBooksTableAdapter;
        private TextBookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator textBooksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton textBooksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.ToolStrip getProductDataToolStrip;
        private System.Windows.Forms.ToolStripLabel productCodeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox productCodeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton getProductDataToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripBtnGetAll;
    }
}