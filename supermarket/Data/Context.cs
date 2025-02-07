using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using supermarket.Models;

namespace supermarket.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        { 

        }

        public DbSet<ProductsModel> products { get; set; }
    }
}
