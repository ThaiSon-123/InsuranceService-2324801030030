using PricingService.Domain;

namespace PricingService.Data;

public class TariffEntity
{
    public string Code { get; set; } = "";
    public List<BasePremiumRuleEntity> BasePremiumRules { get; set; } = new();
    public List<MarkupRuleEntity> MarkupRules { get; set; } = new();

    public static TariffEntity FromDomain(Tariff tariff)
    {
        return new TariffEntity
        {
            Code = tariff.Code,
            BasePremiumRules = tariff.BasePremiumRules.Rules
                .Select(r => new BasePremiumRuleEntity
                    { TariffCode = tariff.Code, CoverCode = r.CoverCode, AppliesIf = r.AppliesIf, Formula = r.Formula })
                .ToList(),
            MarkupRules = tariff.DiscountMarkupRules.Rules
                .Select(r => new MarkupRuleEntity
                    { TariffCode = tariff.Code, AppliesIf = r.AppliesIf, Multiplier = r.Multiplier })
                .ToList()
        };
    }

    public Tariff ToDomain()
    {
        var tariff = new Tariff(Code);
        foreach (var rule in BasePremiumRules.OrderBy(r => r.Id))
        {
            tariff.BasePremiumRules.AddBasePriceRule(rule.CoverCode, rule.AppliesIf, rule.Formula);
        }

        foreach (var rule in MarkupRules.OrderBy(r => r.Id))
        {
            tariff.DiscountMarkupRules.AddPercentMarkup(rule.AppliesIf, rule.Multiplier);
        }

        return tariff;
    }
}

public class BasePremiumRuleEntity
{
    public int Id { get; set; }
    public string TariffCode { get; set; } = "";
    public string CoverCode { get; set; } = "";
    public string? AppliesIf { get; set; }
    public string Formula { get; set; } = "";
}

public class MarkupRuleEntity
{
    public int Id { get; set; }
    public string TariffCode { get; set; } = "";
    public string? AppliesIf { get; set; }
    public decimal Multiplier { get; set; }
}
