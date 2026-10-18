namespace PricingService.Domain;

public interface ITariffRepository
{
    /// <summary>Loads the tariff of a product, throws <see cref="PricingException"/> if there is none.</summary>
    Task<Tariff> this[string productCode] { get; }
}

public interface IDataStore
{
    ITariffRepository Tariffs { get; }
}
