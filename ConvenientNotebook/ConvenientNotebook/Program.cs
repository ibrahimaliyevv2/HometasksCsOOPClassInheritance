using System;

namespace ConvenientNotebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook
            {
                Name = "m100",
                BrandName = "HP",
                Price = 1000,
            };

            Notebook notebook2 = new Notebook
            {
                Name = "m200",
                BrandName = "Apple",
                Price = 600,
            };

            Notebook notebook3 = new Notebook
            {
                Name = "m300",
                BrandName = "Toshiba",
                Price = 2000,
            };

            Notebook notebook4 = new Notebook
            {
                Name = "m400",
                BrandName = "Samsung",
                Price = 1500,
            };

            Notebook notebook5 = new Notebook
            {
                Name = "m500",
                BrandName = "LG",
                Price = 2500,
            };

            Notebook[] notebooks = {notebook1, notebook2, notebook3, notebook4, notebook5 };
            
            double minPrice = 700;
            double maxPrice = 1800;

            Notebook[] newNotebook = GetConvenient(notebooks, minPrice, maxPrice);

            foreach (var item in newNotebook)
            {
                Console.WriteLine($"Name: {item.Name} - Brand name: {item.BrandName} - Price: {item.Price}");
            }
        }

        static Notebook[] GetConvenient(Notebook[] notebooks, double minPrice, double maxPrice)
        {
            int count = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Price >= minPrice && notebooks[i].Price <= maxPrice)
                {
                    count++;
                }
            }
            Notebook[] notebooks1 = new Notebook[count];
            int j = 0;
                for (int i = 0; i < notebooks.Length; i++)
                {
                    if (notebooks[i].Price >= minPrice && notebooks[i].Price <= maxPrice)
                    {
                        notebooks1[j] = notebooks[i];
                        j++;
                    }  
                }
            
            return notebooks1;
        }
    }
}