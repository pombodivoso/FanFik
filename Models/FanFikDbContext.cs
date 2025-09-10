using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FanFik.Models;

public class FanFikDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> User => Set<User>();
    public DbSet<Fanfic> Fanfics => Set<Fanfic>();
    public DbSet<ReadList> ReadLists => Set<ReadList>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Fanfic>()
            .HasOne(u => u.Creator)
            .WithMany(f => f.CreatedFanfictions)
            .HasForeignKey(f => f.CreatorId)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Fanfic>()
            .HasMany(f => f.Lists)
            .WithMany(r => r.Fanfictions);

        model.Entity<ReadList>()
            .HasOne(u => u.Creator)
            .WithMany(r => r.AllLists)
            .HasForeignKey(u => u.CreatorId)
            .OnDelete(DeleteBehavior.NoAction);

    }
    // public class FanFikDbContextFactory : IDesignTimeDbContextFactory<FanFikDbContext>
    // {
    //     public FanFikDbContext CreateDbContext(string[] args)
    //     {
    //         var options = new DbContextOptionsBuilder<FanFikDbContext>();
    //         var sqlConn = Environment.GetEnvironmentVariable("SQL_CONNECTION");
    //         options.UseSqlServer(sqlConn);
    //         return new FanFikDbContext(options.Options);
    //     }
    // }
}
