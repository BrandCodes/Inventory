using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext: DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InOutEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouse { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost; Database=Inventory; Trusted_Connection=True”");
            }
        }
    }
}
