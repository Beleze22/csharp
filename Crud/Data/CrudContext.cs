using Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud.Context;

public class CrudContext : DbContext
{
    public DbSet<CrudModel> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString: "Data Source=crud.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}