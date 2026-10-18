namespace PricingService.Domain;

public class Tariff
{
    public Tariff(string code)
    {
        Code = code;
    }

    public string Code { get; }
    public BasePremiumRules BasePremiumRules { get; } = new();
    public DiscountMarkupRules DiscountMarkupRules { get; } = new();

    public Price CalculatePrice(Calculation calculation)
    {
        var multiplier = DiscountMarkupRules.Multiplier(calculation.Subject);

        var covers = calculation.SelectedCovers.ToDictionary(
            coverCode => coverCode,
            coverCode => new CoverPrice(
                coverCode,
                BasePremiumRules.Calculate(coverCode, calculation.Subject) * multiplier));

        return new Price(covers);
    }
}
