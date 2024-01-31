using Microsoft.EntityFrameworkCore;
using PaivaStore.Domain.Entities;

namespace PaivaStore.Infra.Data;

public class PaivaStoreDbContext : DbContext
{
    public PaivaStoreDbContext(DbContextOptions<PaivaStoreDbContext> options) : base(options)
    { }

    public DbSet<Product> Products { get; set; }
}