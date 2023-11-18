using Microsoft.EntityFrameworkCore;
using NetflixCloneAPI.Models;

namespace NetflixCloneAPI.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> option)
        : base(option)
    {}

    public DbSet<User> Users { get; set; }
}
