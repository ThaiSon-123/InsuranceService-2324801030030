namespace PricingService.Domain;

public record PercentMarkupRule(string? AppliesIf, decimal Multiplier);

/// <summary>Rules that raise or lower the premium, e.g. a multiplier of 1.5 is a 50% markup.</summary>
public class DiscountMarkupRules
{
    private readonly List<PercentMarkupRule> rules = new();

    public IReadOnlyList<PercentMarkupRule> Rules => rules;

    public void AddPercentMarkup(string? appliesIf, decimal multiplier)
    {
        rules.Add(new PercentMarkupRule(appliesIf, multiplier));
    }

    /// <summary>Product of the multipliers of every rule whose condition holds.</summary>
    public decimal Multiplier(IReadOnlyDictionary<string, object> subject)
    {
        return rules
            .Where(r => RuleEvaluator.IsTrue(r.AppliesIf, subject))
            .Aggregate(1M, (total, rule) => total * rule.Multiplier);
    }
}
