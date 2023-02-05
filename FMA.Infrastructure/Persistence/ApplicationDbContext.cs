using FMA.Domain.Master;
using FMA.Domain.Product;
using FMA.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FMA.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{

    private readonly DateTime _currentDateTime;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        _currentDateTime = DateTime.UtcNow;
    }

    public DbSet<AppSetting> AppSettings { get; set; }

    public DbSet<Category> Categories { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        modelBuilder
            .Entity<Category>(
                eb =>
                {
                    eb.HasNoKey();
                });
    }

}