using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace OOP2P
{
    public partial class UC_ShoppingCartProduct : UserControl
    {
        FormMainPage mainForm = FormMainPage.Instance;
        ItemToPurchase itp;
        int index;
        int amount;
        ArrayList list = new ArrayList();
        public UC_ShoppingCartProduct(int _index)
        {
            index = _index;
            InitializeComponent();

            itp = mainForm.ActiveShoppingCart.ItemsToPurchase[index];
            amount = itp.Quantity;

            list.Add(labelType);
            list.Add(labelName);
            list.Add(labelPrice);
            list.Add(pictureBoxProduct);
            list.Add(labelPr1);
            list.Add(labelPr2);
            list.Add(labelQuantity);
            list.Add(labelTPrice);

            itp.Accept(ref list);
        }
        #region --buttons--
        /// <summary>
        /// This function decrease product amonunt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPl_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonShoppingCartPlus", DateTime.Now);

            labelQuantity.Text = (++amount).ToString();
            labelTPrice.Text = (amount * itp.Product.Price).ToString() + " ₺";
        }
        /// <summary>
        /// This function increase product amonunt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMin_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonShoppingCartMinus", DateTime.Now);

            labelQuantity.Text = (--amount).ToString();
            labelTPrice.Text = (amount * itp.Product.Price).ToString() + " ₺";
        }
        /// <summary>
        /// This function delete item by cartId.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonShoppingCartDelete", DateTime.Now);

            Repository.ItemToPurchaseRepo itpc = new Repository.ItemToPurchaseRepo();
            itpc.deleteItemByCartId(mainForm.ActiveShoppingCart.CartID, Convert.ToInt32(itp.Product.Id));
            mainForm.loadshoppingCartPage();
        }
        /// <summary>
        /// This function save changes in ShoppingCart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonShoppingCartSave", DateTime.Now);

            Repository.ItemToPurchaseRepo itpc = new Repository.ItemToPurchaseRepo();
            itpc.updateQuantity(mainForm.ActiveShoppingCart.CartID, Convert.ToInt32(itp.Product.Id), amount);

            mainForm.loadshoppingCartPage();
        }
        #endregion
    }
}
