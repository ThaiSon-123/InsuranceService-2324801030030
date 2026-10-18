using Microsoft.EntityFrameworkCore;
using PricingService.Domain;

namespace PricingService.Data;

public class TariffRepository : ITariffRepository
{
    private readonly PricingDbContext db;

    public TariffRepository(PricingDbContext db)
    {
        this.db = db;
    }

    public Task<Tariff> this[string productCode] => Load(productCode);

    private async Task<Tariff> Load(string productCode)
    {
        var entity = await db.Tariffs
            .AsNoTracking()
            .Include(t => t.BasePremiumRules)
            .Include(t => t.MarkupRules)
            .AsSplitQuery()
            .SingleOrDefaultAsync(t => t.Code == productCode);

        if (entity == null)
        {
            throw new PricingException($"There is no tariff for product '{productCode}'.");
        }

        return entity.ToDomain();
    }
}

public class DataStore : IDataStore
{
    public DataStore(ITariffRepository tariffs)
    {
        Tariffs = tariffs;
    }

    public ITariffRepository Tariffs { get; }
}
