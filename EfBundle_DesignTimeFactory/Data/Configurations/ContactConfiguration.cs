using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfBundle_DesignTimeFactory.Data.Configurations;

public sealed class ContactConfiguration
{
  public void Configure(EntityTypeBuilder<Contact> builder)
  {
    builder.HasKey(e => new { e.Id });
    builder.Property(t => t.Id)
        .UseIdentityColumn();

    builder.Property(t => t.Name)
        .HasMaxLength(100)
        .IsRequired();

    builder.Property(t => t.Number)
        .HasMaxLength(100);

    builder.Property(t => t.Email)
        .HasMaxLength(100);
  }
}
