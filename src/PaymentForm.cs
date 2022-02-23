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
    public partial class PaymentForm : Form
    {
        FormMainPage mainPage = FormMainPage.Instance;
        ShoppingCart cart;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param ShoppingCart = _cart></param>
        public PaymentForm(ShoppingCart _cart)
        {
            cart = _cart;
            InitializeComponent();
            cart.PaymentType = new PaymentTypes("CASH");
            radioButtonEmail.Checked = true;
            radioButtonCash.Checked =true;
        }
        /// <summary>
        /// This function approves payment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApprove_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonPaymentApprove", DateTime.Now);

            if (textBoxBilgiler.Text =="")
            {
                MessageBox.Show("Please enter address information!");
                return;
            }
            if (radioButtonCreditCart.Checked)
            {
                if(textBoxCardNumber.Text=="" || textBoxExpDate.Text==""||textBoxCVV.Text=="")
                {
                    MessageBox.Show("Please enter card information!");
                    return;
                }
            }
            if (radioButtonSms.Checked)
            {
                if (textBoxPhoneNumber.Text=="")
                {
                    MessageBox.Show("Please enter phone number!");
                    return;
                }
                cart.sendInvoicebySMS();
            }
            if(radioButtonEmail.Checked)
            {
                cart.sendInvoicebyEmail();
            }
            Repository.ShoppingCartRepo repo = new Repository.ShoppingCartRepo();
            cart.placeOrder();
            repo.createActiveCartIfThereIsNo(mainPage.CustomerId);
            this.Close();
        }

        /// <summary>
        /// This function cancel payment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonPaymentCancel", DateTime.Now);

            this.Close();
        }

        private void PaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainPage.loadshoppingCartPage();
        }
        /// <summary>
        /// This function moderates components
        /// </summary>
        private void radioButtonChanged()
        {
            groupBoxCardInfo.Visible = radioButtonCreditCart.Checked;
            label1.Visible = radioButtonSms.Checked;
            textBoxPhoneNumber.Visible = radioButtonSms.Checked;
        }

        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonChanged();
        }

        private void radioButtonEmail_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonChanged();
        }

        private void radioButtonSms_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonChanged();
        }

        private void radioButtonCreditCart_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonChanged();
        }
    }
}
