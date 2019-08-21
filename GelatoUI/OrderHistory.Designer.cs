namespace GelatoUI
{
    partial class OrderHistory
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
            this.orderHistoryList = new System.Windows.Forms.ListBox();
            this.orderDetailsList = new System.Windows.Forms.ListBox();
            this.orderHistoryLabel = new System.Windows.Forms.Label();
            this.orderDetailsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderHistoryList
            // 
            this.orderHistoryList.FormattingEnabled = true;
            this.orderHistoryList.Location = new System.Drawing.Point(12, 25);
            this.orderHistoryList.Name = "orderHistoryList";
            this.orderHistoryList.Size = new System.Drawing.Size(762, 186);
            this.orderHistoryList.TabIndex = 0;
            // 
            // orderDetailsList
            // 
            this.orderDetailsList.FormattingEnabled = true;
            this.orderDetailsList.Location = new System.Drawing.Point(12, 240);
            this.orderDetailsList.Name = "orderDetailsList";
            this.orderDetailsList.Size = new System.Drawing.Size(762, 173);
            this.orderDetailsList.TabIndex = 1;
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
            this.orderDetailsLabel.Location = new System.Drawing.Point(12, 218);
            this.orderDetailsLabel.Name = "orderDetailsLabel";
            this.orderDetailsLabel.Size = new System.Drawing.Size(68, 13);
            this.orderDetailsLabel.TabIndex = 3;
            this.orderDetailsLabel.Text = "Order Details";
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderDetailsLabel);
            this.Controls.Add(this.orderHistoryLabel);
            this.Controls.Add(this.orderDetailsList);
            this.Controls.Add(this.orderHistoryList);
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox orderHistoryList;
        private System.Windows.Forms.ListBox orderDetailsList;
        private System.Windows.Forms.Label orderHistoryLabel;
        private System.Windows.Forms.Label orderDetailsLabel;
    }
}