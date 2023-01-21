using System;
using System.Collections.Generic;

namespace Domain
{
    public class Order
    {
        public DateTime Date { get; set; }
        public List<BookOrdered> BooksOrderedList { get; set; }

        public Order()
        {
            Date = DateTime.Now;
            BooksOrderedList = new List<BookOrdered>();
        }

        public override string ToString()
        {
            string str = "Order: " + Date.ToString() + "\n";
            foreach (BookOrdered book in BooksOrderedList)
            {
                str += $"Book: {book.BookId} Count: {book.NumberOrdered}\n";
            }
            return str;
        }
    }
}
