#nullable disable
using System;
using System.Collections.Generic;

namespace ProductService.Api.Queries
{
    namespace Dtos
    {
        public enum QuestionType { Choice, Numeric }

        public class QuestionDto
        {
            public string QuestionCode { get; set; }
            public QuestionType QuestionType { get; set; }
            public string Text { get; set; }
            public int Index { get; set; }
        }

        public class ChoiceQuestionDto : QuestionDto
        {
            public List<ChoiceDto> Choices { get; set; } = new();
        }

        public class NumericQuestionDto : QuestionDto { }

        public class ChoiceDto
        {
            public string Code { get; set; }
            public string Label { get; set; }
        }

        public class CoverDto
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal SumInsured { get; set; }
        }

        public class ProductDto
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
            public string Icon { get; set; }
            public string Description { get; set; }
            public List<QuestionDto> Questions { get; set; } = new();
            public List<CoverDto> Covers { get; set; } = new();
            public decimal MaxPrice { get; set; }
        }

        public class QuestionAnswer
        {
            public string QuestionCode { get; set; }
            public QuestionType QuestionType { get; set; }
            public object Answer { get; set; }
        }

        public class ChoiceQuestionAnswer : QuestionAnswer { }
        public class NumericQuestionAnswer : QuestionAnswer { }
    }
}
