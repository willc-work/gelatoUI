using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelatoUI
{
    public partial class CustomerForm : Form
    {
        
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            custListBox.ClearSelected();
        }

        private void AddNewCustButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCustomer cc = new CreateCustomer();
            cc.ShowDialog();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {

            //Customer cust = (Customer)custListBox.SelectedItem;
            //label1.Text = cust.CustomerNumber.ToString();
            //label2.Text = cust.CustomerName;
            //label3.Text = cust.Postcode;
            //label4.Text = cust.AddressLine1;
            //label5.Text = cust.Phone;
            //label6.Text = cust.Email;
            //label7.Text = cust.Discount.ToString();
            //label8.Text = cust.SecurityQuestion;
            //label9.Text = cust.SecurityQuestionAnswer;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            Gelato2UEntitiesA db = new Gelato2UEntitiesA();
            List<Customer> cl = db.Customers.ToList();
            custListBox.DataSource = cl;
            custListBox.DisplayMember ="CustomerName";

        }

        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = (Customer)custListBox.SelectedItem;
            label1.Text = customer.CustomerNumber.ToString();
            label2.Text = customer.CustomerName;
            label4.Text = customer.AddressLine1;
            label4.Text = customer.AddressLine1;
            label10.Text = customer.AddressLine2;
            label11.Text = customer.AddressLine3;
            label5.Text = customer.Phone;
            label6.Text = customer.Email;
            label7.Text = customer.Discount.ToString();
            label8.Text = customer.SecurityQuestion;
            label9.Text = customer.SecurityQuestionAnswer;
            //  takeOrderButton.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderBasketForm ob = new OrderBasketForm((Customer)custListBox.SelectedItem);
            ob.ShowDialog();
        }
    }
}
