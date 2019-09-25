using System;
using System.Collections;
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
        Customer customer = new Customer();
        public CustomerForm()
        {
            InitializeComponent();
            sortDescButton.Enabled = false;
            sortAscButton.Enabled = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            custListBox.ClearSelected();
        }

        private void AddNewCustButton_Click(object sender, EventArgs e)
        {
            //extra functionality add new customer page
            this.Hide();
            CreateCustomerForm cc = new CreateCustomerForm();
            cc.ShowDialog();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            Gelato2UEntitiesA db = new Gelato2UEntitiesA();
            List<Customer> cl = db.Customers.ToList();
            custListBox.DataSource = cl;
            custListBox.DisplayMember ="CustomerName";
            takeNewOrderButton.Enabled = false;
            orderHistButton.Enabled = false;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //populate the page with customer details
            Customer customer = (Customer)custListBox.SelectedItem;
            showCustNum.Text = customer.CustomerNumber.ToString();
            showCustName.Text = customer.CustomerName;
            showCustAdd1.Text = customer.AddressLine1;
            showCustAdd2.Text = customer.AddressLine2;
            showCustAdd3.Text = customer.AddressLine3;
            showCustPCode.Text = customer.Postcode;
            showCustPhone.Text = customer.Phone;
            showCustEmail.Text = customer.Email;
            showCustDisc.Text = customer.Discount.ToString();
            showCustSQ.Text = customer.SecurityQuestion;
            showCustSA.Text = customer.SecurityQuestionAnswer;
            takeNewOrderButton.Enabled = true;
            orderHistButton.Enabled = true;
            custListBox.Sorted = true;
        }

        private void TakeNewOrderButton_Click_1(object sender, EventArgs e)
        {
            OrderBasketForm ob = new OrderBasketForm((Customer)custListBox.SelectedItem);
            ob.Show();
            this.Hide();
        }

        private void OrderHistButton_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)custListBox.SelectedItem;
            OrderHistoryForm ohf = new OrderHistoryForm(customer);
            ohf.Show();
            this.Hide();
        }

        // add a way for the user to sort the customer list in ascending and descending order
        private void SortAscButton_Click(object sender, EventArgs e)
        {
            //if (custListBox.SelectedIndex > 0)
            //{
            //    int selectedIndex = custListBox.SelectedIndex;
            //    object selectedItem = custListBox.SelectedItem;

            //    custListBox.Items.RemoveAt(selectedIndex);
            //    custListBox.Items.Insert(selectedIndex - 1, selectedItem);

            //    custListBox.SelectedIndex = selectedIndex - 1;
            //}
        }

        private void SortDescButton_Click(object sender, EventArgs e)
        {
            //if (custListBox.SelectedIndex > -1 &&
            //custListBox.SelectedIndex < custListBox.Items.Count - 1)
            //{
            //    int selectedIndex = custListBox.SelectedIndex;
            //    object selectedItem = custListBox.SelectedItem;

            //    custListBox.Items.RemoveAt(selectedIndex);
            //    custListBox.Items.Insert(selectedIndex + 1, selectedItem);

            //    custListBox.SelectedIndex = selectedIndex + 1;
            //}
        }

    }
}
