namespace PricingService.Domain;

public class Calculation
{
    public Calculation(
        string productCode,
        DateTimeOffset policyFrom,
        DateTimeOffset policyTo,
        IReadOnlyList<string> selectedCovers,
        IReadOnlyDictionary<string, object> subject)
    {
        ProductCode = productCode;
        PolicyFrom = policyFrom;
        PolicyTo = policyTo;
        SelectedCovers = selectedCovers;
        Subject = subject;
    }

    public string ProductCode { get; }
    public DateTimeOffset PolicyFrom { get; }
    public DateTimeOffset PolicyTo { get; }
    public IReadOnlyList<string> SelectedCovers { get; }

    /// <summary>Answers to the product questions, keyed by question code.</summary>
    public IReadOnlyDictionary<string, object> Subject { get; }
}
