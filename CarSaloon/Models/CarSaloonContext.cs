using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaloon.Models
{
    public class CarSaloonContext : DbContext
    {

        public DbSet<Body> Bodies { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<TechData> TechData { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public CarSaloonContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=carsaloon.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                    new Brand { Id=1,Title = "Audi" },
                    new Brand { Id = 2, Title = "BMW" },
                    new Brand { Id = 3, Title = "Chevrolet" },
                    new Brand { Id = 4, Title = "Ford" },
                    new Brand { Id = 5, Title = "Honda" },
                    new Brand { Id = 6, Title = "Hyundai" },
                    new Brand { Id = 7, Title = "Kia" },
                    new Brand { Id = 8, Title = "Lexus" },
                    new Brand { Id = 9, Title = "Mazda" },
                    new Brand { Id = 10, Title = "Mercedes-Benz" },
                    new Brand { Id = 11, Title = "Mitsubishi" },
                    new Brand { Id = 12, Title = "Nissan" },
                    new Brand { Id = 13, Title = "Opel" },
                    new Brand { Id = 14, Title = "Renault" },
                    new Brand { Id = 15, Title = "Skoda" },
                    new Brand { Id = 16, Title = "Toyota" },
                    new Brand { Id = 17, Title = "Volkswagen" }
            );

            modelBuilder.Entity<Body>().HasData(
                   new Body { Id = 1, Title = "Седан" },
                   new Body { Id = 2, Title = "Хэтчбек" },
                   new Body { Id = 3, Title = "Лифтбек" },
                   new Body { Id = 4, Title = "Внедорожник" },
                   new Body { Id = 5, Title = "Универсал" },
                   new Body { Id = 6, Title = "Купе" },
                   new Body { Id = 7, Title = "Минивэн" },
                   new Body { Id = 8, Title = "Пикап" },
                   new Body { Id = 9, Title = "Фургон" },
                   new Body { Id = 10, Title = "Кабриолет" }
           );

            modelBuilder.Entity<Transmission>().HasData(
                   new Transmission { Id = 1, Title = "Автоматическая" },
                   new Transmission { Id = 2, Title = "Механическая" },
                   new Transmission { Id = 3, Title = "Робот" },
                   new Transmission { Id = 4, Title = "Вариатор" }
           );

            modelBuilder.Entity<EngineType>().HasData(
                   new EngineType { Id = 1, Title = "Бензин" },
                   new EngineType { Id = 2, Title = "Дизель" },
                   new EngineType { Id = 3, Title = "Гибрид" },
                   new EngineType { Id = 4, Title = "Электро" }
           );

            modelBuilder.Entity<Drive>().HasData(
                   new Drive { Id = 1, Title = "Передний" },
                   new Drive { Id = 2, Title = "Задний" },
                   new Drive { Id = 3, Title = "Полный" }
           );

            modelBuilder.Entity<Country>().HasData(
                    new Country { Id = 1, Title = "США" },
                    new Country { Id = 2, Title = "Германия" },
                    new Country { Id = 3, Title = "Япония" },
                    new Country { Id = 4, Title = "Корея" },
                    new Country { Id = 5, Title = "Франция" },
                    new Country { Id = 6, Title = "Чехия" }
            );
        }
    }
}
