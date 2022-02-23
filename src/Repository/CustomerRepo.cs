using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2P.Repository
{
    class CustomerRepo
    {
        private DbConnection connection = new DbConnection();
        private DataTable customerTable = new DataTable();
        private Customer customer;
        private List<Customer> customers = new List<Customer>();



        /// <summary>
        /// This function is getting customers from database and return them in the list. 
        /// </summary>
        /// <returns>customers</returns>
        public List<Customer> GetAllCustomers()
        {
            try
            {
                customerTable.Clear();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Customer", connection.Connection);
                da.Fill(customerTable);
                connection.CloseConnection();
                for (int i = 0; i < customerTable.Rows.Count; i++)
                {
                    customer = new Customer((int)customerTable.Rows[i]["id"], customerTable.Rows[i]["name"].ToString(), customerTable.Rows[i]["adress"].ToString(), customerTable.Rows[i]["email"].ToString(), customerTable.Rows[i]["username"].ToString(), customerTable.Rows[i]["password"].ToString());
                    customers.Add(customer);
                }
                //Check if could not get customers from database
                if (!customers.Any())
                {
                    throw new Exception("Something went wrong! Could not get customers.");
                }
                return customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        /// <summary>
        /// This function is for adding customers to the database.    
        /// </summary>
        /// <param name="customer">This parameter is customer that will be save to database.</param>
        public void SaveCustomer(Customer customer)
        {   
            //check if the customer which is passed to function if it is empty throw exception
            if (customer.Equals(null))
            {
                throw new Exception("Customer is null, please set fields of customers");
            }
            try
            {
                connection.OnConnection();
                connection.OpenConnection();
                SqlCommand command = new SqlCommand("Insert into Customer(name,adress,email,username,password)values (@Name,@Address,@Email,@Username,@Password)", connection.Connection);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Address", customer.Address);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@Username", customer.Username);
                command.Parameters.AddWithValue("@Password", customer.Password);
                command.ExecuteNonQuery();
                connection.CloseConnection();
                MessageBox.Show("Registration successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// This function is for get customer from database by using username field.
        /// </summary>
        /// <param name="username">This parameter is username that will be help in sql query for find customer.</param>
        public Customer GetCustomerByUsername(string username)
        {
            try
            {
                CustomerRepo customerRepo = new CustomerRepo();
                List<Customer> customerList = customerRepo.GetAllCustomers();
                foreach(Customer customer in customerList)
                {
                    if (customer.Username == username){return customer;}
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// This function is for adding customers to the database.
        /// </summary>
        /// <param name="customer">This parameter is customer that will be save to database.</param>
        public string FindUsername(string username)
        {

            try
            {
                string responseUsername = "";
                connection.OnConnection();
                connection.OpenConnection();
                SqlCommand command = new SqlCommand("SELECT username FROM Customer  where username=@username", connection.Connection);
                command.Parameters.AddWithValue("@username", username);
                responseUsername = ((string)command.ExecuteScalar());
                connection.CloseConnection();
                return responseUsername;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
