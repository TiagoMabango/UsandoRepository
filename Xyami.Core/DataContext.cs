using Microsoft.EntityFrameworkCore;
using Xyami.Core.Entities;

namespace Xyami.Core
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        //public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Characteristics> Characteristics { get; set; }
        //public DbSet<Client> Clients { get; set; }
        //public DbSet<Country> Countries { get; set; }
        //public DbSet<County> Counties { get; set; }
        public DbSet<Family> Families { get; set; }
        //public DbSet<Input>  Inputs{ get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<ProductStore> ProductStores { get; set; }
        //public DbSet<ProdutcInput> ProdutcInputs { get; set; }
        //public DbSet<Provider> Providers { get; set; }
        //public DbSet<ProviderPrice> ProviderPrices { get; set; }
        //public DbSet<Province> Provinces { get; set; }
        //public DbSet<Sale> Sales { get; set; }
        //public DbSet<SaleProduct> SaleProducts { get; set; }
        //public DbSet<Store> Stores { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<UserLavel> UserLavels { get; set; }

    }
}
