using System;
namespace BookFromLibrary
{
    public class Library
    {
        
        public Book[] books;

        public void AddBook(Book enteredBook, Book[] books)
        {
            int count = 0;
            for (int i = 0; i < books.Length; i++)
            {
                count++;
                books[i] = enteredBook;
            }
        }

        public Book[] GetFilteredBooks(string genreName)
        {
            int count = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Genre == genreName)
                {
                    count++;
                }
            }

            int j = 0;
            Book[] filteredBooks = new Book[count];
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Genre == genreName)
                {
                    filteredBooks[j] = books[i];
                    j++;
                }
            }
            return filteredBooks;
        }

        public Book[] GetFilteredBooks(double minPrice, double maxPrice)
        {
            int count = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if(books[i].Price>=minPrice && books[i].Price <= maxPrice)
                {
                    count++;
                }
            }

            int j = 0;
            Book[] filteredBooks = new Book[count];
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Price >= minPrice && books[i].Price <= maxPrice)
                {
                    filteredBooks[j] = books[i];
                    j++;
                }
            }
            return filteredBooks;
        }

        public void printBooks(Book[] books)
        {
            foreach (var item in books)
            {
                Console.WriteLine($"Name : {item.Name} Price {item.Price} Genre : {item.Genre} No : {item.No} Count : {item.Count} ");
            }
        }


    }

    }