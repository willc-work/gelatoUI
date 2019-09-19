using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GelatoUI
{
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            TextBox[] newTextBox = { nameBox, secQuestBox, secAnswerBox, postcodeBox, emailBox };
            for (int i = 0; i < newTextBox.Length; i++)
            {
                if (newTextBox[i].Text == string.Empty)
                {
                    MessageBox.Show("Please fill the text box");
                    newTextBox[i].Focus();
                    return;
                }
            }

            TextBox[] newIntBox = { phoneNumberBox };
            for (int i = 0; i < newIntBox.Length; i++)
            {
                if (newIntBox[i].Text == string.Empty)
                {
                    MessageBox.Show("Please fill the text box");
                    newIntBox[i].Focus();
                    return;
                }
            }

            //bool eCheck = IsValidEmail(emailBox.Text);
            //if (!eCheck)
            //{
            //    MessageBox.Show("Please Enter a valid email address in the format e.g abcdef@gmail.com");
            //}
    
            //bool pCheck = IsValidPostcode(postcodeBox.Text);
            //if (!pCheck)
            //{
            //    MessageBox.Show("Please Enter a valid Postcode e.g AB123XY");
            //}

            //WORKING VALUDATION BELOW - not great way to do it
            //if (nameBox.Text == string.Empty)
            //{
            //    MessageBox.Show("Please enter a Customer Name!");
            //    return;
            //}
            //else if (secQuestBox.Text == string.Empty)
            //{
            //    MessageBox.Show("Please Add a Security Question!");
            //    return;
            //}

            //else if (secAnswerBox.Text == string.Empty)
            //{
            //    MessageBox.Show("Please Add a Security Answer");
            //    return;
            //}

            Gelato2UEntitiesA db = new Gelato2UEntitiesA();

            Customer customer = new Customer
            {
                CustomerName = nameBox.Text,
                AddressLine1 = addressBox.Text,
                Postcode = postcodeBox.Text,
                Phone = phoneNumberBox.Text,
                Email = emailBox.Text,
                SecurityQuestion = secQuestBox.Text,
                SecurityQuestionAnswer = secAnswerBox.Text
            };


            if (validateCheck())
            {
                db.Customers.Add(customer);


                try
                {

                    db.SaveChanges();
                    MessageBox.Show("New Customer Details Saved");
                    this.Hide();
                    CustomerForm cf = new CustomerForm();
                    cf.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to Save new Cutomer");
                }
            }//end of validationcheck
            else
            {
                MessageBox.Show("Failed Validation");
            }
        }

        public bool validateCheck()
        {
            bool eCheck = IsValidEmail(emailBox.Text);
            if (!eCheck)
            {
                MessageBox.Show("Please Enter a valid email address in the format e.g abcdef@gmail.com");
                return false;
            }

            bool pCheck = IsValidPostcode(postcodeBox.Text);
            if (!pCheck)
            {
                MessageBox.Show("Please Enter a valid Postcode e.g AB12XY");
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public static bool IsValidPostcode(string inputPostcode)
        {
            inputPostcode.ToUpper();
            string strRegex = @"^(A([A-Z][A-HJ-Y]?[0-9][A-Z0-9]?[0-9][A-Z]{2}|GIR?0A{2})\z)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputPostcode))
                return (true);
            else
                return (false);
        }

    }
}
