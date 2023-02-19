namespace EfBundle_DesignTimeFactory.Data;

public sealed class LocalDbContext : DbContext
{
  public LocalDbContext(DbContextOptions<LocalDbContext> options) : base(options)
  {
    
  }

  public DbSet<Contact> Contacts { get; set; }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);
    builder.ApplyConfigurationsFromAssembly(typeof(LocalDbContext).Assembly);
  }
}
