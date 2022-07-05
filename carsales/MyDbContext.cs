using carsales.Models;
using Microsoft.EntityFrameworkCore;

namespace carsales


{
    
    public class MyDbContext : DbContext
    {
        public DbSet<Cars> Cars { get; set; }
        public MyDbContext(DbContextOptions options) : base(options)
        {
            
        } 

        /* Adding data to  database*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>().HasData(new Models.Cars { Id = 2, Brand = "Ford", Carmodel = "Figo", Modelyear = 2010, Seats = 5, Mileage = 3000, Gearbox = "Automatic", Price = 23000 });
            modelBuilder.Entity<Cars>().HasData(new Models.Cars { Id = 3, Brand = "BMW", Carmodel = "X1", Modelyear = 2009, Seats = 5, Mileage = 5000, Gearbox = "Automatic", Price = 40000 });
            modelBuilder.Entity<Cars>().HasData(new Models.Cars { Id = 4, Brand = "Audi", Carmodel = "A3", Modelyear = 2005, Seats = 5, Mileage = 3000, Gearbox = "Automatic", Price = 23000 });
            modelBuilder.Entity<Cars>().HasData(new Models.Cars { Id = 5, Brand = "Volvo", Carmodel = "v40", Modelyear = 2012, Seats = 5, Mileage = 3000, Gearbox = "Automatic", Price = 50000 });
        }

    }
}
