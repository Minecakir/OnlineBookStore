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
    public partial class UC_MainProduct : UserControl
    {
        FormMainPage mainForm = FormMainPage.Instance;
        Product product;
        int index;
        ArrayList list = new ArrayList();
        public UC_MainProduct(int _index)
        {
            InitializeComponent();
            index = _index;
            product = mainForm.Products[index];

            list.Add(labelType);
            list.Add(labelName);
            list.Add(labelPrice);
            list.Add(pictureBoxProduct);
            list.Add(labelPr1);
            list.Add(labelPr2);

            product.Accept(ref list);
        }
        /// <summary>
        /// This function insert product into Orders.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonMainPurchase", DateTime.Now);

            Repository.ItemToPurchaseRepo connection = new Repository.ItemToPurchaseRepo();
            connection.insertItemByCartId(mainForm.ActiveShoppingCart.CartID, index + 1);
            MessageBox.Show("PURCHASED");
        }
    }
}
