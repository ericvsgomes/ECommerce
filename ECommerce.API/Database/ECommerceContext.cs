using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace ECommerce.API.Database
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Mercado" },
                new Department { Id = 2, Name = "Moda" },
                new Department { Id = 3, Name = "Móveis" },
                new Department { Id = 4, Name = "Informática" },
                new Department { Id = 5, Name = "Eletrodomésticos" },
                new Department { Id = 6, Name = "Eletroportáteis" },
                new Department { Id = 7, Name = "Beleza" }
            );
        }

        #region Conexão sem distinção de ambientes de execução
        /*
         * Conexão sem distinção de ambientes de execução
         */
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = ECommerce; Integrated Security = True;");
        }
        */
        #endregion
    }
}