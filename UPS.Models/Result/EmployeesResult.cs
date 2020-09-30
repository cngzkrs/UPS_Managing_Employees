using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UPS.Models.Result
{
    /// <summary>
    /// Response structure wrapper class
    /// </summary>
    public class EmployeesResult
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("data")]
        public List<Employee> Data { get; set; }
    }
}
