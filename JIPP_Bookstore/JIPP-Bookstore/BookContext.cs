using JIPP_Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace JIPP_Bookstore
{
    public class BookContext : DbContext
    {
        public DbSet<BookModel> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = @"Data Source=DESKTOP-RVLTM1C\SQLEXPRESS02;Initial Catalog=BookstoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var connectionString = @"Data Source=DESKTOP-RVLTM1C\SQLEXPRESS02;Initial Catalog=Bookstore_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
