using Domain;
using Persistence;
using System;

namespace ConsoleApp
{
    public class BooksService
    {
        BooksRepository _repository;
        public BooksService(BooksRepository booksRepository)
        {
            _repository = booksRepository;
        }
        public void AddBook()
        {
            Book book = new Book();
            Console.WriteLine("Tytul: ");
            String title = Console.ReadLine();
            book.Title = title;
            Console.WriteLine("Autor: ");
            String author = Console.ReadLine();
            book.Author = author;
            Console.WriteLine("Rok publikacji: ");
            int publicationYear = Convert.ToInt32(Console.ReadLine());
            book.PublicationYear = publicationYear;
            Console.WriteLine("ISBN: ");
            String isbn = Console.ReadLine();
            book.ISBN = isbn;
            Console.WriteLine("Dostępne produkty: ");
            int productsAvailable = Convert.ToInt32(Console.ReadLine());
            book.ProductsAvailable = productsAvailable;
            Console.WriteLine("Cena: ");
            Decimal price = Convert.ToDecimal(Console.ReadLine());
            book.Price = price;
            _repository.Insert(book);
        }

        public void RemoveBook()
        {
            Console.WriteLine("Podaj tytuł ksiązki do usunięcia: ");
            String title = Console.ReadLine();
            _repository.RemoveByTitle(title);
        }

        public void ListBooks()
        {
            var books = _repository.GetAll();
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public void ChangeState()
        {
            Console.WriteLine("Podaj tytuł książki do zmiany stany: ");
            String title = Console.ReadLine();
            Console.WriteLine("Podaj zmianę stanu: ");
            int change = Convert.ToInt32(Console.ReadLine());
            _repository.ChangeStatus(title, change);
        }
    }
}
