using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace OOP2P
{
    public class ItemToPurchase
    {
        private Product product;
        private int quantity;
        ///<summary>
        /// Constructor for ItemToPurchase.
        ///</summary>
        /// <param name="_product">This parameter Product object.</param>
        /// <param name="_quantity">This parameter product quantity.</param>
        ///
        public ItemToPurchase(Product _product, int _quantity)
        {
            product = _product;
            quantity = _quantity;
        }
        #region --get/set--
        ///<summary>
        /// Get method for Product.
        ///</summary>
        ///
        public Product Product  {get => product; }
        ///<summary>
        /// Get Set method for Quantity.
        ///</summary>
        ///
        public int Quantity
        {
            get { return quantity; }  
            set { if (value <= 0){throw new Exception("Error!");} else { quantity = value; }}
        }
        #endregion
        ///<summary>
        /// This function provides to print product and quantity information.
        ///</summary>
        ///
        public void print()
        {
            Console.WriteLine("ID: ", product.Id, "Name: ", product.Name, "Price: ", product.Price);
            Console.WriteLine("Qunatity: ", quantity);
        }
        ///<summary>
        /// This function provides to accept visitor class function
        ///</summary>
        /// <param name="list"</param>
        public void Accept(ref ArrayList list)
        {
            Visitor visitor = new Visitor();
            visitor.VisitItemToPurchseCart(this, ref list);
        }
    }
}
