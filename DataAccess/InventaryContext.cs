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
                options.UseSqlServer("Server=localhost; Database=Inventory; Trusted_Connection=True");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<CategoryEntity>().HasData(
        //        new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
        //        new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
        //        new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
        //        new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumería" },
        //        new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
        //        new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
        //        );

        //    modelBuilder.Entity<WarehouseEntity>().HasData(
        //        new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Central", WarehouseAddress = "4627 Rowes Lane. Louisville, Ky" },
        //        new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Norte", WarehouseAddress = "4085 North Street. Salt Lake City, Utah" }
        //        );

        //    modelBuilder.Entity<ProductEntity>().HasData(
        //        new ProductEntity { ProductId = "ASJ-98745", ProductName = "Crema para manos marca Tersa", ProductDescription = "", CategoryId = "PRF" },
        //        new ProductEntity { ProductId = "RPT-5465879", ProductName = "Pastillas para la garganta LESUS", ProductDescription = "", CategoryId = "SLD" }
        //        );
        //}
    }
}
