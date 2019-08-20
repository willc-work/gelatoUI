using System.Windows.Forms;

namespace GelatoUI
{
    partial class CustomerForm          
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
            this.custNumLabel = new System.Windows.Forms.Label();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custAddLabel = new System.Windows.Forms.Label();
            this.postcodeLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailAddLabel = new System.Windows.Forms.Label();
            this.custDiscLabel = new System.Windows.Forms.Label();
            this.secQuestLabel = new System.Windows.Forms.Label();
            this.secAnswerLabek = new System.Windows.Forms.Label();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addNewCustButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custNumLabel
            // 
            this.custNumLabel.AutoSize = true;
            this.custNumLabel.Location = new System.Drawing.Point(320, 25);
            this.custNumLabel.Name = "custNumLabel";
            this.custNumLabel.Size = new System.Drawing.Size(91, 13);
            this.custNumLabel.TabIndex = 0;
            this.custNumLabel.Text = "Customer Number";
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(320, 62);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(82, 13);
            this.custNameLabel.TabIndex = 2;
            this.custNameLabel.Text = "Customer Name";
            // 
            // custAddLabel
            // 
            this.custAddLabel.AutoSize = true;
            this.custAddLabel.Location = new System.Drawing.Point(320, 97);
            this.custAddLabel.Name = "custAddLabel";
            this.custAddLabel.Size = new System.Drawing.Size(45, 13);
            this.custAddLabel.TabIndex = 4;
            this.custAddLabel.Text = "Address";
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.AutoSize = true;
            this.postcodeLabel.Location = new System.Drawing.Point(320, 141);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.Size = new System.Drawing.Size(52, 13);
            this.postcodeLabel.TabIndex = 6;
            this.postcodeLabel.Text = "Postcode";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(320, 183);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // emailAddLabel
            // 
            this.emailAddLabel.AutoSize = true;
            this.emailAddLabel.Location = new System.Drawing.Point(320, 222);
            this.emailAddLabel.Name = "emailAddLabel";
            this.emailAddLabel.Size = new System.Drawing.Size(73, 13);
            this.emailAddLabel.TabIndex = 10;
            this.emailAddLabel.Text = "Email Address";
            // 
            // custDiscLabel
            // 
            this.custDiscLabel.AutoSize = true;
            this.custDiscLabel.Location = new System.Drawing.Point(320, 267);
            this.custDiscLabel.Name = "custDiscLabel";
            this.custDiscLabel.Size = new System.Drawing.Size(96, 13);
            this.custDiscLabel.TabIndex = 12;
            this.custDiscLabel.Text = "Customer Discount";
            // 
            // secQuestLabel
            // 
            this.secQuestLabel.AutoSize = true;
            this.secQuestLabel.Location = new System.Drawing.Point(320, 313);
            this.secQuestLabel.Name = "secQuestLabel";
            this.secQuestLabel.Size = new System.Drawing.Size(90, 13);
            this.secQuestLabel.TabIndex = 14;
            this.secQuestLabel.Text = "Security Question";
            // 
            // secAnswerLabek
            // 
            this.secAnswerLabek.AutoSize = true;
            this.secAnswerLabek.Location = new System.Drawing.Point(320, 362);
            this.secAnswerLabek.Name = "secAnswerLabek";
            this.secAnswerLabek.Size = new System.Drawing.Size(83, 13);
            this.secAnswerLabek.TabIndex = 16;
            this.secAnswerLabek.Text = "Security Answer";
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.Items.AddRange(new object[] {
            "Fred Smith",
            "Hoffams Confectioners",
            "Marios Ice Cream Factory",
            "Patisserie Valerie",
            "Slatterys",
            "The Cake Factory"});
            this.customerListBox.Location = new System.Drawing.Point(12, 25);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(263, 355);
            this.customerListBox.Sorted = true;
            this.customerListBox.TabIndex = 17;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(12, 398);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 18;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(110, 398);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // addNewCustButton
            // 
            this.addNewCustButton.Location = new System.Drawing.Point(200, 398);
            this.addNewCustButton.Name = "addNewCustButton";
            this.addNewCustButton.Size = new System.Drawing.Size(75, 23);
            this.addNewCustButton.TabIndex = 20;
            this.addNewCustButton.Text = "Add New";
            this.addNewCustButton.UseVisualStyleBackColor = true;
            this.addNewCustButton.Click += new System.EventHandler(this.AddNewCustButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewCustButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.secAnswerLabek);
            this.Controls.Add(this.secQuestLabel);
            this.Controls.Add(this.custDiscLabel);
            this.Controls.Add(this.emailAddLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.postcodeLabel);
            this.Controls.Add(this.custAddLabel);
            this.Controls.Add(this.custNameLabel);
            this.Controls.Add(this.custNumLabel);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custNumLabel;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.Label custAddLabel;
        private System.Windows.Forms.Label postcodeLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailAddLabel;
        private System.Windows.Forms.Label custDiscLabel;
        private System.Windows.Forms.Label secQuestLabel;
        private System.Windows.Forms.Label secAnswerLabek;
        private System.Windows.Forms.ListBox customerListBox;
        private Button selectButton;
        private Button clearButton;
        private Button addNewCustButton;
    }
}