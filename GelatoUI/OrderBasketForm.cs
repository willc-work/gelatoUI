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
        public OrderBasketForm()
        {
            InitializeComponent();
        }

        private void OrderBasketForm_Load(object sender, EventArgs e)
        {

            Gelato2UEntitiesA db = new Gelato2UEntitiesA();
            List<Product> pl = db.Products.ToList();
            listBox1.DataSource = pl;
            listBox1.DisplayMember = "Description";

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.ShowDialog();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
