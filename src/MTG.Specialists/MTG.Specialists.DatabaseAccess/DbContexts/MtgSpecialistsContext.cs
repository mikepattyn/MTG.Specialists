using Microsoft.EntityFrameworkCore;

public class MtgSpecialistsContext : DbContext
{
    public DbSet<DomainCard> Cards { get; set; }
    public DbSet<DomainCardRuling> Rulings { get; set; }

    public MtgSpecialistsContext(DbContextOptions<MtgSpecialistsContext> options) : base(options)
    {

    }
}