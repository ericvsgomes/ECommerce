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