using System;
using System.Collections.Generic;
using System.Text;

namespace pureba2cProject
{
    class productTest
    {

        public int idCounter = 1;
        public int idProduct;
        public bool isAvailable;

        List<productTest> ProductList = new List<productTest>();

        Menu menu = new Menu();

        public productTest(int idProduct, bool isAvalible)
        {
            this.idProduct = idProduct;
            this.IsAvailable = isAvailable;
        }
        public productTest()
        {

        }
        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public void Product()
        {
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add new product");
            Console.WriteLine("\tq - Display products");
            Console.WriteLine("\te - Return to main menu");
            switch (Console.ReadLine())
            {
                case "a":
                    addP();
                    break;
                case "q":
                    displayP();
                    break;
                case "e":
                    Console.Clear();
                    menu.MainMenu();
                    break;
            }

            void addP()
            {
                Console.WriteLine($"N° products: {idCounter}");
                ProductList.Add(new productTest(idCounter, true));
                idCounter = idCounter + 1;
                Console.WriteLine("Do you want to continue adding products? (y/n)");
                switch (Console.ReadLine())
                {
                    case "y":
                        addP();
                        break;
                    case "n":
                        Console.Clear();
                        Product();
                        break;
                }
            }

            void displayP()
            {
                foreach (var productTest in ProductList)
                {
                    Console.WriteLine($"Id product: {productTest.IdProduct}, Is Available: {productTest.IsAvailable}");
                }
                Console.Write("Press any key to close the product display...");
                Console.ReadKey();
                Console.Clear();
                Product();
            }

        }
    }
}
