using ConsoleApp;
using Domain;
using Persistence;
using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            BooksRepository repository = new BooksRepository();
            bool access = false;

            while (!access)
            {
                Console.WriteLine("Podaj login: ");
                string login = Console.ReadLine();
                Console.WriteLine("Podaj hasło: ");
                string password = Console.ReadLine();
                if (login == "Admin" && password == "password")
                {
                    Console.WriteLine("Access Granted");
                    access = true;
                    Console.WriteLine("Press Any Key");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Access Denied");
                    Console.WriteLine("\nPress Any Key");
                    Console.ReadLine();
                }
            }

            String command = "";
            BooksService booksService = new BooksService(repository);
            OrdersRepository ordersRepository = new OrdersRepository();
            OrderService orderService = new OrderService(ordersRepository);
            while (command != "wyjdz")
            {
                showMenu();
                command = Console.ReadLine();
                Console.Clear();
                switch (command)
                {
                    case "dodaj":
                        booksService.AddBook();
                        break;
                    case "usun":
                        booksService.RemoveBook();
                        break;
                    case "wypisz":
                        booksService.ListBooks();
                        break;
                    case "zmien":
                        booksService.ChangeState();
                        break;
                    case "dodaj zamowienie":
                        orderService.PlaceOrder();
                        break;
                    case "lista zamowien":
                        orderService.ListAll();
                        break;
                    case "wyjdz":
                        Console.WriteLine("Elo");
                        break;
                    default:
                        Console.WriteLine("Niewspierana komenda");
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Press AnyKey");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void showMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("dodaj");
            Console.WriteLine("usun");
            Console.WriteLine("wypisz");
            Console.WriteLine("zmien");
            Console.WriteLine("dodaj zamowienie");
            Console.WriteLine("lista zamowien");
            Console.WriteLine("wyjdz");
        }
    }
}
