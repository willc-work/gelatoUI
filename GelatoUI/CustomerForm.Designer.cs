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
            this.addNewCustButton = new System.Windows.Forms.Button();
            this.custListBox = new System.Windows.Forms.ListBox();
            this.showCustNum = new System.Windows.Forms.Label();
            this.showCustName = new System.Windows.Forms.Label();
            this.showCustPCode = new System.Windows.Forms.Label();
            this.showCustAdd1 = new System.Windows.Forms.Label();
            this.showCustPhone = new System.Windows.Forms.Label();
            this.showCustEmail = new System.Windows.Forms.Label();
            this.showCustDisc = new System.Windows.Forms.Label();
            this.showCustSQ = new System.Windows.Forms.Label();
            this.showCustSA = new System.Windows.Forms.Label();
            this.takeNewOrderButton = new System.Windows.Forms.Button();
            this.showCustAdd2 = new System.Windows.Forms.Label();
            this.showCustAdd3 = new System.Windows.Forms.Label();
            this.orderHistButton = new System.Windows.Forms.Button();
            this.sortAscButton = new System.Windows.Forms.Button();
            this.sortDescButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custNumLabel
            // 
            this.custNumLabel.AutoSize = true;
            this.custNumLabel.Location = new System.Drawing.Point(311, 25);
            this.custNumLabel.Name = "custNumLabel";
            this.custNumLabel.Size = new System.Drawing.Size(91, 13);
            this.custNumLabel.TabIndex = 0;
            this.custNumLabel.Text = "Customer Number";
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(312, 53);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(82, 13);
            this.custNameLabel.TabIndex = 2;
            this.custNameLabel.Text = "Customer Name";
            // 
            // custAddLabel
            // 
            this.custAddLabel.AutoSize = true;
            this.custAddLabel.Location = new System.Drawing.Point(313, 97);
            this.custAddLabel.Name = "custAddLabel";
            this.custAddLabel.Size = new System.Drawing.Size(45, 13);
            this.custAddLabel.TabIndex = 4;
            this.custAddLabel.Text = "Address";
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.AutoSize = true;
            this.postcodeLabel.Location = new System.Drawing.Point(313, 203);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.Size = new System.Drawing.Size(52, 13);
            this.postcodeLabel.TabIndex = 6;
            this.postcodeLabel.Text = "Postcode";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(312, 248);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // emailAddLabel
            // 
            this.emailAddLabel.AutoSize = true;
            this.emailAddLabel.Location = new System.Drawing.Point(312, 275);
            this.emailAddLabel.Name = "emailAddLabel";
            this.emailAddLabel.Size = new System.Drawing.Size(73, 13);
            this.emailAddLabel.TabIndex = 10;
            this.emailAddLabel.Text = "Email Address";
            // 
            // custDiscLabel
            // 
            this.custDiscLabel.AutoSize = true;
            this.custDiscLabel.Location = new System.Drawing.Point(312, 307);
            this.custDiscLabel.Name = "custDiscLabel";
            this.custDiscLabel.Size = new System.Drawing.Size(96, 13);
            this.custDiscLabel.TabIndex = 12;
            this.custDiscLabel.Text = "Customer Discount";
            // 
            // secQuestLabel
            // 
            this.secQuestLabel.AutoSize = true;
            this.secQuestLabel.Location = new System.Drawing.Point(312, 340);
            this.secQuestLabel.Name = "secQuestLabel";
            this.secQuestLabel.Size = new System.Drawing.Size(90, 13);
            this.secQuestLabel.TabIndex = 14;
            this.secQuestLabel.Text = "Security Question";
            // 
            // secAnswerLabek
            // 
            this.secAnswerLabek.AutoSize = true;
            this.secAnswerLabek.Location = new System.Drawing.Point(312, 367);
            this.secAnswerLabek.Name = "secAnswerLabek";
            this.secAnswerLabek.Size = new System.Drawing.Size(83, 13);
            this.secAnswerLabek.TabIndex = 16;
            this.secAnswerLabek.Text = "Security Answer";
            // 
            // addNewCustButton
            // 
            this.addNewCustButton.Location = new System.Drawing.Point(215, 398);
            this.addNewCustButton.Name = "addNewCustButton";
            this.addNewCustButton.Size = new System.Drawing.Size(60, 23);
            this.addNewCustButton.TabIndex = 20;
            this.addNewCustButton.Text = "Add New";
            this.addNewCustButton.UseVisualStyleBackColor = true;
            this.addNewCustButton.Click += new System.EventHandler(this.AddNewCustButton_Click);
            // 
            // custListBox
            // 
            this.custListBox.FormattingEnabled = true;
            this.custListBox.Location = new System.Drawing.Point(12, 12);
            this.custListBox.Name = "custListBox";
            this.custListBox.Size = new System.Drawing.Size(263, 368);
            this.custListBox.TabIndex = 22;
            this.custListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // showCustNum
            // 
            this.showCustNum.AutoSize = true;
            this.showCustNum.Location = new System.Drawing.Point(431, 25);
            this.showCustNum.Name = "showCustNum";
            this.showCustNum.Size = new System.Drawing.Size(35, 13);
            this.showCustNum.TabIndex = 23;
            this.showCustNum.Text = "label1";
            // 
            // showCustName
            // 
            this.showCustName.AutoSize = true;
            this.showCustName.Location = new System.Drawing.Point(431, 53);
            this.showCustName.Name = "showCustName";
            this.showCustName.Size = new System.Drawing.Size(35, 13);
            this.showCustName.TabIndex = 24;
            this.showCustName.Text = "label2";
            // 
            // showCustPCode
            // 
            this.showCustPCode.AutoSize = true;
            this.showCustPCode.Location = new System.Drawing.Point(431, 203);
            this.showCustPCode.Name = "showCustPCode";
            this.showCustPCode.Size = new System.Drawing.Size(35, 13);
            this.showCustPCode.TabIndex = 25;
            this.showCustPCode.Text = "label3";
            // 
            // showCustAdd1
            // 
            this.showCustAdd1.AutoSize = true;
            this.showCustAdd1.Location = new System.Drawing.Point(431, 97);
            this.showCustAdd1.Name = "showCustAdd1";
            this.showCustAdd1.Size = new System.Drawing.Size(35, 13);
            this.showCustAdd1.TabIndex = 25;
            this.showCustAdd1.Text = "label3";
            // 
            // showCustPhone
            // 
            this.showCustPhone.AutoSize = true;
            this.showCustPhone.Location = new System.Drawing.Point(431, 248);
            this.showCustPhone.Name = "showCustPhone";
            this.showCustPhone.Size = new System.Drawing.Size(35, 13);
            this.showCustPhone.TabIndex = 26;
            this.showCustPhone.Text = "label5";
            // 
            // showCustEmail
            // 
            this.showCustEmail.AutoSize = true;
            this.showCustEmail.Location = new System.Drawing.Point(431, 275);
            this.showCustEmail.Name = "showCustEmail";
            this.showCustEmail.Size = new System.Drawing.Size(35, 13);
            this.showCustEmail.TabIndex = 27;
            this.showCustEmail.Text = "label6";
            // 
            // showCustDisc
            // 
            this.showCustDisc.AutoSize = true;
            this.showCustDisc.Location = new System.Drawing.Point(431, 307);
            this.showCustDisc.Name = "showCustDisc";
            this.showCustDisc.Size = new System.Drawing.Size(35, 13);
            this.showCustDisc.TabIndex = 28;
            this.showCustDisc.Text = "label7";
            // 
            // showCustSQ
            // 
            this.showCustSQ.AutoSize = true;
            this.showCustSQ.Location = new System.Drawing.Point(431, 340);
            this.showCustSQ.Name = "showCustSQ";
            this.showCustSQ.Size = new System.Drawing.Size(35, 13);
            this.showCustSQ.TabIndex = 29;
            this.showCustSQ.Text = "label8";
            // 
            // showCustSA
            // 
            this.showCustSA.AutoSize = true;
            this.showCustSA.Location = new System.Drawing.Point(431, 367);
            this.showCustSA.Name = "showCustSA";
            this.showCustSA.Size = new System.Drawing.Size(35, 13);
            this.showCustSA.TabIndex = 30;
            this.showCustSA.Text = "label9";
            // 
            // takeNewOrderButton
            // 
            this.takeNewOrderButton.Location = new System.Drawing.Point(530, 409);
            this.takeNewOrderButton.Name = "takeNewOrderButton";
            this.takeNewOrderButton.Size = new System.Drawing.Size(213, 23);
            this.takeNewOrderButton.TabIndex = 31;
            this.takeNewOrderButton.Text = "Take New Order";
            this.takeNewOrderButton.UseVisualStyleBackColor = true;
            this.takeNewOrderButton.Click += new System.EventHandler(this.TakeNewOrderButton_Click_1);
            // 
            // showCustAdd2
            // 
            this.showCustAdd2.AutoSize = true;
            this.showCustAdd2.Location = new System.Drawing.Point(431, 135);
            this.showCustAdd2.Name = "showCustAdd2";
            this.showCustAdd2.Size = new System.Drawing.Size(41, 13);
            this.showCustAdd2.TabIndex = 32;
            this.showCustAdd2.Text = "label10";
            // 
            // showCustAdd3
            // 
            this.showCustAdd3.AutoSize = true;
            this.showCustAdd3.Location = new System.Drawing.Point(431, 169);
            this.showCustAdd3.Name = "showCustAdd3";
            this.showCustAdd3.Size = new System.Drawing.Size(41, 13);
            this.showCustAdd3.TabIndex = 33;
            this.showCustAdd3.Text = "label11";
            // 
            // orderHistButton
            // 
            this.orderHistButton.Location = new System.Drawing.Point(315, 408);
            this.orderHistButton.Name = "orderHistButton";
            this.orderHistButton.Size = new System.Drawing.Size(174, 23);
            this.orderHistButton.TabIndex = 34;
            this.orderHistButton.Text = "View Order History";
            this.orderHistButton.UseVisualStyleBackColor = true;
            this.orderHistButton.Click += new System.EventHandler(this.OrderHistButton_Click);
            // 
            // sortAscButton
            // 
            this.sortAscButton.Location = new System.Drawing.Point(12, 398);
            this.sortAscButton.Name = "sortAscButton";
            this.sortAscButton.Size = new System.Drawing.Size(92, 23);
            this.sortAscButton.TabIndex = 35;
            this.sortAscButton.Text = "Sort Ascending";
            this.sortAscButton.UseVisualStyleBackColor = true;
            this.sortAscButton.Click += new System.EventHandler(this.SortAscButton_Click);
            // 
            // sortDescButton
            // 
            this.sortDescButton.Location = new System.Drawing.Point(110, 398);
            this.sortDescButton.Name = "sortDescButton";
            this.sortDescButton.Size = new System.Drawing.Size(99, 23);
            this.sortDescButton.TabIndex = 36;
            this.sortDescButton.Text = "Sort Descending";
            this.sortDescButton.UseVisualStyleBackColor = true;
            this.sortDescButton.Click += new System.EventHandler(this.SortDescButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortDescButton);
            this.Controls.Add(this.sortAscButton);
            this.Controls.Add(this.orderHistButton);
            this.Controls.Add(this.showCustAdd3);
            this.Controls.Add(this.showCustAdd2);
            this.Controls.Add(this.takeNewOrderButton);
            this.Controls.Add(this.showCustSA);
            this.Controls.Add(this.showCustSQ);
            this.Controls.Add(this.showCustDisc);
            this.Controls.Add(this.showCustEmail);
            this.Controls.Add(this.showCustPhone);
            this.Controls.Add(this.showCustAdd1);
            this.Controls.Add(this.showCustPCode);
            this.Controls.Add(this.showCustName);
            this.Controls.Add(this.showCustNum);
            this.Controls.Add(this.custListBox);
            this.Controls.Add(this.addNewCustButton);
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
            this.Load += new System.EventHandler(this.CustomerForm_Load);
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
        private Button addNewCustButton;
        private ListBox custListBox;
        private Label showCustNum;
        private Label showCustName;
        private Label showCustPCode;
        private Label showCustAdd1;
        private Label showCustPhone;
        private Label showCustEmail;
        private Label showCustDisc;
        private Label showCustSQ;
        private Label showCustSA;
        private Button takeNewOrderButton;
        private Label showCustAdd2;
        private Label showCustAdd3;
        private Button orderHistButton;
        private Button sortAscButton;
        private Button sortDescButton;
    }
}