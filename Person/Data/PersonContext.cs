using Microsoft.EntityFrameworkCore;
using Person.Model;

namespace Person.Data;

public class PersonContext : DbContext
{
    public DbSet<PersonModel> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString:"Data Source=person.sqLitek");
        base.OnConfiguring(optionsBuilder);
    }
}