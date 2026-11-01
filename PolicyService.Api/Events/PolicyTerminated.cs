using MediatR;

namespace PolicyService.Api.Events;

/// <summary>Published to the event bus (RabbitMQ) after a policy has been terminated.</summary>
public class PolicyTerminated : INotification
{
    public string PolicyNumber { get; set; } = "";
    public DateTime PolicyFrom { get; set; }
    public DateTime PolicyTo { get; set; }
    public string ProductCode { get; set; } = "";
    public decimal? AmountToReturn { get; set; }
}
