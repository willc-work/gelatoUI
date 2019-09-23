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
        }

        [System.ComponentModel.Browsable(false)]
public System.Collections.IComparer ListViewItemSorter { get; set; }

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
            label1.Text = customer.CustomerNumber.ToString();
            label2.Text = customer.CustomerName;
            label4.Text = customer.AddressLine1;
            label4.Text = customer.AddressLine1;
            label10.Text = customer.AddressLine2;
            label11.Text = customer.AddressLine3;
            label3.Text = customer.Postcode;
            label5.Text = customer.Phone;
            label6.Text = customer.Email;
            label7.Text = customer.Discount.ToString();
            label8.Text = customer.SecurityQuestion;
            label9.Text = customer.SecurityQuestionAnswer;
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

        private void SortAscButton_Click(object sender, EventArgs e)
        {
            if (this.custListBox.SelectedIndex > 0)
            {
                int selectedIndex = this.custListBox.SelectedIndex;
                object selectedItem = this.custListBox.SelectedItem;

                this.custListBox.Items.RemoveAt(selectedIndex);
                this.custListBox.Items.Insert(selectedIndex - 1, selectedItem);

                this.custListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        private void SortDescButton_Click(object sender, EventArgs e)
        {
            if (this.custListBox.SelectedIndex > -1 &&
            this.custListBox.SelectedIndex < this.custListBox.Items.Count - 1)
            {
                int selectedIndex = this.custListBox.SelectedIndex;
                object selectedItem = this.custListBox.SelectedItem;

                this.custListBox.Items.RemoveAt(selectedIndex);
                this.custListBox.Items.Insert(selectedIndex + 1, selectedItem);

                this.custListBox.SelectedIndex = selectedIndex + 1;
            }
        }
        //search for customers in the listbox
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ////string myString = custListBox.Text;
            ////bool found = false;
            ////for (int i = 0; i <= custListBox.Items.Count - 1; i++)
            ////{
            ////    if (custListBox.Items[i].ToString().Contains(myString))
            ////    {
            ////        custListBox.SetSelected(i, true);
            ////        found = true;
            ////        break;
            ////    }
            ////}
            ////if (!found)
            ////{
            ////    MessageBox.Show("Customer not found. Please use the 'Add New' button to register a new customer");
            ////}
        }
    }
}
