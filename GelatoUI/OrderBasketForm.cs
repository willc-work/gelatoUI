using GelatoDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GelatoBusinessObjects;

namespace GelatoUI
{
    public partial class OrderBasketForm : Form
    {
        Customer cust;
        public static OrderBasket ob;
        public OrderBasketForm(Customer customer)
        {
            //set initial state of the form and reset counters
            InitializeComponent();
            cust = customer;
            ob = new OrderBasket();
            Gelato2UEntitiesA db = new Gelato2UEntitiesA();
            List<Product> pl = db.Products.ToList();
            label2.Text = cust.CustomerName;
            discValue.Text = cust.Discount.ToString()+"%";
            productNameBox.DataSource = pl;
            productNameBox.DisplayMember = "ProductName";
            checkOutButton.Enabled = false;
            clearButton.Enabled = false;
            removeButton.Enabled = false;
            numOfProducts.Text = "0";
            numOfItems.Text = "0";
            totalBox.Text = "£0.00";
            discTotal.Text = "£0.00";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //add item to the basket, include sanity check valudation for quantities
            int quantity;
            Product product = (Product)productNameBox.SelectedItem;
            quantity = (int)quantityCounter.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("No quantity has been selected", "Quantity Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return; //No items selected
            }

            if (quantity >= 25)
            {
                DialogResult quantityResponse = MessageBox.Show("You have selected a large amount is this correct?", "Quantity Invalid", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (quantityResponse == DialogResult.Yes)
                {
                    ob.AddItem(product.ProductNumber, product.ProductName, product.Price, product.RecommendedRetailPrice, quantity, product.Description);
                    BasketItemsToListView();
                }
                else
                {
                    quantityCounter.Value = 0;
                }
            }
            else
            {
                ob.AddItem(product.ProductNumber, product.ProductName, product.Price, product.RecommendedRetailPrice, quantity, product.Description);
                BasketItemsToListView();
            }



        }

        public void BasketItemsToListView()
        {
            //view the current contents of the basket and enable buttons when popualated
            basketListView.Items.Clear();
            basketListView.FullRowSelect = true;
            numOfItems.Text = ob.NumberOfItems.ToString();
            numOfProducts.Text = ob.NumberOfProducts.ToString();
            totalBox.Text = string.Format("{0:C2}", ob.BasketTotal);
            decimal orderCost = ob.BasketTotal - (ob.BasketTotal * cust.Discount / 100);
            orderCost.ToString();   
            discTotal.Text = string.Format("{0:C2}", orderCost);

            //Using ListView Control to display basket contents
            foreach (BasketItem bItem in ob.BasketItems)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    bItem.ProductNumber.ToString(),
                    bItem.ProductName,
                    bItem.Quantity.ToString(),
                    bItem.Price.ToString("C2"),
                    bItem.TotalValueOfBasketItem.ToString("C2"),
                    bItem.RecommendedRetailPrice.ToString("C2"),
                    bItem.Description
                });

                basketListView.Items.Add(item);
            }

            clearButton.Enabled = true;
            checkOutButton.Enabled = true;

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // sense check before clearing the basket
            DialogResult clearResponse = MessageBox.Show("Are you sure you want to clear the basket?", "Clear Basket", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (clearResponse == DialogResult.Yes)
            {
                ClearBasket();
                clearButton.Enabled = false;
                removeButton.Enabled = false;
            }
        }

        private void ClearBasket()
        {
            //reset all counters when the basket is cleared
            ob.ClearBasket();
            BasketItemsToListView();
            numOfProducts.Clear();
            totalBox.Clear();
            discTotal.Clear();
            numOfItems.Clear();
        }

        private void ProductNameBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            priceTextBox.Text = string.Format("{0:C}", ((Product)productNameBox.SelectedItem).Price);
            descriptionTextBox.Text = ((Product)productNameBox.SelectedItem).Description;
            var discount = (((Product)productNameBox.SelectedItem).Price) * cust.Discount/100;
            discountBox.Text = discount.ToString("C2");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (basketListView.SelectedItems.Count <= 0)
               return; 
            ob.RemoveItem(Int32.Parse(basketListView.SelectedItems[0].Text));
            BasketItemsToListView();
            removeButton.Enabled = false;
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (ob.NumberOfItems == 0)
            {
                MessageBox.Show("The basket is currently empty!", "Basket Empty", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            Gelato2UEntitiesA db = new Gelato2UEntitiesA();

            List<OrderItem> itemsToAdd = new List<OrderItem>();

            //create list populate with orderbasket
            foreach (BasketItem item in ob.BasketItems)
            {
                itemsToAdd.Add(new OrderItem
                {
                    ProductNumber = item.ProductNumber,
                    Quantity = item.Quantity
                });
            }

            //create an order object - needs to match the format of database table
            Order order = new Order
            {
                OrderDate = DateTime.Now,
                CustomerNumber = cust.CustomerNumber,
                CustomerDiscount = cust.Discount,
                OrderStatus = 1,
                OrderTotalBeforeDiscount = ob.BasketTotal,
                OrderItems = itemsToAdd
            };

            //save changes to db
            db.Orders.Add(order);
            db.SaveChanges();

            OrderHistoryForm ohf = new OrderHistoryForm(cust);
            ohf.Show();
            this.Hide();
        }

        private void BasketListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = true;
        }
    }
}
