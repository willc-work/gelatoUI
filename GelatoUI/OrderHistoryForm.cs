using GelatoDataLayer.Models;
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
    public partial class OrderHistoryForm : Form
    {
        public Customer CurrentCustomer { get; set; }
        public OrderHistoryForm(Customer currentCustomer)
        {
            InitializeComponent();
            CurrentCustomer = currentCustomer;
            getOrders();
        }

        private void getOrders()
        {
            //retrieve orders to populate the listview
            string statusText = "";
            Gelato2UEntitiesA db = new Gelato2UEntitiesA();
            List<Order> orders = db.Orders.Where(x=>x.CustomerNumber==CurrentCustomer.CustomerNumber).ToList();

            foreach (Order order in orders)

                if (order.OrderStatus == 1)
                {
                    ListViewItem item = new ListViewItem(new[]
                    {
                    order.OrderNumber.ToString(),
                    order.OrderDate.ToLongDateString(),
                    statusText = "Taken",
                    order.CustomerDiscount.ToString(),
                    order.OrderTotalBeforeDiscount.ToString("C2"),
                    order.OrderTotalBeforeDiscount.ToString("C2")
                });
                    orderHistoryListView.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new[]
                    {
                    order.OrderNumber.ToString(),
                    order.OrderDate.ToLongDateString(),
                    statusText = "Dispatched",
                    order.CustomerDiscount.ToString(),
                    order.OrderTotalBeforeDiscount.ToString("C2"),
                    order.OrderTotalBeforeDiscount.ToString("C2")
                });
                    orderHistoryListView.Items.Add(item);
                }
            {
                //ListViewItem item = new ListViewItem(new[]

                //{
                //    order.OrderNumber.ToString(),
                //    order.OrderDate.ToLongDateString(),
                //    statusText,
                //    order.CustomerDiscount.ToString(),
                //    order.OrderTotalBeforeDiscount.ToString("C2"),
                //    order.OrderTotalBeforeDiscount.ToString("C2")
                //});

               // orderHistoryListView.Items.Add(item);
                orderHistoryListView.FullRowSelect = true;
            }
        }

        private void getOrderDetails()
        {
            //retrieve individual order details to populate the listview
            orderDetailsList.Items.Clear();
            int orderNumber = int.Parse(orderHistoryListView.SelectedItems[0].Text);

            Gelato2UEntitiesA db = new Gelato2UEntitiesA();
            List<OrderItem> orderItems = db.OrderItems.Where(x => x.OrderNumber == orderNumber).ToList();

            foreach (OrderItem orderItem in orderItems)
            {
                Product product = db.Products.FirstOrDefault(x => x.ProductNumber == orderItem.ProductNumber);
                
                ListViewItem item = new ListViewItem(new[]
                {
                    orderItem.OrderNumber.ToString(),
                    orderItem.ProductNumber.ToString(),
                    product.ProductName,
                    orderItem.Quantity.ToString(),
                    product.Price.ToString("C"),
                    (orderItem.Quantity*product.Price).ToString("C")
                });

                orderDetailsList.Items.Add(item);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // when order is selected allow user to update the order details view
            getOrderDetails();
        }


        private void ReturnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.Show();
        }

    }
}
