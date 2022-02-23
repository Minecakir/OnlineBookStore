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
    public partial class Signup : Form
    {
        Timer timer = new Timer();
        public Signup()
        {
            InitializeComponent();
        }
        private void Signup_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This function get calls when the btnSignup  got clicked.
        /// Moreover, save the customer if there is not any matched customer who has signed the system.
        /// </summary>
        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("There is empty field. Please make sure that you enter input for all fields.");
                    return;
                }
                if (!Util.UtilCustomer.isValidEmail(txtMail.Text))
                {
                    MessageBox.Show("Your email address is not verified.Please check your email.");
                    return;
                }
                if (Util.UtilCustomer.hasSameMailorUsername(txtMail.Text,txtSignupUsername.Text))
                {
                    MessageBox.Show("Email or username have already taken.Change your email  or username for sign up.");
                    return;
                }
                Customer newCustomer = new Customer(0,txtName.Text, txtAdress.Text, txtMail.Text, txtSignupUsername.Text, Util.UtilCustomer.ComputeSha256Hash(txtSignupPassword.Text));
                newCustomer.saveCustomer(newCustomer);
                timer1.Start();
                lblResult.Text = "Success!";
                lblResult.ForeColor = System.Drawing.Color.Green;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }
        /// <summary>
        /// This function provides to change form signup to login.
        /// </summary>     
        private void signupToLogin(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }
        /// <summary>
        /// This function exit from the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>            
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }
    }
}
