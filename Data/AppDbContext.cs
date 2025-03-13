using System.Reflection;
using LibraryVirtual.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryVirtual.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
  public DbSet<LoanModel> Loans { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
}