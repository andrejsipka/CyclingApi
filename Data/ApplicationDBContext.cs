using Microsoft.EntityFrameworkCore;
using CyclingApi.Models;

namespace CyclingApi.Data;

// DbContext class is the core of Entity Framework Core act as bridge between the database and our app
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    {}
    
    // DbSet included in DbContext
    public DbSet<Activity> Activities { get; set; }
}