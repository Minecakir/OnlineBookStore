using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2P
{
   public class LoginedCustomer
    {
        private Customer customer;
        private static LoginedCustomer loginedCustomer;
        /// <summary>
        /// This function is getter and setter.
        /// </summary>
        public Customer Customer { get => customer; set => customer = value; }
        /// <summary>
        /// This function allows only one user can login into application.(Singleton Design Pattern)
        /// </summary>
        /// <returns> customer that logined </returns>
        public static LoginedCustomer Instance()
        {
            if (loginedCustomer == null)
            {
                loginedCustomer = new LoginedCustomer();
            }
            return loginedCustomer;
        }
    }
}
