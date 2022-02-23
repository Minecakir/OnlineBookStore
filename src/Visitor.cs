using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace OOP2P
{
    public class Visitor
    {
        public Visitor() { }

        public void VisitProductCart(Product product, ref ArrayList compList)
        {
            FillList(product, ref compList);
        }
        public void VisitItemToPurchseCart(ItemToPurchase itp, ref ArrayList compList)
        {
            VisitProductCart(itp.Product, ref compList);

            ((Label)compList[6]).Text = itp.Quantity.ToString();
            double price = itp.Quantity * itp.Product.Price;
            ((Label)compList[7]).Text = price.ToString() + " ₺";

        }
        private void FillList(Product product, ref ArrayList compList)
        {
            ((Label)compList[1]).Text = product.Name;
            ((Label)compList[2]).Text = product.Price.ToString() + " ₺";
            ((PictureBox)compList[3]).ImageLocation = Path.Combine(Environment.CurrentDirectory, @"Images\", "product" + product.Id + ".png");
            if (product is Book)
            {
                ((Label)compList[0]).Text = "Book";
                ((Label)compList[4]).Text = ((Book)product).Author + "\nPage Num:" + ((Book)product).PageNumber.ToString();
                ((Label)compList[5]).Text = ((Book)product).Publisher + "\nISBN:" + ((Book)product).Isbn;
            }
            else if (product is Magazine)
            {
                ((Label)compList[0]).Text = "Magazine";
                ((Label)compList[4]).Text = ((Magazine)product).Issue;
                ((Label)compList[5]).Text = ((Magazine)product).Type;
            }
            else if (product is MusicCD)
            {
                ((Label)compList[0]).Text = "MusicCD";
                ((Label)compList[4]).Text = ((MusicCD)product).Singer;
                ((Label)compList[5]).Text = ((MusicCD)product).Type;
            }
        }
    }
}
