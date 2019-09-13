namespace GelatoUI
{
    partial class CreateCustomer
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
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addAddressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.postcodeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.secQuestLabel = new System.Windows.Forms.Label();
            this.secAnsLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.postcodeBox = new System.Windows.Forms.TextBox();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.secQuestBox = new System.Windows.Forms.TextBox();
            this.secAnswerBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(53, 27);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(82, 13);
            this.addNameLabel.TabIndex = 0;
            this.addNameLabel.Text = "Customer Name";
            // 
            // addAddressLabel
            // 
            this.addAddressLabel.AutoSize = true;
            this.addAddressLabel.Location = new System.Drawing.Point(53, 63);
            this.addAddressLabel.Name = "addAddressLabel";
            this.addAddressLabel.Size = new System.Drawing.Size(92, 13);
            this.addAddressLabel.TabIndex = 2;
            this.addAddressLabel.Text = "Customer Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(53, 197);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone Number";
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.AutoSize = true;
            this.postcodeLabel.Location = new System.Drawing.Point(53, 169);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.Size = new System.Drawing.Size(52, 13);
            this.postcodeLabel.TabIndex = 4;
            this.postcodeLabel.Text = "Postcode";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(52, 235);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email Address";
            // 
            // secQuestLabel
            // 
            this.secQuestLabel.AutoSize = true;
            this.secQuestLabel.Location = new System.Drawing.Point(52, 270);
            this.secQuestLabel.Name = "secQuestLabel";
            this.secQuestLabel.Size = new System.Drawing.Size(90, 13);
            this.secQuestLabel.TabIndex = 8;
            this.secQuestLabel.Text = "Security Question";
            // 
            // secAnsLabel
            // 
            this.secAnsLabel.AutoSize = true;
            this.secAnsLabel.Location = new System.Drawing.Point(52, 341);
            this.secAnsLabel.Name = "secAnsLabel";
            this.secAnsLabel.Size = new System.Drawing.Size(83, 13);
            this.secAnsLabel.TabIndex = 10;
            this.secAnsLabel.Text = "Security Answer";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(208, 27);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(247, 20);
            this.nameBox.TabIndex = 15;
            // 
            // postcodeBox
            // 
            this.postcodeBox.Location = new System.Drawing.Point(208, 162);
            this.postcodeBox.Name = "postcodeBox";
            this.postcodeBox.Size = new System.Drawing.Size(247, 20);
            this.postcodeBox.TabIndex = 17;
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(208, 194);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(247, 20);
            this.phoneNumberBox.TabIndex = 19;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(208, 228);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(247, 20);
            this.emailBox.TabIndex = 21;
            // 
            // secQuestBox
            // 
            this.secQuestBox.Location = new System.Drawing.Point(208, 270);
            this.secQuestBox.Name = "secQuestBox";
            this.secQuestBox.Size = new System.Drawing.Size(247, 20);
            this.secQuestBox.TabIndex = 23;
            // 
            // secAnswerBox
            // 
            this.secAnswerBox.Location = new System.Drawing.Point(208, 334);
            this.secAnswerBox.Name = "secAnswerBox";
            this.secAnswerBox.Size = new System.Drawing.Size(247, 20);
            this.secAnswerBox.TabIndex = 25;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(208, 63);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(247, 81);
            this.addressBox.TabIndex = 26;
            this.addressBox.Text = "";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(56, 388);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(188, 37);
            this.submitButton.TabIndex = 27;
            this.submitButton.Text = "Submit New Customer Details";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.secAnswerBox);
            this.Controls.Add(this.secQuestBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.postcodeBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.secAnsLabel);
            this.Controls.Add(this.secQuestLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.postcodeLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addAddressLabel);
            this.Controls.Add(this.addNameLabel);
            this.Name = "CreateCustomer";
            this.Text = "CreateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Label addAddressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label postcodeLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label secQuestLabel;
        private System.Windows.Forms.Label secAnsLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox postcodeBox;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox secQuestBox;
        private System.Windows.Forms.TextBox secAnswerBox;
        private System.Windows.Forms.RichTextBox addressBox;
        private System.Windows.Forms.Button submitButton;
    }
}