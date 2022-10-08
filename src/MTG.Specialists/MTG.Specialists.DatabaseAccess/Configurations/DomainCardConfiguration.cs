using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DomainCardConfiguration : IEntityTypeConfiguration<DomainCard>
{
    public void Configure(EntityTypeBuilder<DomainCard> builder)
    {
        builder.ToTable("tblCards");
    }
}