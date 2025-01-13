using Microsoft.EntityFrameworkCore;

namespace LoadTestPlayground.Data;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbContext(DbContextOptions<DbContext> options) : base(options)
    {

    }

    public DbSet<Message> Messages { get; set; }
}