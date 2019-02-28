using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InsuranceClaims.Models
{
    public class AutoClaim
    {
        [JsonProperty(PropertyName = "claimIdIdentity")]
        
        public int claimIdIdentity { get; set; }

        [JsonProperty(PropertyName = "claimNumber")]

        public string claimNumber { get; set; }


        [JsonProperty(PropertyName = "MakeModel")]
        public string MakeModel { get; set; }

        [JsonProperty(PropertyName = "ClaimTitle")]
        public string ClaimTitle { get; set; }

        [JsonProperty(PropertyName = "PolicyNumber")]
        public string PolicyNumber { get; set; }

        [JsonProperty(PropertyName = "InsuredName")]
        public string InsuredName { get; set; }

        [JsonProperty(PropertyName = "DateOfEvent")]
        public string DateOfEvent { get; set; }

        [JsonProperty(PropertyName = "DateReceieved")]
        public string DateReceieved { get; set; }

        [JsonProperty(PropertyName = "producercode")]
        public string ProducerCode { get; set; }

        [JsonProperty(PropertyName = "EventLocation")]
        public string EventLocation { get; set; }

        [JsonProperty(PropertyName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty(PropertyName = "InsuranceCompany")]
        public string InsuranceCompany { get; set; }
        [JsonProperty(PropertyName = "NumberOfvehicle")]
        public string NumberOfvehicle { get; set; }
        [JsonProperty(PropertyName = "EventInfo")]

        public string EventInfo { get; set; }

        [JsonProperty(PropertyName = "SupportingDoc")]
        public string SupportingDoc { get; set; }

    }
}
