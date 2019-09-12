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
        SqlConnection cn = new SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Gelato2U;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
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

            custListView.View = View.Details;
            custListView.LabelEdit = true;
            custListView.AllowColumnReorder = true;
            custListView.FullRowSelect = true;
            custListView.GridLines = true;
            custListView.Sorting = System.Windows.Forms.SortOrder.Ascending;

            custListView.Columns.Add("Title", 300, HorizontalAlignment.Left);

            

            //private void LoadList()
            //{
            //    // Get the table from the data set
            //    DataTable dtable = _DataSet.Tables["Customers"];

            //    // Clear the ListView control
            //    custListView.Items.Clear();

            //    // Display items in the ListView control
            //    for (int i = 0; i < dtable.Rows.Count; i++)
            //    {
            //        DataRow drow = dtable.Rows[i];

            //        // Only row that have not been deleted
            //        if (drow.RowState != DataRowState.Deleted)
            //        {
            //            // Define the list items
            //            ListViewItem lvi = new ListViewItem(drow["CustomerName"].ToString());


            //            // Add the list items to the ListView
            //            custListView.Items.Add(lvi);
            //        }
            //    }
            //}


        }

    }
}
