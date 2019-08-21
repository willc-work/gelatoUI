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
            //ListBox listbox1 = new ListBox();
            //listbox1.Location = new System.Drawing.Point(20, 20);
            //listbox1.Name = "List from Code";
            //listbox1.Size = new System.Drawing.Size(300, 300);
            //listbox1.BackColor = Color.Green;
            //listbox1.ForeColor = Color.White;
            //listbox1.BorderStyle = BorderStyle.Fixed3D;
            //Controls.Add(listbox1);
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
            string connectionString;
            SqlConnection conn;
            connectionString = @"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            conn = new SqlConnection(connectionString);
            conn.Open();
            MessageBox.Show("Connected to Database");
            //    conn.Close();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql,Output = "";

            sql = "Select CustomerName, CustomerNumber from dbo.Customers";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(1) + "\n";
            }
            MessageBox.Show(Output);

        }
    }
}
