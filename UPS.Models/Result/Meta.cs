using System;
using Newtonsoft.Json;

namespace UPS.Models.Result
{
    public class Meta
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }
}
