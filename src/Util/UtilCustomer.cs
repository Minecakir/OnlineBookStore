using OOP2P.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2P.Util
{
    class UtilCustomer
    {
        /// <summary>
        /// This function convert password to SHA256. 
        /// </summary>
        /// <param name="password">This parameter is password in string type.</param>
        /// <returns>This function returns hashed password</returns>
        public static string ComputeSha256Hash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        /// <summary>
        /// This function check is the email which is passed by user, is verified. 
        /// </summary>
        /// <param name="email">This parameter is email whcih has string data type</param>
        /// <returns>This function returns true or false</returns>
        public static bool isValidEmail(string email)
        {
            if (email.Equals(null))
            {
                throw new Exception("Your email is empty. Please check your email input!");
            }
            try
            {
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.CultureInvariant | RegexOptions.Singleline);
                bool isValidEmail = regex.IsMatch(email);
                return isValidEmail;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        /// <summary>
        /// This function check if the email and username have already taken from someone else. 
        /// </summary>
        /// <param name="email">This parameter is email whcih has string data type</param>
        /// <param name="username">This parameter is username whcih has string data type</param>
        /// <returns>This function returns true or false</returns>
        public static bool hasSameMailorUsername(string email,string username)
        {
            try
            {
                bool response = false;
                CustomerRepo customerRepo = new CustomerRepo();
                List<Customer> customerList = customerRepo.GetAllCustomers();
                foreach (Customer customer in customerList)
                {
                    //Check if there is any customer who has exact email or username. 
                    //If there is , it means that someone else already has taken account with that email or username.
                    if (customer.Email.Equals(email) || customer.Username.Equals(username))
                    {
                        response = true;
                        break;
                    }
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception("Something went wrong during the checking email if it is already taken.");
            }
        }

        /// <summary>
        /// This function check if the password is match or not
        /// </summary>
        /// <param name="password">This parameter is password whcih has string data type</param>
        public static bool IsPasswordValid(string password)
        {
            try
            {
                bool response = false;
                CustomerRepo customerRepo = new CustomerRepo();
                List<Customer> customerList = customerRepo.GetAllCustomers();
                foreach (Customer customer in customerList)
                {

                    if (customer.Password.Equals(ComputeSha256Hash(password)))
                    {
                        response = true;
                        break;
                    }
                }
                return response;
            }
            catch (Exception exception)
            {
                throw new Exception("Wrong password.");
            }
        }
        /// <summary>
        /// This function check if the user registered in the database. 
        /// </summary>
        /// <param name="username">This parameter is username whcih has string data type</param>
        /// <returns>This function returns true or false</returns>
        public static bool isValidCustomer(string username)
        {
            try
            {
                bool response = false;
                CustomerRepo customerRepo = new CustomerRepo();
                if (!String.IsNullOrEmpty(customerRepo.FindUsername(username)))
                {
                    response = true;
                }
                return response;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }
    }
}
