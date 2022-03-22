using System;

namespace BookFromLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter count of books:");
            int countOfBooks = Convert.ToInt32(Console.ReadLine());
            SearchedBooks(countOfBooks);

        }


        static void SearchedBooks(int countOfBooks) {

            int bookNo;
            string nameOfBook;
            string genreOfBook;
            double enteredPrice;
            int count;
            

            for (int i = 0; i < countOfBooks; i++)
            {
                Library library = new Library();
                library.books = new Book[countOfBooks];
                int[] bookNumbers = new int[countOfBooks];


                Console.WriteLine($"Enter number of (next) book:");
                bookNo = Convert.ToInt32(Console.ReadLine());
                
                    while (bookNo == bookNumbers[i] && bookNo > 0)
                    {
                        Console.WriteLine($"This number is used for another book, please use another:");
                        bookNo = Convert.ToInt32(Console.ReadLine());
                    }

                    bookNumbers[i] = bookNo;

                Console.WriteLine("Enter name of book:");
                nameOfBook = Console.ReadLine();
                while(nameOfBook.Length < 1 || nameOfBook.Length > 50)
                {
                    Console.WriteLine("Invalid name, please enter name contains characters more than 1, less than 50: ");
                    nameOfBook = Console.ReadLine();
                }

                library.books[i].Name = nameOfBook;

                Console.WriteLine("Please type genre of book:");
                genreOfBook = Console.ReadLine();

                while(genreOfBook.Length < 3 || genreOfBook.Length > 20)
                {
                    Console.WriteLine("Invalid genre name, please enter genre name contains characters more than 3, less than 20:");
                    genreOfBook = Console.ReadLine();
                }

                library.books[i].Genre = genreOfBook;

                Console.WriteLine("Please type cost of book:");
                enteredPrice = Convert.ToDouble(Console.ReadLine());
                while (enteredPrice < 0)
                {
                    Console.WriteLine("Invalid number, please enter cost:");
                    enteredPrice = Convert.ToDouble(Console.ReadLine());
                }

                library.books[i].Price = enteredPrice;

                Console.WriteLine("Please type count of book:");
                count = Convert.ToInt32(Console.ReadLine());
                while (count < 0)
                {
                    Console.WriteLine("Count can not be negative number, please type valid count:");
                    count = Convert.ToInt32(Console.ReadLine());
                }

                library.books[i].Count = countOfBooks;

                Book newBook = new Book(bookNo, nameOfBook, enteredPrice, genreOfBook, count);
                library.AddBook(newBook, library.books);

                Console.WriteLine("Do you want books to be filtered?(Y(yes) or N(no))");
                    char input = Convert.ToChar(Console.ReadLine());
                    if (input == 'Y')
                    {
                            
                            Console.WriteLine(" Type 1 to filter for genre of books, 2 for cost range of them:");
                            char nextInput = Convert.ToChar(Console.ReadLine());
                            if (nextInput == '1')
                            {
                                Console.WriteLine("Choose genre:");
                                string genre = Console.ReadLine();
                                library.printBooks(library.GetFilteredBooks(genre));
                            }
                            else if (nextInput == '2')
                            {
                                Console.WriteLine("Enter minimum and maximum prices for cost range:");
                                double minprice = Convert.ToDouble(Console.ReadLine());
                                double maxprice = Convert.ToDouble(Console.ReadLine());
                                library.printBooks(library.GetFilteredBooks(minprice, maxprice));

                    }

                        }
                   
                    else if (input == 'N')
                    {
                        library.printBooks(library.books);
                    }
                
            }
            
            }

        }
    }