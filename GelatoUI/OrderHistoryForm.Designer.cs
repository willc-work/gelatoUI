namespace GelatoUI
{
    partial class OrderHistoryForm
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
            this.orderHistoryLabel = new System.Windows.Forms.Label();
            this.orderDetailsLabel = new System.Windows.Forms.Label();
            this.orderHistoryListView = new System.Windows.Forms.ListView();
            this.orderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDetailsList = new System.Windows.Forms.ListView();
            this.ordHistNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ordStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewDetailsButton = new System.Windows.Forms.Button();
            this.returnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderHistoryLabel
            // 
            this.orderHistoryLabel.AutoSize = true;
            this.orderHistoryLabel.Location = new System.Drawing.Point(12, 9);
            this.orderHistoryLabel.Name = "orderHistoryLabel";
            this.orderHistoryLabel.Size = new System.Drawing.Size(68, 13);
            this.orderHistoryLabel.TabIndex = 2;
            this.orderHistoryLabel.Text = "Order History";
            // 
            // orderDetailsLabel
            // 
            this.orderDetailsLabel.AutoSize = true;
            this.orderDetailsLabel.Location = new System.Drawing.Point(12, 235);
            this.orderDetailsLabel.Name = "orderDetailsLabel";
            this.orderDetailsLabel.Size = new System.Drawing.Size(68, 13);
            this.orderDetailsLabel.TabIndex = 3;
            this.orderDetailsLabel.Text = "Order Details";
            // 
            // orderHistoryListView
            // 
            this.orderHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderNumber,
            this.orderDate,
            this.orderStatus,
            this.discount,
            this.orderTotal,
            this.discTotal});
            this.orderHistoryListView.HideSelection = false;
            this.orderHistoryListView.LabelWrap = false;
            this.orderHistoryListView.Location = new System.Drawing.Point(9, 23);
            this.orderHistoryListView.Name = "orderHistoryListView";
            this.orderHistoryListView.Size = new System.Drawing.Size(762, 179);
            this.orderHistoryListView.TabIndex = 13;
            this.orderHistoryListView.UseCompatibleStateImageBehavior = false;
            this.orderHistoryListView.View = System.Windows.Forms.View.Details;
            // 
            // orderNumber
            // 
            this.orderNumber.Text = "Order No.";
            this.orderNumber.Width = 92;
            // 
            // orderDate
            // 
            this.orderDate.Text = "Order Date";
            this.orderDate.Width = 153;
            // 
            // orderStatus
            // 
            this.orderStatus.Tag = "test";
            this.orderStatus.Text = "Order Status";
            this.orderStatus.Width = 114;
            // 
            // discount
            // 
            this.discount.Text = "Discount";
            this.discount.Width = 92;
            // 
            // orderTotal
            // 
            this.orderTotal.Text = "Order Total";
            this.orderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.orderTotal.Width = 106;
            // 
            // discTotal
            // 
            this.discTotal.Text = "Discounted Total";
            this.discTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discTotal.Width = 135;
            // 
            // orderDetailsList
            // 
            this.orderDetailsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ordHistNumber,
            this.prodNumber,
            this.prodName,
            this.quantity,
            this.price,
            this.total,
            this.ordStatus});
            this.orderDetailsList.HideSelection = false;
            this.orderDetailsList.LabelWrap = false;
            this.orderDetailsList.Location = new System.Drawing.Point(12, 260);
            this.orderDetailsList.Name = "orderDetailsList";
            this.orderDetailsList.Size = new System.Drawing.Size(759, 186);
            this.orderDetailsList.TabIndex = 14;
            this.orderDetailsList.UseCompatibleStateImageBehavior = false;
            this.orderDetailsList.View = System.Windows.Forms.View.Details;
            // 
            // ordHistNumber
            // 
            this.ordHistNumber.Text = "Order No.";
            this.ordHistNumber.Width = 86;
            // 
            // prodNumber
            // 
            this.prodNumber.Text = "Product No.";
            this.prodNumber.Width = 80;
            // 
            // prodName
            // 
            this.prodName.Text = "Product Name";
            this.prodName.Width = 167;
            // 
            // quantity
            // 
            this.quantity.Tag = "test";
            this.quantity.Text = "Quantity";
            this.quantity.Width = 64;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.price.Width = 90;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total.Width = 106;
            // 
            // ordStatus
            // 
            this.ordStatus.Text = "Order Status";
            this.ordStatus.Width = 107;
            // 
            // viewDetailsButton
            // 
            this.viewDetailsButton.Location = new System.Drawing.Point(189, 208);
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.Size = new System.Drawing.Size(128, 23);
            this.viewDetailsButton.TabIndex = 15;
            this.viewDetailsButton.Text = "View Order Details";
            this.viewDetailsButton.UseVisualStyleBackColor = true;
            this.viewDetailsButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // returnHome
            // 
            this.returnHome.Location = new System.Drawing.Point(622, 213);
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(133, 35);
            this.returnHome.TabIndex = 16;
            this.returnHome.Text = "Return To Customer Screen";
            this.returnHome.UseVisualStyleBackColor = true;
            this.returnHome.Click += new System.EventHandler(this.ReturnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Order Number to see details";
            // 
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnHome);
            this.Controls.Add(this.viewDetailsButton);
            this.Controls.Add(this.orderDetailsList);
            this.Controls.Add(this.orderHistoryListView);
            this.Controls.Add(this.orderDetailsLabel);
            this.Controls.Add(this.orderHistoryLabel);
            this.Name = "OrderHistoryForm";
            this.Text = "OrderHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label orderHistoryLabel;
        private System.Windows.Forms.Label orderDetailsLabel;
        private System.Windows.Forms.ListView orderHistoryListView;
        private System.Windows.Forms.ColumnHeader orderNumber;
        private System.Windows.Forms.ColumnHeader orderDate;
        private System.Windows.Forms.ColumnHeader orderStatus;
        private System.Windows.Forms.ColumnHeader discount;
        private System.Windows.Forms.ColumnHeader orderTotal;
        private System.Windows.Forms.ColumnHeader discTotal;
        private System.Windows.Forms.ListView orderDetailsList;
        private System.Windows.Forms.ColumnHeader ordHistNumber;
        private System.Windows.Forms.ColumnHeader prodNumber;
        private System.Windows.Forms.ColumnHeader prodName;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.Button viewDetailsButton;
        private System.Windows.Forms.Button returnHome;
        private System.Windows.Forms.ColumnHeader ordStatus;
        private System.Windows.Forms.Label label1;
    }
}