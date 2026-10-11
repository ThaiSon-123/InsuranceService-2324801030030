#nullable disable
using System;
using System.Collections.Generic;

namespace DashboardService.Api.Queries
{
    public enum TimeUnit { Day, Week, Month, Year }

    public class SalesDto
    {
        public decimal PremiumAmount { get; set; }
        public int PoliciesCount { get; set; }
    }

    public class TotalSalesDto
    {
        public decimal PremiumAmount { get; set; }
        public int PoliciesCount { get; set; }
    }

    public class PeriodSaleDto
    {
        public string Period { get; set; }
        public SalesDto Sales { get; set; } = new();
        public decimal PremiumAmount { get; set; }
        public DateTime PeriodDate { get; set; }
    }

    public class GetTotalSalesQuery
    {
        public string ProductCode { get; set; }
        public DateTime? SalesDateFrom { get; set; }
        public DateTime? SalesDateTo { get; set; }
    }

    public class GetTotalSalesResult
    {
        public TotalSalesDto Total { get; set; } = new();
        public Dictionary<string, SalesDto> PerProductTotal { get; set; } = new();
        public Dictionary<string, SalesDto> PerMonth { get; set; } = new();
    }

    public class GetAgentsSalesQuery
    {
        public DateTime? SalesDateFrom { get; set; }
        public DateTime? SalesDateTo { get; set; }
    }

    public class GetAgentsSalesResult
    {
        public Dictionary<string, SalesDto> PerAgentTotal { get; set; } = new();
        public Dictionary<string, SalesDto> PerMonth { get; set; } = new();
    }

    public class GetSalesTrendsQuery
    {
        public DateTime? SalesDateFrom { get; set; }
        public DateTime? SalesDateTo { get; set; }
        public TimeUnit Unit { get; set; }
    }

    public class GetSalesTrendsResult
    {
        public List<PeriodSaleDto> PeriodsSales { get; set; } = new();
    }

    namespace Dtos
    {
        public class SalesAgentDto
        {
            public string AgentLogin { get; set; }
            public decimal Sales { get; set; }
        }
    }
}
