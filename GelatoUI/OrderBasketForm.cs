using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelatoUI
{
    public partial class OrderBasketForm : Form
    {
        Customer cust;
        OrderBasket ob;
        public OrderBasketForm(Customer customer)
        {
            InitializeComponent();
            cust = customer;
            ob = new OrderBasket();
            Gelato2UEntitiesA db = new Gelato2UEntitiesA();
            List<Product> pl = db.Products.ToList();
            label2.Text = cust.CustomerName;
            productNameBox.DataSource = pl;
            productNameBox.DisplayMember = "ProductName";
            checkOutButton.Enabled = false;
            clearButton.Enabled = false;
            removeButton.Enabled = false;
        }

        private void OrderBasketForm_Load(object sender, EventArgs e)
        {



        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int quantity;

            Product product = (Product)productNameBox.SelectedItem;
            quantity = (int)quantityCounter.Value;
            ob.AddProduct(product.ProductNumber, product.ProductName, product.Price, product.RecommendedRetailPrice, quantity, product.Description);
            BasketItemsToListView();

        }
        public void BasketItemsToListView()
        {
            basketListView.Items.Clear();

            numOfItems.Text = ob.NumberOfItems.ToString();
            numOfProducts.Text = ob.NumberOfProducts.ToString();
            totalBox.Text = string.Format("{0:C2}", ob.BasketTotal);
            discTotal.Text = string.Format("{0:C2}", ob.BasketTotal);

            //if (ob.NumberOfItems == 0)
            //{ //set buttons to disabled if nothing in the basket
            //    checkOutButton.Enabled = false;
            //    clearButton.Enabled = false;
            //    removeButton.Enabled = false;
            //    return;
            //}

            //Using ListView Control to display basket contents
            foreach (BasketItem bItem in ob.BasketItems)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    bItem.ProductNumber.ToString(),
                    bItem.ProductName,
                    bItem.Quantity.ToString(),
                    bItem.Price.ToString("C2"),
                    bItem.totalValueOfBasketItem.ToString("C2"),
                    bItem.Description
                });

                basketListView.Items.Add(item);
            }

            //Using Datagrid and databinding to display basket content
            //Note: The nasty kludge of setting DataSource to null to
            //ensure it refreshes and displays the current basket state
            //basketItemsDataGridView.DataSource = null;
            //basketItemsDataGridView.DataSource = ob.BasketItems;

            clearButton.Enabled = true;
            checkOutButton.Enabled = true;

        }


        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult clearResponse = MessageBox.Show("Are you sure you want to clear the basket?", "Clear Basket", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (clearResponse == DialogResult.Yes)
            {
                ClearBasket();
            }
        }

        private void ClearBasket()
        {
        //    orderBasket.ClearBasket();
         //   txtTotal.Clear();
         //   numberOfItemsTextBox.Clear();
         //   BasketItemsToListView();
          //  deliverRadioButton.Checked = false;
          //  collectRadioButton.Checked = false;
        }

        private void ProductNameBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            priceTextBox.Text = string.Format("{0:C}", ((Product)productNameBox.SelectedItem).Price);
            descriptionTextBox.Text = ((Product)productNameBox.SelectedItem).Description;
            var discount = (((Product)productNameBox.SelectedItem).Price) * cust.Discount/100;
            discountBox.Text = discount.ToString();
        }

    }
}
