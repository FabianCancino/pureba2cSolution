using System;

namespace pureba2cProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("* Hello, Welcome to CamBox Console App  * ");
            Console.WriteLine("****************************************");
            Console.WriteLine(" ");
            Console.WriteLine("Please insert your data:");
            Console.WriteLine(" ");
            String nameManager;
            String rutManager;
            Console.WriteLine("Insert your Name:");
            Console.WriteLine("Example: Fabian Cancino");
            Console.WriteLine(" ");
            nameManager = Console.ReadLine();
            Console.WriteLine("Insert your Rut without the check digit:");
            Console.WriteLine("Example: 20648620");
            Console.WriteLine(" ");
            rutManager = Console.ReadLine();
            Console.WriteLine(".......");
            Console.WriteLine($"Congrats, your account has been created, {nameManager}");
            Console.Clear();
            Menu menu = new Menu();
            menu.MainMenu();
        }
    }
}
