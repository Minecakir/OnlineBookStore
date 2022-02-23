using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace OOP2P
{
    public class PaymentTypes
    {
        /// <summary>
        /// This functions are getters and setters for PaymentTypes.
        /// </summary>
        public PaymentTypes(string value) { Value = value; }
        public string Value { get;  set; }
        public static PaymentTypes CASH { get { return new PaymentTypes("CASH"); } }
        public static PaymentTypes CREDITCARD { get { return new PaymentTypes("CREDITCARD"); } }
        public static PaymentTypes NOTSPECIFIED { get { return new PaymentTypes("NOTSPECIFIED"); } }
    }
    public class ShoppingCart
    {
        private string customerID;
        private int cartID;
        private double paymentAmount;
        private PaymentTypes paymentType;
        private List<ItemToPurchase> itemsToPurchase;
        public ShoppingCart()
        {
            paymentType = PaymentTypes.NOTSPECIFIED;
            itemsToPurchase = new List<ItemToPurchase>();
        }
        /// <summary>
        /// This functions are getters and setters.
        /// </summary>
        #region --get_set--
        public string CustomerID { get => customerID; set => customerID = value; }
        public int CartID { get => cartID; set => cartID = value; }
        public double PaymentAmount { get => paymentAmount; set => paymentAmount = value; }
        public PaymentTypes PaymentType { get => paymentType; set => paymentType = value; }
        public List<ItemToPurchase> ItemsToPurchase { get => itemsToPurchase; set => itemsToPurchase = value; }
        #endregion
        ///<summary>
        /// This function provides to add item into itemstoPurchase.
        ///</summary>
        /// <param name="item"></param>
        ///
        public void addProduct(ItemToPurchase item)
        {
            itemsToPurchase.Add(item);
        }
        ///<summary>
        /// This function provides to remove product.
        ///</summary>
        /// <param name="index"></param>
        ///
        public void removeProduct(int index)
        {
            if(index>= itemsToPurchase.Count)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
            else
            {
                itemsToPurchase.RemoveAt(index);
            }
        }
        ///<summary>
        /// This function provides to call print function for items.
        ///</summary>
        ///
        public void printProducts()
        {
            foreach (ItemToPurchase item in itemsToPurchase)
            {
                item.print();
            }
        }
        ///<summary>
        /// This function provides to call senToOrders function for place order.
        ///</summary>
        ///
        public void placeOrder() 
        {
            Repository.ShoppingCartRepo scr = new Repository.ShoppingCartRepo();
            scr.sendToOrders(this.cartID, this.paymentType.Value);
        }
        ///<summary>
        /// This function provides to call cancel order function for cancel order.
        ///</summary>
        ///
        public void cancelOrder() {
            Repository.ShoppingCartRepo scr = new Repository.ShoppingCartRepo();
            scr.cancelOrder(this.cartID);
        }
        ///<summary>
        /// This function provides to send invoice by SMS.
        ///</summary>
        ///
        public void sendInvoicebySMS() {
            MessageBox.Show("HEMEN TELINI KONTROL ET ;)");
        }
        ///<summary>
        /// This function provides to send invoice by email.
        ///</summary>
        ///
        public void sendInvoicebyEmail() {
            var smtpClient = new SmtpClient()
            {
                Port = 587,
                Credentials = new NetworkCredential("yettimkitabevi@outlook.com", "4g42df6g242fd"),
                Host = "smtp.live.com",
                EnableSsl = true,
            };
            smtpClient.Send("yettimkitabevi@outlook.com", LoginedCustomer.Instance().Customer.Email, "Yettim Kitabevi Invoice",InvoiceInfo());
        }
        private string InvoiceInfo()
        {
            string message,row="";
            message = "Merhabalar yettim kitabevini tercih ettiğiniz için teşekkürler :) \n\n";
            for (int i = 0; i < ItemsToPurchase.Count; i++)
            {
                ItemToPurchase item = (ItemToPurchase)ItemsToPurchase[i];
                row +="("+ (i + 1).ToString()+")" +" Ürün adı:" +item.Product.Name+"  Fiyat:" + item.Product.Price.ToString() +"₺  Miktar: "+
                    item.Quantity.ToString() +" --> "+ (item.Quantity*item.Product.Price).ToString() + "\n";
            }
            row += "\n\n Toplam Fiyat: " + paymentAmount.ToString();
            return message+row;
        }
    }
    
}
