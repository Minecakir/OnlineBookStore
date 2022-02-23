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
    class ItemToPurchaseRepo
    {
        private DbConnection connection = new DbConnection();
        /// <summary>
        /// This function returns the list of Items in specified shoppingcart.     
        /// </summary>
        /// <param name="cartId">This parameter is id of the shopping cart.</param>
        /// <returns>itemToPurchase list</returns>
        public List<ItemToPurchase> getItemsForCart(int cartId)
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<ItemToPurchase> itemsToPurchase = new List<ItemToPurchase>();
                ProductRepo pr = new ProductRepo();

                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("Select * From ItemToPurchase where cart_id = " + cartId.ToString(), connection.Connection);
                da.Fill(dataTable);
                connection.CloseConnection();

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ItemToPurchase itp = new ItemToPurchase(pr.ProductById(Convert.ToInt32(dataTable.Rows[i]["product_id"])), 
                        Convert.ToInt32(dataTable.Rows[i]["quantity"]));

                    itp.Product.Id = dataTable.Rows[i]["product_id"].ToString();
                    itemsToPurchase.Add(itp);
                }
                return itemsToPurchase;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        /// <summary>
        /// This function inserts an item to a specified shoppingcart.     
        /// </summary>
        /// <param name="cart_id">This parameter is id of the shopping cart.</param>
        /// <param name="product_id">This parameter is id of the product.</param>
        public void insertItemByCartId(int cart_id, int product_id)
        {
            try
            {
                connection.OnConnection();
                connection.OpenConnection();

                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From ItemToPurchase where cart_id = " + cart_id.ToString() +
                    " and product_id = " + product_id.ToString(), connection.Connection);
                da.Fill(dataTable);
                if (dataTable.Rows.Count != 0)
                {
                    updateQuantity(cart_id, product_id, Convert.ToInt32(dataTable.Rows[0]["quantity"]) + 1);
                }
                else
                {
                    SqlCommand command = new SqlCommand("Insert into ItemToPurchase(cart_id,quantity,product_id)values (@CID,@Quantity,@PID)", connection.Connection);
                    command.Parameters.AddWithValue("@CID", cart_id);
                    command.Parameters.AddWithValue("@Quantity", 1);
                    command.Parameters.AddWithValue("@PID", product_id);
                    command.ExecuteNonQuery();
                }
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This function deletes item from shoppingcart.     
        /// </summary>
        /// <param name="cart_id">This parameter is id of the shopping cart.</param>
        /// <param name="product_id">This parameter is id of the product.</param>
        public void deleteItemByCartId(int cart_id, int product_id)
        {
            try
            {
                connection.OnConnection();
                connection.OpenConnection();
                SqlCommand command = new SqlCommand("Delete From ItemToPurchase Where cart_id = " + cart_id.ToString() + "and product_id = " + product_id.ToString(), connection.Connection);

                command.ExecuteNonQuery();
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// This function updates quantity of an item in a shopping cart.     
        /// </summary>
        /// <param name="cart_id">This parameter is id of the shopping cart.</param>
        /// <param name="product_id">This parameter is id of the product.</param>
        /// <param name="new_quantity">This parameter is value of new quantity.</param>
        public void updateQuantity(int cart_id, int product_id, int new_quantity)
        {
            try
            {
                connection.OnConnection();
                connection.OpenConnection();
                SqlCommand command = new SqlCommand("Update ItemToPurchase Set quantity = " + new_quantity.ToString() + "Where product_id = " + product_id.ToString() + " and cart_id = " + cart_id.ToString(), connection.Connection);

                command.ExecuteNonQuery();
                connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
