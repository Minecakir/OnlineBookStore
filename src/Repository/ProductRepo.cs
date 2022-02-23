using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace OOP2P.Repository
{
    class ProductRepo
    {
        private DbConnection connection = new DbConnection();

        #region --listByType--
        /// <summary>
        /// This function is for pulling the book list from the database.  
        /// </summary>
        /// <returns>product list</returns>
        public List<Product> BookList()
        {
            try
            {
                DataTable productTable = new DataTable();
                List<Product> productList = new List<Product>();
                productTable.Clear();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Book.name, Book.price, Product.product_id, Book.author, Book.publisher, Book.ISBN, Book.page " +
                    "FROM [Book] INNER JOIN Product on [Book].id = Product.sub_id " +
                    "WHERE Product.product_type = 'BOOK'", connection.Connection);
                da.Fill(productTable);
                connection.CloseConnection();
                for (int i = 0; i < productTable.Rows.Count; i++)
                {
                    Book book = new Book(productTable.Rows[i]["name"].ToString(), productTable.Rows[i]["product_id"].ToString(),
                    Convert.ToDouble(productTable.Rows[i]["price"]), productTable.Rows[i]["ISBN"].ToString(),
                    productTable.Rows[i]["author"].ToString(), productTable.Rows[i]["publisher"].ToString(),
                    Convert.ToInt32(productTable.Rows[i]["page"]));

                    productList.Add(book);
                }
                return productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This function is for pulling the magazine list from the database.  
        /// </summary>
        /// <returns>product list</returns>
        public List<Product> MagazineList()
        {
            try
            {
                DataTable productTable = new DataTable();
                List<Product> productList = new List<Product>();
                productTable.Clear();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Magazine.name, Magazine.price, Magazine.type, Magazine.issue, Product.product_id " +
                    "FROM[Magazine] INNER JOIN Product on [Magazine].id = Product.sub_id " +
                    "WHERE Product.product_type = 'MAGAZINE'", connection.Connection);
                da.Fill(productTable);
                connection.CloseConnection();
                for (int i = 0; i < productTable.Rows.Count; i++)
                {
                    Magazine magazine = new Magazine(productTable.Rows[i]["name"].ToString(), productTable.Rows[i]["product_id"].ToString(),
                    Convert.ToDouble(productTable.Rows[i]["price"]), productTable.Rows[i]["issue"].ToString(),
                    productTable.Rows[i]["type"].ToString());

                    productList.Add(magazine);
                }
                return productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This function is for pulling the music cd list from the database.  
        /// </summary>
        /// <returns>product list</returns>
        public List<Product> MusicCDList()
        {
            try
            {
                DataTable productTable = new DataTable();
                List<Product> productList = new List<Product>();
                productTable.Clear();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MusicCD.name, MusicCD.price, MusicCD.type, MusicCD.singer, Product.product_id " +
                    "FROM[MusicCD] INNER JOIN Product on [MusicCD].id = Product.sub_id " +
                    "WHERE Product.product_type = 'MUSICCD'", connection.Connection);
                da.Fill(productTable);
                connection.CloseConnection();
                for (int i = 0; i < productTable.Rows.Count; i++)
                {
                    MusicCD musicCD = new MusicCD(productTable.Rows[i]["name"].ToString(), productTable.Rows[i]["product_id"].ToString(),
                    Convert.ToDouble(productTable.Rows[i]["price"]), productTable.Rows[i]["singer"].ToString(),
                    productTable.Rows[i]["type"].ToString());

                    productList.Add(musicCD);
                }
                return productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion
        #region --itemById--
        /// <summary>
        /// This function is for pulling a book by id from the database.  
        /// <param name="id">This parameter is id of the wanted product.</param>
        /// </summary>
        /// <returns>book</returns>
        public Book bookById(int id)
        {
            try
            {
                DataTable productTable = new DataTable();
                productTable.Clear();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Book.name, Book.price, Product.product_id, Book.author, Book.publisher, Book.ISBN, Book.page " +
                    "FROM [Book] INNER JOIN Product on [Book].id = Product.sub_id " +
                    "WHERE Product.product_type = 'BOOK' and Book.id = " + id.ToString(), connection.Connection);
                da.Fill(productTable);
                connection.CloseConnection();

                Book book = new Book(productTable.Rows[0]["name"].ToString(), productTable.Rows[0]["product_id"].ToString(), 
                    Convert.ToDouble(productTable.Rows[0]["price"]), productTable.Rows[0]["ISBN"].ToString(),
                    productTable.Rows[0]["author"].ToString(), productTable.Rows[0]["publisher"].ToString(), 
                    Convert.ToInt32(productTable.Rows[0]["page"]));
                
                return book;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This function is for pulling a magazine by id from the database.  
        /// <param name="id">This parameter is id of the wanted product.</param>
        /// </summary>
        /// returns>magazine</returns>
        public Magazine magazineById(int id)
        {
            try
            {
                DataTable productTable = new DataTable();
                productTable.Clear();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Magazine.name, Magazine.price, Magazine.type, Magazine.issue, Product.product_id " +
                    "FROM[Magazine] INNER JOIN Product on [Magazine].id = Product.sub_id " +
                    "WHERE Product.product_type = 'MAGAZINE' and Magazine.id = " + id.ToString(), connection.Connection);
                da.Fill(productTable);
                connection.CloseConnection();

                Magazine magazine = new Magazine(productTable.Rows[0]["name"].ToString(), productTable.Rows[0]["product_id"].ToString(), 
                    Convert.ToDouble(productTable.Rows[0]["price"]), productTable.Rows[0]["issue"].ToString(), 
                    productTable.Rows[0]["type"].ToString());
                
                return magazine;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This function is for pulling a music cd by id from the database.  
        /// <param name="id">This parameter is id of the wanted product.</param>
        /// </summary>
        /// <returns>music cd</returns>
        public MusicCD musicCDById(int id)
        {
            try
            {
                DataTable productTable = new DataTable();
                productTable.Clear();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MusicCD.name, MusicCD.price, MusicCD.type, MusicCD.singer, Product.product_id " +
                    "FROM[MusicCD] INNER JOIN Product on [MusicCD].id = Product.sub_id " +
                    "WHERE Product.product_type = 'MUSICCD' and MusicCD.id = " + id.ToString(), connection.Connection);
                da.Fill(productTable);
                connection.CloseConnection();

                MusicCD musicCD = new MusicCD(productTable.Rows[0]["name"].ToString(), productTable.Rows[0]["product_id"].ToString(), 
                    Convert.ToDouble(productTable.Rows[0]["price"]), productTable.Rows[0]["singer"].ToString(), 
                    productTable.Rows[0]["type"].ToString());

                return musicCD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This function is for pulling any kind of product by id from the database.  
        /// <param name="id">This parameter is id of the wanted product.</param>
        /// </summary>
        /// <returns>product</returns>
        public Product ProductById(int id)
        {
            try
            {
                Product product;
                DataTable productTable = new DataTable();
                productTable.Clear();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Product Where product_id = " + id.ToString(), connection.Connection);
                da.Fill(productTable);
                connection.CloseConnection();

                string dataType = productTable.Rows[0]["product_type"].ToString();
                dataType = dataType.Replace(" ", "");
                int pId = Convert.ToInt32(productTable.Rows[0]["sub_id"]);

                if (dataType == "BOOK") { product = bookById(pId); }
                else if (dataType == "MAGAZINE") { product = magazineById(pId); }
                else if (dataType == "MUSICCD") { product = musicCDById(pId); }
                else { product = null; }

                return product;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        #endregion
        #region --listOfAllProducts--
        /// <summary>
        /// This function is for pulling all of the products from the database.  
        /// </summary>
        /// <returns>list of all products</returns>
        public List<Product> ProductList()
        {
            try
            {
                DataTable productTable = new DataTable();
                List<Product> productList = new List<Product>();
                Product product;

                productTable.Clear();
                connection.OnConnection();
                connection.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Product", connection.Connection);
                da.Fill(productTable);
                connection.CloseConnection();

                for (int i = 0; i < productTable.Rows.Count; i++)
                {
                    string dataType = productTable.Rows[i]["product_type"].ToString();
                    dataType = dataType.Replace(" ", "");
                    int pId = Convert.ToInt32(productTable.Rows[i]["sub_id"]);

                    if (dataType == "BOOK") { product = bookById(pId); }
                    else if (dataType == "MAGAZINE") { product = magazineById(pId); }
                    else if (dataType == "MUSICCD") { product = musicCDById(pId); }
                    else { product = null; }

                    productList.Add(product);
                }
                return productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion
    }
}
