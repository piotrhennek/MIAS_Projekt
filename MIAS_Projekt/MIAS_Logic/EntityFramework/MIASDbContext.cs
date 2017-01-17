using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devart.Data.Oracle.Entity;
namespace MIAS_Logic.EntityFramework
{
    public class MIASDbContext : DbContext
    {
        public MIASDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<CustomersModel> Customers { get; set; }
        public DbSet<InventoriesModel> Inventories { get; set; }
        public DbSet<OrderItemsModel> OrderItems { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
        public DbSet<ProductDescriptionModel> ProductDescription { get; set; }
        public DbSet<ProductInformationModel> ProductInformation { get; set; }
        public DbSet<WarehousesModel> Warehouses { get; set; }
    }
}
