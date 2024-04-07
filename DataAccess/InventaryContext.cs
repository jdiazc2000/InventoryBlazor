using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        //Configuración de las tablas
        public DbSet<ProductEntity> TBProducts { get; set; }
        public DbSet<CategoryEntity> TBCategories { get; set; }
        public DbSet<InputOutputEntity> TBInputOutputs { get; set; }
        public DbSet<StorageEntity> TBStorages { get; set; }
        public DbSet<WareHouseEntity> TBWareHouses { get; set; }

        //Configuración de la conexión
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-CA5TT0R\\SQLEXPRESS; Database=InventoryDB; user id=Julio; password=123; TrustServerCertificate=True");
            }
        }

        //Precargar datos en la Base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumería" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
            );

            modelBuilder.Entity<WareHouseEntity>().HasData(
                new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName="Bodega Central", WareHouseAddress ="Calle 8 con 23"},
                new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega Inferior", WareHouseAddress = "Calle 10 con 11" },
                new WareHouseEntity { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Bodega Superior", WareHouseAddress = "Calle 2 con 38" }
            );
        }
    }
}
