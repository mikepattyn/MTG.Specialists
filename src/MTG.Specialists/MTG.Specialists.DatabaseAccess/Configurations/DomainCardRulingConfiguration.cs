using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DomainCardRulingConfiguration : IEntityTypeConfiguration<DomainCardRuling>
{
    public void Configure(EntityTypeBuilder<DomainCardRuling> builder)
    {
        builder.ToTable("tblRulings");

        builder.HasOne(x => x.Card)
            .WithMany(x=>x.Rulings)
            .OnDelete(DeleteBehavior.Restrict);


    }
}