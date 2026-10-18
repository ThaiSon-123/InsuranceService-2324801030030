namespace PricingService.Domain;

public record BasePremiumRule(string CoverCode, string? AppliesIf, string Formula);

/// <summary>Rules that give the base premium of every cover.</summary>
public class BasePremiumRules
{
    private readonly List<BasePremiumRule> rules = new();

    public IReadOnlyList<BasePremiumRule> Rules => rules;

    public void AddBasePriceRule(string coverCode, string? appliesIf, string formula)
    {
        rules.Add(new BasePremiumRule(coverCode, appliesIf, formula));
    }

    /// <summary>Uses the first rule of the cover whose condition holds.</summary>
    public decimal Calculate(string coverCode, IReadOnlyDictionary<string, object> subject)
    {
        var rule = rules.FirstOrDefault(r => r.CoverCode == coverCode && RuleEvaluator.IsTrue(r.AppliesIf, subject));
        if (rule == null)
        {
            throw new PricingException($"No base premium rule applies to cover '{coverCode}'.");
        }

        return RuleEvaluator.EvaluateAmount(rule.Formula, subject);
    }
}
