using System;

namespace BookFromLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type count to start:");
            int countBook = Convert.ToInt32(Console.ReadLine());
            Library library = new()
            {
                books = new Book[countBook]
            };
            for (int i = 0; i < countBook; i++)
            {

                string name = "";
                string genre = "";
                int count = 0, no = 0;
                double price = 0;
                bool check = true;

                while (check)
                {
                    check = false;
                    Console.WriteLine($"Type the Number of No-{i + 1} book");
                    no = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < i; j++)
                    {
                        if (library.books[j].no == no)
                        {
                            check = true;
                            break;
                        }
                    }
                }


                while (name.Length < 1 || name.Length > 50)
                {
                    Console.WriteLine($"Type the name of No-{i+1} book");
                    name = Console.ReadLine();
                }
                while (genre.Length < 3 || genre.Length > 20)
                {
                    Console.WriteLine($"Type the genre of No-{i + 1} book");
                    genre = Console.ReadLine();
                }
                while (count <= 0)
                {
                    Console.WriteLine($"Type the count of No-{i + 1} book");
                    count = Convert.ToInt32(Console.ReadLine());
                }
                while (price <= 0)
                {
                    Console.WriteLine($"Type the price of No-{i + 1} book");
                    price = Convert.ToDouble(Console.ReadLine());
                }


                library.AddBook(new Book(genre, name, no, price, count));

            }
            while (true)
            {
                Console.WriteLine("Do you want to filter books? (Y or N)");
                char input = Convert.ToChar(Console.ReadLine());
                if (input == 'Y')
                {
                    Console.WriteLine("janra gore -1 ,, qiymete gore -2");
                    input = Convert.ToChar(Console.ReadLine());
                    if (input == '1')
                    {
                        Console.WriteLine("Janri daxil et : ");
                        string genre = Console.ReadLine();
                        library.PrintBooks(library.GetFiteredBooks(genre));
                        break;
                    }
                    else if (input == '2')
                    {
                        Console.WriteLine("Max ve Min qiymetleri yazin");
                        double minprice = Convert.ToDouble(Console.ReadLine());
                        double maxprice = Convert.ToDouble(Console.ReadLine());
                        library.PrintBooks(library.GetFiteredBooks(minprice, maxprice));
                        break;

                    }
                    else
                    {
                        Console.WriteLine("1 ve ya 2 daxil edile biler !!!");
                    }
                }
                else if (input == 'N')
                {
                    library.PrintBooks(library.books);
                    break;
                }
                else
                {
                    Console.WriteLine("y ve ya n daxil edile biler ");
                }

            }


        }
    }
}