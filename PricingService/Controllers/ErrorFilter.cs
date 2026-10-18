using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PricingService.Domain;

namespace PricingService.Controllers;

/// <summary>Turns invalid commands and unknown products/missing answers into 400 responses.</summary>
public class ErrorFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        switch (context.Exception)
        {
            case ValidationException validation:
                context.Result = new BadRequestObjectResult(
                    validation.Errors.Select(e => new { e.PropertyName, e.ErrorMessage }));
                context.ExceptionHandled = true;
                break;
            case PricingException pricing:
                context.Result = new BadRequestObjectResult(new { error = pricing.Message });
                context.ExceptionHandled = true;
                break;
        }
    }
}
