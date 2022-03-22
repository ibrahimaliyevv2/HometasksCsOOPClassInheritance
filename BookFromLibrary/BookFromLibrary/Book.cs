using System;
namespace BookFromLibrary
{
    public class Book:Product
    {
        public string Genre;

        public Book(int no, string name, double price, string genre, int count = 0) : base(no, name, price, count)
        {
            Genre = genre;
        }
    }
}
