using JIPP_Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JIPP_Bookstore.Logic
{
    public class BookManager
    {
        public void AddBook(BookModel bookModel)
        {

            using (var context = new BookContext())
            {
                context.Books.Add(bookModel);
                context.SaveChanges();
            }
        }

        public void RemoveBook(int id)
        {
            using(var context = new BookContext())
            {
                var bookToDelete = context.Books.Single(x => x.ID == id);
                context.Books.Remove(bookToDelete);
                context.SaveChanges();
            }
        }

        public void UpdateBook(BookModel bookModel)
        {
            using (var contex = new BookContext())
            {
                contex.Books.Update(bookModel);
                contex.SaveChanges();
            }
        }

        public BookModel GetBook(int id)
        {
            using (var context = new BookContext())
            {
                var book = context.Books.Single(x => x.ID == id);
                return book;
            }
        }

        public List<BookModel> GetBooks()
        {
            using (var context = new BookContext())
            {
                return context.Books.ToList();
            }
        }
    }
}