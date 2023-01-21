using Domain;
using Persistence;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class OrderService
    {
        private OrdersRepository _ordersRepository;
        public OrderService(OrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public void PlaceOrder()
        {
            Order order = new Order();
            ShowMenu();
            string command = "";
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "add")
                {
                    Console.WriteLine("Podaj id ksiązki: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj ilosc: ");
                    int numberOrdered = Convert.ToInt32(Console.ReadLine());
                    BookOrdered bookOrdered = new BookOrdered();
                    bookOrdered.BookId = id;
                    bookOrdered.NumberOrdered = numberOrdered;
                    order.BooksOrderedList.Add(bookOrdered);
                    Console.WriteLine("\nPress Any Key");
                    Console.ReadLine();
                    ShowMenu();
                }
                else if (command == "end")
                {
                    _ordersRepository.Insert(order);
                }
                else
                {
                    Console.WriteLine("Niewspierana komenda");
                }
            }
        }

        public void ListAll()
        {
            List<Order> ordersList = _ordersRepository.GetAll();
            foreach (Order order in ordersList)
            {
                Console.WriteLine(order.ToString());
            }
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("add - dodaj pozycje do zamowienia");
            Console.WriteLine("end - zamknij zamowienie");
        }
    }
}
