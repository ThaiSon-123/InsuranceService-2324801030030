using DynamicExpresso;
using DynamicExpresso.Exceptions;

namespace PricingService.Domain;

/// <summary>
/// Evaluates the C#-like expressions stored in tariff rules against the answers given for a calculation.
/// </summary>
internal static class RuleEvaluator
{
    /// <summary>
    /// A missing condition always applies. A condition that refers to an unanswered question does not apply.
    /// </summary>
    public static bool IsTrue(string? condition, IReadOnlyDictionary<string, object> subject)
    {
        if (string.IsNullOrWhiteSpace(condition))
        {
            return true;
        }

        try
        {
            return (bool)CreateInterpreter(subject).Eval(condition);
        }
        catch (UnknownIdentifierException)
        {
            return false;
        }
    }

    public static decimal EvaluateAmount(string formula, IReadOnlyDictionary<string, object> subject)
    {
        try
        {
            return Convert.ToDecimal(CreateInterpreter(subject).Eval(formula));
        }
        catch (UnknownIdentifierException e)
        {
            throw new PricingException($"Missing answer for '{e.Identifier}' needed by formula '{formula}'.");
        }
    }

    private static Interpreter CreateInterpreter(IReadOnlyDictionary<string, object> subject)
    {
        var interpreter = new Interpreter();
        foreach (var (name, value) in subject)
        {
            if (value != null)
            {
                interpreter.SetVariable(name, value);
            }
        }

        return interpreter;
    }
}

public class PricingException : Exception
{
    public PricingException(string message) : base(message)
    {
    }
}
