using MediatR;
using PolicyService.Api.Commands.Dtos;

namespace PolicyService.Api.Events;

/// <summary>Published to the event bus (RabbitMQ) after a policy has been created.</summary>
public class PolicyCreated : INotification
{
    public string PolicyNumber { get; set; } = "";
    public DateTime PolicyFrom { get; set; }
    public DateTime PolicyTo { get; set; }
    public string ProductCode { get; set; } = "";
    public decimal TotalPremium { get; set; }
    public PersonDto PolicyHolder { get; set; } = new();
    public string AgentLogin { get; set; } = "";
}
