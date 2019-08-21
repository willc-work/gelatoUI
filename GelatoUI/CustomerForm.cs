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
            customerListBox.ClearSelected();
        }

        private void AddNewCustButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCustomer cc = new CreateCustomer();
            cc.ShowDialog();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderBasketForm ob = new OrderBasketForm();
            ob.ShowDialog();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            Gelato2UEntities db = new Gelato2UEntities();
            List<Customer> cl = db.Customers.ToList();
            


        }
    }
}
