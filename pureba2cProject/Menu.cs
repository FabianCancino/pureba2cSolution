using System;
using System.Collections.Generic;
using System.Text;

namespace pureba2cProject
{
    public class Menu
    {
        productTest Product = null;
        public void MainMenu()
        {
            Product = new productTest();
            Console.WriteLine("\t*************");
            Console.WriteLine("\t* Main Menu *");
            Console.WriteLine("\t*************");
            Console.WriteLine(" ");
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tp - Products");
            Console.WriteLine("\to - Orders");
            Console.WriteLine("\te - Exit console app");
            switch (Console.ReadLine())
            {
                case "p":
                    Console.Clear();
                    Product.Product();
                    break;

                case "o":

                    break;

                case "e":
                    System.Environment.Exit(0);
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();

        }
    }
}
