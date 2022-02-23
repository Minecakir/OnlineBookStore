using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace OOP2P
{
    public partial class FormMainPage : Form
    {
        #region --singleton--
        private static FormMainPage instance = null;
        public static FormMainPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormMainPage();
                }
                return instance;
            }
        }
        #endregion
        private List<Product> products;
        private ShoppingCart activeShoppingCart;
        private List<ShoppingCart> previousOrders;
        private int customerId = 0;
        ///<summary>
        /// Getters and setters for Main Page.
        ///</summary>
        ///
        #region --getset--
        public List<Product> Products { get => products; set => products = value; }
        public ShoppingCart ActiveShoppingCart { get => activeShoppingCart; set => activeShoppingCart = value; }
        public List<ShoppingCart> PreviousOrders { get => previousOrders; set => previousOrders = value; }
        public int CustomerId
        {
            get { return customerId; }   
            set { customerId = value;
                Repository.ShoppingCartRepo scr = new Repository.ShoppingCartRepo();
                activeShoppingCart.CartID = scr.createActiveCartIfThereIsNo(customerId);}  
        }
        #endregion
        private FormMainPage()
        {
            InitializeComponent();

            products = new List<Product>();
            activeShoppingCart = new ShoppingCart();
            previousOrders = new List<ShoppingCart>();
        }
        private void FormMainPage_Load(object sender, EventArgs e)
        {
            labelName.Text = LoginedCustomer.Instance().Customer.Name;
            Repository.ProductRepo conn = new Repository.ProductRepo();
            products = conn.ProductList();
            loadMainPage();
        }
        #region --loadPages--
        ///<summary>
        /// This function provides to load main page.
        ///</summary>
        ///
        public void loadMainPage()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.VerticalScroll.Value = 0;
            tableLayoutPanel1.ColumnCount = 3;

            for (int i = 0; i < products.Count; i++)
            {
                UC_MainProduct userControl = new UC_MainProduct(i);
                tableLayoutPanel1.Controls.Add(userControl);
            }
        }
        ///<summary>
        /// This function provides to load shoppingCartPage page.
        ///</summary>
        ///
        public void loadshoppingCartPage()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.VerticalScroll.Value = 0;
            tableLayoutPanel1.ColumnCount = 1;

            Repository.ShoppingCartRepo scr = new Repository.ShoppingCartRepo();
            activeShoppingCart = scr.getActiveCart(customerId);
            labelTotalPrice.Text = activeShoppingCart.PaymentAmount.ToString() + " ₺";

            for (int i = 0; i < activeShoppingCart.ItemsToPurchase.Count; i++)
            {
                ItemToPurchase itemToPurchase = activeShoppingCart.ItemsToPurchase[i];
                UC_ShoppingCartProduct userControl = new UC_ShoppingCartProduct(i);
                tableLayoutPanel1.Controls.Add(userControl);
            }
        }
        ///<summary>
        /// This function provides to load Orders page.
        ///</summary>
        ///
        public void loadOrdersPage()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.VerticalScroll.Value = 0;
            tableLayoutPanel1.ColumnCount = 1;

            Repository.ShoppingCartRepo scr = new Repository.ShoppingCartRepo();
            previousOrders = scr.getPreviousCarts(customerId);

            for (int i = 0; i < previousOrders.Count; i++)
            {
                UC_Orders userControl = new UC_Orders(i);
                tableLayoutPanel1.Controls.Add(userControl);
            }
        }
        #endregion
        #region --buttons--
        /// <summary>
        /// This function provides load main page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMain_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonMain", DateTime.Now);

            groupBoxShoppingCartComp.Visible = false;
            buttonMagazine.Visible = true;
            buttonBook.Visible = true;
            buttonMusicCD.Visible = true;
            buttonControl();

            Repository.ProductRepo conn = new Repository.ProductRepo();
            products = conn.ProductList();

            loadMainPage();
        }
        /// <summary>
        /// This function provides load shoppingCart page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShoppingCart_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonShoppingCart", DateTime.Now);

            groupBoxShoppingCartComp.Visible = true;
            buttonMagazine.Visible = false;
            buttonBook.Visible = false;
            buttonMusicCD.Visible = false;

            loadshoppingCartPage();
        }
        /// <summary>
        /// This function provides load books into main page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBook_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonBook", DateTime.Now);

            buttonControl();
            buttonBook.ForeColor = Color.OrangeRed;
            buttonBook.BackColor = Color.White;

            Repository.ProductRepo conn = new Repository.ProductRepo();
            products = conn.BookList();
            loadMainPage();
        }
        /// <summary>
        /// This function provides load magazines into main page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMagazine_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonMagazine", DateTime.Now);

            buttonControl();
            buttonMagazine.ForeColor = Color.OrangeRed;
            buttonMagazine.BackColor = Color.White;

            Repository.ProductRepo conn = new Repository.ProductRepo();
            products = conn.MagazineList();
            loadMainPage();
        }
        /// <summary>
        /// This function provides load MusicCDs into main page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMusicCD_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonMusicCD", DateTime.Now);

            buttonControl();
            buttonMusicCD.ForeColor = Color.OrangeRed;
            buttonMusicCD.BackColor = Color.White;

            Repository.ProductRepo conn = new Repository.ProductRepo();
            products = conn.MusicCDList();
            loadMainPage();
        }
        /// <summary>
        /// This function provides load orders into main page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonOrders", DateTime.Now);

            tableLayoutPanel1.Controls.Clear();
            groupBoxShoppingCartComp.Visible = false;
            buttonMagazine.Visible = false;
            buttonBook.Visible = false;
            buttonMusicCD.Visible = false;

            loadOrdersPage();
        }
        /// <summary>
        /// This function provides load paymentForm when the user clik purchase button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonPurcahse", DateTime.Now);

            if (activeShoppingCart.ItemsToPurchase.Count==0)
            {
                MessageBox.Show("Shopping Cart is Empty!!");
                return;
            }
            PaymentForm paymentForm = new PaymentForm(activeShoppingCart);
            paymentForm.Show();
        }
        /// <summary>
        /// This function provides exit mainPage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Log.log.WriteLog(LoginedCustomer.Instance().Customer.Username, "buttonExit", DateTime.Now);

            Repository.ShoppingCartRepo scr = new Repository.ShoppingCartRepo();
            scr.deleteIfEmpty(activeShoppingCart.CartID);
            this.Hide();
            Environment.Exit(0);
        }
        #endregion
        ///<summary>
        /// This function provides to control buttons color.
        ///</summary>
        ///
        private void buttonControl()
        {
            buttonBook.ForeColor = Color.White;
            buttonBook.BackColor = Color.OrangeRed;
            buttonMusicCD.ForeColor = Color.White;
            buttonMusicCD.BackColor = Color.OrangeRed;
            buttonMagazine.ForeColor = Color.White;
            buttonMagazine.BackColor = Color.OrangeRed;
        }
    }
}
