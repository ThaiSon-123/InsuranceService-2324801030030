using System;
using System.Collections.Generic;
using ProductService.Api.Queries.Dtos;

namespace PolicyService.Api.Commands
{
    namespace Dtos
    {
        public class PersonDto
        {
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public string TaxId { get; set; } = "";
            public AddressDto Address { get; set; } = new();
        }

        public class AddressDto
        {
            public string Country { get; set; } = "";
            public string ZipCode { get; set; } = "";
            public string City { get; set; } = "";
            public string Street { get; set; } = "";
        }
    }

    public class CreateOfferCommand
    {
        public string ProductCode { get; set; } = "";
        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
        public DateTime PolicyFrom { get; set; }
        public DateTime PolicyTo { get; set; }
        public Dtos.PersonDto PolicyHolder { get; set; } = new();
        public List<QuestionAnswer> Answers { get; set; } = new();
        public List<string> SelectedCovers { get; set; } = new();
    }

    public class CreateOfferResult
    {
        public string OfferNumber { get; set; } = "";
        public decimal TotalPrice { get; set; }
    }

    public class CreatePolicyCommand
    {
        public string OfferNumber { get; set; } = "";
        public Dtos.PersonDto PolicyHolder { get; set; } = new();
        public Dtos.AddressDto PolicyHolderAddress { get; set; } = new();
    }

    public class CreatePolicyResult
    {
        public string PolicyNumber { get; set; } = "";
    }
}

namespace PolicyService.Api.Queries
{
    public class PolicyDto
    {
        public string Number { get; set; } = "";
        public string ProductCode { get; set; } = "";
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal TotalPremium { get; set; }
        public Commands.Dtos.PersonDto PolicyHolder { get; set; } = new();
        public List<string> Covers { get; set; } = new();
    }

    public class GetPolicyDetailsQueryResult
    {
        public PolicyDto Policy { get; set; } = new();
        public string PolicyNumber { get; set; } = "";
        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
        public decimal TotalPremium { get; set; }
        public Commands.Dtos.PersonDto PolicyHolder { get; set; } = new();
        public List<CoverDto> Covers { get; set; } = new();
    }
}
