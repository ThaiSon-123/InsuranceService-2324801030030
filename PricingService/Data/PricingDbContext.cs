using Microsoft.EntityFrameworkCore;

namespace PricingService.Data;

public class PricingDbContext : DbContext
{
    public PricingDbContext(DbContextOptions<PricingDbContext> options) : base(options)
    {
    }

    public DbSet<TariffEntity> Tariffs => Set<TariffEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TariffEntity>(e =>
        {
            e.ToTable("tariffs");
            e.HasKey(t => t.Code);
            e.Property(t => t.Code).HasMaxLength(20);
            e.HasMany(t => t.BasePremiumRules).WithOne().HasForeignKey(r => r.TariffCode);
            e.HasMany(t => t.MarkupRules).WithOne().HasForeignKey(r => r.TariffCode);
        });

        modelBuilder.Entity<BasePremiumRuleEntity>(e =>
        {
            e.ToTable("base_premium_rules");
            e.HasKey(r => r.Id);
        });

        modelBuilder.Entity<MarkupRuleEntity>(e =>
        {
            e.ToTable("markup_rules");
            e.HasKey(r => r.Id);
            e.Property(r => r.Multiplier).HasPrecision(10, 4);
        });
    }
}
