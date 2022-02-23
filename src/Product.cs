using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOP2P
{
    public abstract class Product
    {
        private string name;
        private string id;
        private double price;
        public Product(string _name, string _id, double _price)
        {
            name = _name;
            id = _id;
            price = _price;
        }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public double Price { get => price; set => price = value; }

        public abstract void Accept(ref ArrayList list);
    }
    class Book : Product
    {
        private string isbn;
        private string author;
        private string publisher;
        private int pageNumber;
        public Book(string _name = "", string _id = "", double _price = 0, string _isbn = "", string _author = "", string _publisher = "", int _pageNumber = 0) 
            : base(_name, _id, _price)
        {
            isbn = _isbn;
            author = _author;
            publisher = _publisher;
            pageNumber = _pageNumber;
        }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int PageNumber { get => pageNumber; set => pageNumber = value; }

        public override void Accept(ref ArrayList list)
        {
            Visitor visitor = new Visitor();
            visitor.VisitProductCart(this, ref list);
        }
    }
    class Magazine : Product
    {
        private string issue;
        private string type;

        public Magazine(string _name = "", string _id = "", double _price = 0, string _issue = "", string _type = "") 
            : base(_name, _id, _price)
        {
            issue = _issue;
            type = _type;
        }
        public string Issue { get => issue; set => issue = value; }
        public string Type { get => type; set => type = value; }

        public override void Accept(ref ArrayList list)
        {
            Visitor visitor = new Visitor();
            visitor.VisitProductCart(this, ref list);
        }
    }
    class MusicCD : Product
    {
        private string singer;
        private string type;
        public MusicCD(string _name = "", string _id = "", double _price = 0, string _singer = "", string _type = "")
            : base(_name, _id, _price)
        {
            singer = _singer;
            type = _type;
        }
        public string Singer { get => singer; set => singer = value; }
        public string Type { get => type; set => type = value; }

        public override void Accept(ref ArrayList list)
        {
            Visitor visitor = new Visitor();
            visitor.VisitProductCart(this, ref list);
        }
    }
}
