using Domain;
using System.Collections.Generic;

namespace Persistence
{
    public class OrdersRepository
    {
        private List<Order> database = new List<Order>();

        public void Insert(Order order)
        {
            database.Add(order);
        }

        public List<Order> GetAll()
        {
            return database;
        }
    }
}
