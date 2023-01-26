namespace APITask.Services;
using Microsoft.EntityFrameworkCore;

    public class CarsListDbContext : DbContext
    {
    public DbSet<Car> Cars { get; set; }

    public CarsListDbContext(DbContextOptions<CarsListDbContext> options) : base(options)
    {

    }
    }

