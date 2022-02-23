using OOP2P.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2P
{
    public class Customer
    {
        private int id;
        private string name;
        private string address;
        private string mail;
        private string username;
        private string password;
        /// <summary>
        /// This function is constructor.
        /// </summary>
        /// <param name="id">This parameter is represent the customer id.</param>
        /// <param name="name">This parameter is represent name of customer.</param>
        /// <param name="address">This parameter is represent  address of customer.</param>
        /// <param name="mail">This parameter is represent mail of customer.</param>
        /// <param name="username">This parameter is represent username of customer.</param>
        /// <param name="password">This parameter is represent password of customer.</param>
        public Customer(int id, string name, string address, string mail, string username, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Email = mail;
            this.Username = username;
            this.Password = password;
        }
        #region --get_set--
        /// <summary>
        /// This functions are getters and setters.
        /// </summary>
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => mail; set => mail = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion
        /// <summary>
        /// This function print details of customer
        /// </summary>
        /// <returns> customer informations </returns>
        public string printCustomerDetails()
        {
            return "CustomerID:" + Id + " " + "Name:" + Name + " " + "Address:" + Address + " " +
                "Email:" + Email + " " + "Username" + Username + " " + "Password:" + Password;
        }
        /// <summary>
        /// This function checks username and password of user from database in customer table.
        /// </summary>
        /// <param name="username">This parameter is username of customer that is passed by customer.</param>
        /// <param name="password">This parameter is password of customer that is passed by customer.</param>
        /// <returns> true or false </returns>
        public bool IsValid(string username, string password)
        {
            return this.Username.Equals(username) && this.Password.Equals(password);
        }
        public void saveCustomer(Customer customer)
        {
            CustomerRepo customerRepo = new CustomerRepo();
            customerRepo.SaveCustomer(customer);
        }
    }
}
