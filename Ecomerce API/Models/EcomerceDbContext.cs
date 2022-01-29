using Microsoft.EntityFrameworkCore;



namespace Ecomerce_API.Models
{
    public class EcomerceDbContext:DbContext
    {
        //public EcomerceDbContext(DbContextOptions<EcomerceDbContext> Options) : base(Options)
        //{


        //}

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public EcomerceDbContext(DbContextOptions<EcomerceDbContext> Options) : base(Options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails {get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }
    }
}
