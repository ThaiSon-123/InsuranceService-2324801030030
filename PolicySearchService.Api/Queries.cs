using System;
using System.Collections.Generic;

namespace PolicySearchService.Api.Queries
{
    namespace Dtos
    {
        public class PolicyDto
        {
            public string PolicyNumber { get; set; }
            public string PolicyHolder { get; set; }
            public DateTime PolicyStartDate { get; set; }
            public DateTime PolicyEndDate { get; set; }
            public string ProductCode { get; set; }
            public decimal PremiumAmount { get; set; }
        }
    }

    public class FindPolicyResult
    {
        public List<Dtos.PolicyDto> Policies { get; set; } = new();
    }
}
