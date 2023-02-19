namespace EfBundle_DesignTimeFactory.Data;

public sealed class LocalDbContextFactory : IDesignTimeDbContextFactory<LocalDbContext>
{
  public LocalDbContext CreateDbContext(string[] args)
  {
    var optionsBuilder = new DbContextOptionsBuilder<LocalDbContext>();
    optionsBuilder.UseSqlServer();
    return new LocalDbContext(optionsBuilder.Options);
  }
}
