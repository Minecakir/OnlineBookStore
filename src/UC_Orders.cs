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
    public partial class UC_Orders : UserControl
    {
        private FormMainPage mainForm = FormMainPage.Instance;
        private ShoppingCart cart;
        int index;
        public UC_Orders(int _index)
        {
            index = _index;
            InitializeComponent();
            cart = mainForm.PreviousOrders[index];
            labelCartID.Text = cart.CartID.ToString();
            display();
        }
        ///<summary>
        /// This function provides to displays orders information.
        ///</summary>
        ///
        private void display()
        {
            listViewItems.Items.Clear();
            for (int i = 0; i < cart.ItemsToPurchase.Count; i++)
            {
                ItemToPurchase item = (ItemToPurchase)cart.ItemsToPurchase[i];
                string[] row = { (i + 1).ToString(), item.Product.Name, item.Product.Price.ToString(), 
                    item.Quantity.ToString(), (item.Quantity*item.Product.Price).ToString()};
                listViewItems.Items.Add(new ListViewItem(row));
            }
        }
        /// <summary>
        /// This function cancel order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonCancelOrder", DateTime.Now);

            cart.cancelOrder();
            mainForm.loadOrdersPage();
        }
    }
}
