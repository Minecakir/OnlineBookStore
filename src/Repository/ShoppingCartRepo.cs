using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2P.Repository
{
    class ShoppingCartRepo
    {
        private DbConnection connection = new DbConnection();
        ItemToPurchaseRepo adp = new ItemToPurchaseRepo();
        ProductRepo prr = new ProductRepo();

        /// <summary>
        /// This function is initializer for spesific database operations.  
        /// <param name="customerId">This parameter is id of the customer to get card information.</param>
        /// <param name="status">This parameter represents the type of wanted carts active("=") or previous("!=").</param>
        /// </summary>
        /// <returns>dataTable</returns>
        private DataTable initializer(int customerId, string status)
        {
            try
            {
                DataTable cartIdTable = new DataTable();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("Select cart_id, payment_type From ShoppingCart where customer_id = " + customerId.ToString() + " AND payment_type " + status + " 'NOTSPECIFIED'", connection.Connection);
                da.Fill(cartIdTable);
                return cartIdTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This function returns shopping cart based on customer id and cart status(active, previous).  
        /// <param name="customerId">This parameter is id of the customer to get card information.</param>
        /// <param name="status">This parameter represents the type of wanted carts active("=") or previous("!=").</param>
        /// <param name="index">This parameter is index of wanted cart in data table.</param>
        /// <param name="cartID">This parameter is id of the wanted shopping cart.</param>
        /// </summary>
        /// <returns>shopping cart</returns>
        private ShoppingCart fillCartByIndex(int index, int customerId, string status, int cartID)
        {
            try
            {
                DataTable itemsTable = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter("Select Product.product_id, Product.product_type, Product.sub_id, ItemToPurchase.quantity " +
                    "From ShoppingCart " +
                    "INNER JOIN ItemToPurchase on ShoppingCart.cart_id = ItemToPurchase.cart_id " +
                    "INNER JOIN Product on ItemToPurchase.product_id = Product.product_id " +
                    "where customer_id = " + customerId.ToString() + " AND payment_type" + status + "'NOTSPECIFIED' AND ShoppingCart.cart_id = " + cartID.ToString(), connection.Connection);

                da.Fill(itemsTable);

                ShoppingCart shoppingCart = new ShoppingCart();

                if (itemsTable.Rows.Count == 0) return shoppingCart;

                for (int i = 0; i < itemsTable.Rows.Count; i++)
                {
                    Product product;
                    string dataType = itemsTable.Rows[i]["product_type"].ToString();
                    int pId = Convert.ToInt32(itemsTable.Rows[i]["sub_id"]);
                    dataType = dataType.Replace(" ", "");

                    if (dataType == "BOOK")
                    {
                        product = prr.bookById(pId);
                    }
                    else if (dataType == "MAGAZINE")
                    {
                        product = prr.magazineById(pId);
                    }
                    else if (dataType == "MUSICCD")
                    {
                        product = prr.musicCDById(pId);
                    }
                    else
                    {
                        product = null;
                    }
                    shoppingCart.addProduct(new ItemToPurchase(product, Convert.ToInt32(itemsTable.Rows[i]["quantity"])));
                }
                return shoppingCart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This function writes needen informations to shopping cart.  
        /// <param name="shoppingCart">This parameter is shopping cart we wanted to fill informations.</param>
        /// <param name="payment_type">This parameter is payment type of shopping cart.</param>
        /// <param name="cartID">This parameter is id of the shopping cart.</param>
        /// </summary>
        private void fillCartProp(ref ShoppingCart shoppingCart, int cartID, string payment_type)
        {
            payment_type = payment_type.Replace(" ", "");
            shoppingCart.PaymentType = new PaymentTypes(payment_type);
            shoppingCart.CartID = cartID;
            for (int i = 0; i < shoppingCart.ItemsToPurchase.Count; i++)
            {
                shoppingCart.PaymentAmount += shoppingCart.ItemsToPurchase[i].Product.Price * shoppingCart.ItemsToPurchase[i].Quantity;
            }
        }
        /// <summary>
        /// This function returns active shopping cart based on customer id.  
        /// <param name="customerId">This parameter is id of the customer to get card information.</param>
        /// </summary>
        /// <returns>shopping cart</returns>
        public ShoppingCart getActiveCart(int customerId)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = initializer(customerId, "=");

                int cartID = Convert.ToInt32(dataTable.Rows[0]["cart_id"]);
                ShoppingCart tempCart = fillCartByIndex(0, customerId, "=", cartID);
                fillCartProp(ref tempCart, cartID, dataTable.Rows[0]["payment_type"].ToString());

                connection.CloseConnection();
                return tempCart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This function returns previous shopping cart(s) based on customer id.  
        /// <param name="customerId">This parameter is id of the customer to get card information.</param>
        /// </summary>
        /// <returns>previous shopping cart list</returns>
        public List<ShoppingCart> getPreviousCarts(int customerId)
        {
            try
            {
                List<ShoppingCart> orderList = new List<ShoppingCart>();
                DataTable dataTable = new DataTable();
                dataTable = initializer(customerId, "!=");

                int cartID;
                ShoppingCart tempCart;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cartID = Convert.ToInt32(dataTable.Rows[i]["cart_id"]);
                    tempCart = fillCartByIndex(i, customerId, "!=", cartID);
                    fillCartProp(ref tempCart, cartID, dataTable.Rows[i]["payment_type"].ToString());
                    orderList.Add(tempCart);
                }

                connection.CloseConnection();
                return orderList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This function creates an active shopping cart if there is not.  
        /// <param name="customerId">This parameter is id of the customer to get card information.</param>
        /// </summary>
        /// <returns>id of the cart (created or existed)</returns>
        public int createActiveCartIfThereIsNo(int customer_id)
        {
            try
            {
                DataTable itemsTable = new DataTable();
                adp = new ItemToPurchaseRepo();
                itemsTable.Clear();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("Select cart_id From ShoppingCart where customer_id = " +
                    customer_id.ToString() + " AND payment_type = 'NOTSPECIFIED'", connection.Connection);
                da.Fill(itemsTable);

                if (itemsTable.Rows.Count == 0)
                {
                    SqlCommand command = new SqlCommand("Insert into ShoppingCart (customer_id, payment_type) Values(" + customer_id.ToString() + ", 'NOTSPECIFIED')", connection.Connection);
                    command.ExecuteNonQuery();
                }
                da = new SqlDataAdapter("Select cart_id From ShoppingCart where customer_id = " +
                    customer_id.ToString() + " AND payment_type = 'NOTSPECIFIED'", connection.Connection);
                itemsTable.Clear();
                da.Fill(itemsTable);
                connection.CloseConnection();
                return Convert.ToInt32(itemsTable.Rows[0]["cart_id"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        /// <summary>
        /// This function makes the shopping cart purchased.  
        /// <param name="cart_id">This parameter is id of the cart.</param>
        /// <param name="payment_type">This parameter is payment type of the cart.</param>
        /// </summary>
        public void sendToOrders(int cart_id, string payment_type)
        {
            try
            {
                connection.OnConnection();
                connection.OpenConnection();
                SqlCommand command = new SqlCommand("Update ShoppingCart Set payment_type = '" + payment_type + "' Where cart_id = " + cart_id.ToString(), connection.Connection);

                command.ExecuteNonQuery();
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function cancels a previous shopping cart (order).  
        /// <param name="cart_id">This parameter is id of the cart.</param>
        /// </summary>
        public void cancelOrder(int cart_id)
        {
            try
            {
                connection.OnConnection();
                connection.OpenConnection();
                SqlCommand command = new SqlCommand("DELETE [ItemToPurchase] FROM[ShoppingCart] " +
                    "INNER JOIN[ItemToPurchase] on[ShoppingCart].[cart_id] = [ItemToPurchase].[cart_id]" +
                    "WHERE[ItemToPurchase].[cart_id] = " + cart_id.ToString() + ";" +

                    "DELETE[ShoppingCart] FROM[ShoppingCart] WHERE[ShoppingCart].[cart_id] = " + cart_id.ToString(),
                    connection.Connection);

                command.ExecuteNonQuery();
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function deletes shopping cart if it is empty.  
        /// <param name="cart_id">This parameter is id of the cart.</param>
        /// </summary>
        public void deleteIfEmpty(int cart_id)
        {
            try
            {
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT cart_id FROM ItemToPurchase WHERE cart_id = " + cart_id.ToString(), connection.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    SqlCommand command = new SqlCommand("DELETE ShoppingCart FROM ShoppingCart where cart_id = " + cart_id.ToString(), connection.Connection);
                    command.ExecuteNonQuery();
                }
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
