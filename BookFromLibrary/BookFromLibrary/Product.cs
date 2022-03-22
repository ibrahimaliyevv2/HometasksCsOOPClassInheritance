using System;
namespace BookFromLibrary
{
    public class Product
    {
        public Product(int no, string name, double price, int count = 0)
        {
            this.No = no;
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }

        public int No;
        public string Name;
        public double Price;
        public int Count;
    }
}
