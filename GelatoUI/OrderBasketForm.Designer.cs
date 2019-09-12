namespace GelatoUI
{
    partial class OrderBasketForm
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
            this.productLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.discountBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.productNameBox = new System.Windows.Forms.ComboBox();
            this.basketListView = new System.Windows.Forms.ListView();
            this.prodNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rrp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.numProductsLabel = new System.Windows.Forms.Label();
            this.numItemsLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.discTotalLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityCounter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfProducts = new System.Windows.Forms.TextBox();
            this.numOfItems = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.discTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(12, 35);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(75, 13);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Product Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(148, 35);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(63, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Latest Price";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(263, 35);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(49, 13);
            this.discountLabel.TabIndex = 4;
            this.discountLabel.Text = "Discount";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(381, 35);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(60, 13);
            this.descLabel.TabIndex = 6;
            this.descLabel.Text = "Description";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(641, 35);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 56);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // discountBox
            // 
            this.discountBox.Location = new System.Drawing.Point(266, 61);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(100, 20);
            this.discountBox.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(151, 61);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 9;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(384, 61);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(172, 67);
            this.descriptionTextBox.TabIndex = 10;
            this.descriptionTextBox.Text = "";
            // 
            // productNameBox
            // 
            this.productNameBox.FormattingEnabled = true;
            this.productNameBox.Location = new System.Drawing.Point(12, 60);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(121, 21);
            this.productNameBox.TabIndex = 11;
            this.productNameBox.SelectedIndexChanged += new System.EventHandler(this.ProductNameBox_SelectedIndexChanged_1);
            // 
            // basketListView
            // 
            this.basketListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodNumber,
            this.prodName,
            this.quantity,
            this.price,
            this.total,
            this.rrp,
            this.desc});
            this.basketListView.HideSelection = false;
            this.basketListView.Location = new System.Drawing.Point(32, 152);
            this.basketListView.Name = "basketListView";
            this.basketListView.Size = new System.Drawing.Size(602, 225);
            this.basketListView.TabIndex = 12;
            this.basketListView.UseCompatibleStateImageBehavior = false;
            this.basketListView.View = System.Windows.Forms.View.Details;
            // 
            // prodNumber
            // 
            this.prodNumber.Text = "Product No.";
            this.prodNumber.Width = 50;
            // 
            // prodName
            // 
            this.prodName.Text = "Product Name";
            this.prodName.Width = 120;
            // 
            // quantity
            // 
            this.quantity.Tag = "test";
            this.quantity.Text = "Quantity";
            this.quantity.Width = 50;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 50;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 50;
            // 
            // rrp
            // 
            this.rrp.Text = "RRP";
            this.rrp.Width = 50;
            // 
            // desc
            // 
            this.desc.Text = "Description";
            this.desc.Width = 200;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(659, 152);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(89, 19);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(659, 177);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 19);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear Basket";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(659, 345);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(89, 43);
            this.checkOutButton.TabIndex = 15;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(659, 394);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 19);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(659, 419);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 19);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // numProductsLabel
            // 
            this.numProductsLabel.AutoSize = true;
            this.numProductsLabel.Location = new System.Drawing.Point(29, 394);
            this.numProductsLabel.Name = "numProductsLabel";
            this.numProductsLabel.Size = new System.Drawing.Size(80, 13);
            this.numProductsLabel.TabIndex = 18;
            this.numProductsLabel.Text = "No. of products";
            // 
            // numItemsLabel
            // 
            this.numItemsLabel.AutoSize = true;
            this.numItemsLabel.Location = new System.Drawing.Point(148, 395);
            this.numItemsLabel.Name = "numItemsLabel";
            this.numItemsLabel.Size = new System.Drawing.Size(64, 13);
            this.numItemsLabel.TabIndex = 19;
            this.numItemsLabel.Text = "No. of Items";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(263, 395);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 20;
            this.totalLabel.Text = "Total";
            // 
            // discTotalLabel
            // 
            this.discTotalLabel.AutoSize = true;
            this.discTotalLabel.Location = new System.Drawing.Point(353, 397);
            this.discTotalLabel.Name = "discTotalLabel";
            this.discTotalLabel.Size = new System.Drawing.Size(88, 13);
            this.discTotalLabel.TabIndex = 21;
            this.discTotalLabel.Text = "Discounted Total";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(561, 35);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 22;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityCounter
            // 
            this.quantityCounter.Location = new System.Drawing.Point(564, 62);
            this.quantityCounter.Name = "quantityCounter";
            this.quantityCounter.Size = new System.Drawing.Size(50, 20);
            this.quantityCounter.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "label2";
            // 
            // numOfProducts
            // 
            this.numOfProducts.Location = new System.Drawing.Point(40, 415);
            this.numOfProducts.Name = "numOfProducts";
            this.numOfProducts.Size = new System.Drawing.Size(69, 20);
            this.numOfProducts.TabIndex = 28;
            // 
            // numOfItems
            // 
            this.numOfItems.Location = new System.Drawing.Point(151, 415);
            this.numOfItems.Name = "numOfItems";
            this.numOfItems.Size = new System.Drawing.Size(84, 20);
            this.numOfItems.TabIndex = 29;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(266, 415);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(71, 20);
            this.totalBox.TabIndex = 30;
            // 
            // discTotal
            // 
            this.discTotal.Location = new System.Drawing.Point(356, 415);
            this.discTotal.Name = "discTotal";
            this.discTotal.Size = new System.Drawing.Size(100, 20);
            this.discTotal.TabIndex = 31;
            this.discTotal.TextChanged += new System.EventHandler(this.DiscTotal_TextChanged);
            // 
            // OrderBasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.discTotal);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.numOfItems);
            this.Controls.Add(this.numOfProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityCounter);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.discTotalLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.numItemsLabel);
            this.Controls.Add(this.numProductsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.basketListView);
            this.Controls.Add(this.productNameBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.discountBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productLabel);
            this.Name = "OrderBasketForm";
            this.Text = "OrderBasket";
            ((System.ComponentModel.ISupportInitialize)(this.quantityCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox discountBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox productNameBox;
        private System.Windows.Forms.ListView basketListView;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label numProductsLabel;
        private System.Windows.Forms.Label numItemsLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label discTotalLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader prodNumber;
        private System.Windows.Forms.ColumnHeader prodName;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader rrp;
        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.TextBox numOfProducts;
        private System.Windows.Forms.TextBox numOfItems;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.TextBox discTotal;
    }
}