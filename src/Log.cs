using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2P
{
    class Log
    {
        public static Log log = new Log();

        private Log() { }
        /// <summary>
        /// This function saves user information, button name and time.
        /// </summary>
        /// <param name="username">This parameter holds the username.</param>
        /// <param name="button_name">This parameter holds the button name.</param>
        /// <param name="dateTime">This parameter holds the date.</param>
        /// <returns> This function does not return a value </returns>
        public void WriteLog(string username, string button_name, DateTime dateTime)
        {
            string logMessage = $"Username: {username}, Button Name: {button_name}, Date: {dateTime.ToString()}";
            try
            {
                using (StreamWriter writer = File.AppendText("Customer.log"))
                {
                    writer.WriteLine(logMessage);
                    writer.Close();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be write:");
            }
        }
    }
}
