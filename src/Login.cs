using OOP2P.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2P
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        #region --buttons--
        /// <summary>
        /// This function load Signup Form when user clik the Signup button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signupForm = new Signup();
            signupForm.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// This function provdes to control user login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //check if the username which is passed to function if it is empty throw exception
                if (String.IsNullOrEmpty(txtLoginUsername.Text) || String.IsNullOrEmpty(txtLoginPassword.Text))
                {
                    throw new Exception("Customer username or password is empty. Please put a username or password.");
                }

                if (Util.UtilCustomer.isValidCustomer(txtLoginUsername.Text) && Util.UtilCustomer.IsPasswordValid(txtLoginPassword.Text))
                {
                    CustomerRepo customerRepo = new CustomerRepo();
                    LoginedCustomer.Instance().Customer = customerRepo.GetCustomerByUsername(txtLoginUsername.Text);
                    this.Hide();
                    FormMainPage mainPage = FormMainPage.Instance;
                    mainPage.CustomerId = LoginedCustomer.Instance().Customer.Id;
                    mainPage.Show();
                }
                else
                {
                    MessageBox.Show("Could not find user. Invalid username or password");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
