#nullable disable
namespace ProductService.Api.Queries.Dtos;

// Not part of the sample code, but still used by PolicyService.Api and BlazorWasmClient.
public class QuestionAnswer
{
    public string QuestionCode { get; set; }
    public QuestionType QuestionType { get; set; }
    public object Answer { get; set; }
}

public class ChoiceQuestionAnswer : QuestionAnswer { }

public class NumericQuestionAnswer : QuestionAnswer { }
