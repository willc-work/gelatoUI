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
            this.selectButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addNewCustButton = new System.Windows.Forms.Button();
            this.custListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.takeNewOrderButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(12, 398);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(92, 23);
            this.selectButton.TabIndex = 18;
            this.selectButton.Text = "Select Customer";
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
            // custListBox
            // 
            this.custListBox.FormattingEnabled = true;
            this.custListBox.Location = new System.Drawing.Point(12, 12);
            this.custListBox.Name = "custListBox";
            this.custListBox.Size = new System.Drawing.Size(263, 368);
            this.custListBox.TabIndex = 22;
            this.custListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(537, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "label9";
            // 
            // takeNewOrderButton
            // 
            this.takeNewOrderButton.Location = new System.Drawing.Point(530, 409);
            this.takeNewOrderButton.Name = "takeNewOrderButton";
            this.takeNewOrderButton.Size = new System.Drawing.Size(213, 23);
            this.takeNewOrderButton.TabIndex = 31;
            this.takeNewOrderButton.Text = "Take New Order";
            this.takeNewOrderButton.UseVisualStyleBackColor = true;
            this.takeNewOrderButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(537, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "label11";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.takeNewOrderButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custListBox);
            this.Controls.Add(this.addNewCustButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.selectButton);
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
        private Button selectButton;
        private Button clearButton;
        private Button addNewCustButton;
        private ListBox custListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button takeNewOrderButton;
        private Label label10;
        private Label label11;
    }
}