using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppProject
{
    public class testFull
    {
        // Producto
        public int idCounter = 1;
        public int idProduct;
        public bool isAvailable = true;

        // Orden
        public String proIdPicker;
        public int idCounterOrder = 1;
        public int idOrder;
        public String nomCliente;
        public String cliente;

        List<testFull> ProductList = new List<testFull>();
        List<testFull> OrderList = new List<testFull>();
        public testFull(int idProduct, int idOrder, String nomCliente)
        {
            this.idProduct = idProduct;
            this.idOrder = idOrder;
            this.nomCliente = nomCliente;
        }
        public testFull(int idProduct, bool isAvalible)
        {
            this.idProduct = idProduct;
            this.IsAvailable = isAvailable;
        }
        public testFull()
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
        public int IdOrder
        {
            get { return idOrder; }
            set { idOrder = value; }
        }
        public String NomCliente
        {
            get { return nomCliente; }
            set { nomCliente = value; }
        }
        public void menu()
        {


            Console.WriteLine("CamBox system ");
            Console.WriteLine(" ");
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tp - Products");
            Console.WriteLine("\to - Orders");
            Console.WriteLine("\te - Exit console app");
            switch (Console.ReadLine())
            {
                case "p":
                    Console.Clear();
                    Producto();
                    break;

                case "o":
                    Orden();
                    break;

                case "e":
                    System.Environment.Exit(0);
                    break;
            }

            void Orden()
            {
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add new Order");
                Console.WriteLine("\tq - Display Orders");
                Console.WriteLine("\trick - Rick Astley");
                Console.WriteLine("\te - Return to main menu");
                switch (Console.ReadLine())
                {
                    case "a":
                        addO();
                        break;
                    case "q":
                        displayO();
                        break;
                    case "e":
                        Console.Clear();
                        menu();
                        break;
                    case "rick":
                        Console.WriteLine("\thttps://www.youtube.com/watch?v=SwA2R9OyamE");
                        Console.Write("Press any key to close the best video ever... ¬n¬");
                        Console.ReadKey();
                        Console.Clear();
                        Orden();
                        break;
                    case "acsii":
                        Draw();
                        break;
                }

            }
            void addO()
            {
                Console.WriteLine($"Order ID: {idCounterOrder}");
                ProductList = ProductList.OrderBy(x => x.IsAvailable).ToList();
                foreach (var productTest in ProductList)
                {
                    Console.WriteLine("************************************************");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Id product: {productTest.IdProduct}");
                    Console.WriteLine($"Is Available: {productTest.IsAvailable}");
                    Console.WriteLine(" ");
                }
                Console.WriteLine("What product do you want to select?");
                proIdPicker = Console.ReadLine();
                var s1 = ProductList.Where(x => x.IdProduct == Convert.ToInt32(proIdPicker)).First();
                if (s1.IsAvailable == true)
                {
                    s1.IsAvailable = false;
                    Console.WriteLine($"{s1.IdProduct}");
                    Console.WriteLine("Enter your name");
                    cliente = Console.ReadLine();
                    OrderList.Add(new testFull(s1.IdProduct, idCounterOrder, cliente));
                    Console.Clear();
                    Orden();
                }
                else
                {
                    Console.Clear();
                    addO();
                }

            }
            void displayO()
            {
                foreach (var productTest in OrderList)
                {
                    Console.WriteLine($"Id product: {productTest.IdProduct}, Id Order: {productTest.IdOrder}, Customer name: {productTest.nomCliente}");
                }
                Console.Write("Press any key to close the product display...");
                Console.ReadKey();
                Console.Clear();
                Orden();
            }

            void Producto()
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
                        menu();
                        break;
                }
            }
            void addP()
            {
                Console.WriteLine($"N° products: {idCounter}");
                ProductList.Add(new testFull(idCounter, true));
                idCounter = idCounter + 1;
                Console.WriteLine("Do you want to continue adding products? (y/n)");
                switch (Console.ReadLine())
                {
                    case "y":
                        addP();
                        break;
                    case "n":
                        Console.Clear();
                        Producto();
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
                Producto();
            }










































            void Draw()
            {
                //cdtg
                Acsii acsii = new Acsii();
                Console.WriteLine("C");
                Console.WriteLine("D");
                Console.WriteLine("T");
                Console.WriteLine("G");
                Console.WriteLine("E");
                switch (Console.ReadLine())
                {
                    case "C":
                        Console.Clear();
                        acsii.Calamardo();
                        break;
                    case "D":
                        Console.Clear();
                        acsii.Danganronpa();
                        break;
                    case "T":
                        Console.Clear();
                        acsii.ToSus();
                        break;
                    case "G":
                        Console.Clear();
                        acsii.GGEZ();
                        break;
                    case "E":
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
