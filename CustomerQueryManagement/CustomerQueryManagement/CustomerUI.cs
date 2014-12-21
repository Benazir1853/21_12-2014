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

namespace CustomerQueryManagement
{
    public partial class CustomerUI : Form
    {
        enum CustomerStatus
    {
        Not_Served,
        On_Served,
        Served
    }
        public CustomerUI()
        {
            InitializeComponent();
        }
        List<Customer> customers = new List<Customer>();
        string connectionString =
              @"Data Source= (LOCAL)\SQLEXPRESS; Database = CustomerDB; Integrated Security = true";
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            SaveData();
            ListView();
        
          
        }

        public void ShowNoOfCustomerServedToday()
        {
            SqlConnection aSqlConnection = new SqlConnection(connectionString);
            aSqlConnection.Open();
            string commandText = "SELECT COUNT(SerialNo) FROM tCustomers WHERE CustomerStatus = '"+CustomerStatus.Served+"'";
            SqlCommand aSqlCommand = new SqlCommand(commandText, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();
            aSqlDataReader.Read();
            int noOfServedCustomer = Convert.ToInt32(aSqlDataReader[0]);
            aSqlConnection.Close();
            servedLabel.Text = noOfServedCustomer.ToString();

        }

        private void SaveData()
        {
            Customer aCustomer = new Customer();
           
            aCustomer.name = nameEnqueueTextBox.Text;
            aCustomer.complain = complainEnqueueTextBox.Text;
           
          
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO tCustomers VALUES('" + aCustomer.name + "','" + aCustomer.complain + "','" +
                           CustomerStatus.Not_Served + "')";
            SqlCommand command = new SqlCommand(query, connection);
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowAffected > 0)
            {
                MessageBox.Show("Successfully Saved!");
            }
            else
            {
                MessageBox.Show("Couldn't Save the data ", " Error");
            }
        }


        private void ListView()
        {
            string connection = @"Data Source= (LOCAL)\SQLEXPRESS; Database = CustomerDB; Integrated Security = true";
            SqlConnection Connection = new SqlConnection(connection);
            Connection.Open();
            string newquery = "SELECT* FROM tCustomers WHERE CustomerStatus = '"+CustomerStatus.Not_Served+"' OR CustomerStatus = '"+CustomerStatus.On_Served+"'";
            SqlCommand newcommand = new SqlCommand(newquery, Connection);
            SqlDataReader reader = newcommand.ExecuteReader();
            
            List<Customer> customers = new List<Customer>();
           
            while (reader.Read())
            {
                Customer aCustomer = new Customer();
                aCustomer.serialNo = reader["SerialNo"].ToString();
                aCustomer.name = reader["CustomerName"].ToString();
                aCustomer.complain = reader["CustomerComplain"].ToString();
                aCustomer.status = reader["CustomerStatus"].ToString();

                customers.Add(aCustomer);
            }
            Connection.Close();
            customerListView.Items.Clear();
            foreach(Customer aCustomer in customers)
            {
                ListViewItem myView = new ListViewItem();


                myView.Text = (aCustomer.serialNo);
                myView.SubItems.Add(aCustomer.name);
                myView.SubItems.Add(aCustomer.complain);
                myView.SubItems.Add(aCustomer.status);


                customerListView.Items.Add(myView);
               
            }
            remainingLabel.Text = customers.Count.ToString();
            ShowNoOfCustomerServedToday();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ListView();
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            Customer customer1 = new Customer();

            customer1 = customers[0];
                

            serialDequeueTextBox.Text = customer1.serialNo;
            nameDequeueTextBox.Text = customer1.name;
            complainDequeueTextBox.Text = customer1.complain;
            customerListView.Items.RemoveAt(0);
        }
        }
    }

