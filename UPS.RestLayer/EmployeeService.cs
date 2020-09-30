using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UPS.Models;
using UPS.Models.Result;

namespace UPS.RestLayer
{
    public class EmployeeService
    { 
        private static string jsonData = "";
        private static RestService _restService = new RestService();
        private static Dictionary<string, string> dicResponseCodes = new Dictionary<string, string>()
        {
            {"200", "OK"},
            {"201", "A resource was successfully created in response to a POST request. The Location header contains the URL pointing to the newly created resource."},
            {"204", "The request was handled successfully and the response contains no body content (like a DELETE request)."},
            {"304", "The resource was not modified. You can use the cached version."},
            {"400", "Bad request. This could be caused by various actions by the user, such as providing invalid JSON data in the request body, providing invalid action parameters, etc."},
            {"401", "Authentication failed."},
            {"403", "The authenticated user is not allowed to access the specified API endpoint."},
            {"404", "The requested resource does not exist."},
            {"405", "Method not allowed. Please check the Allow header for the allowed HTTP methods."},
            {"415", "Unsupported media type. The requested content type or version number is invalid."},
            {"422", "Data validation failed (in response to a POST request, for example). Please check the response body for detailed error messages."},
            {"429", "Too many requests. The request was rejected due to rate limiting."},
            {"500", "Internal server error. This could be caused by internal program errors."}
        };

        public static EmployeesResult GetAllEmployees(long pageNum)
        {
            jsonData = Task.Run(() => _restService.GetAll(pageNum)).Result;
            EmployeesResult employeesResult = JsonConvert.DeserializeObject<EmployeesResult>(jsonData);
            return employeesResult;
        }

        public static EmployeesResult GetEmployeeByName(string name)
        {
            jsonData = Task.Run(() => _restService.GetByName(name)).Result;
            EmployeesResult employeesResult = JsonConvert.DeserializeObject<EmployeesResult>(jsonData);
            return employeesResult;
        }

        public static EmployeesResult GetEmployeeById(int id)
        {
            jsonData = Task.Run(() => _restService.GetById(id)).Result;
            EmployeesResult employeesResult = JsonConvert.DeserializeObject<EmployeesResult>(jsonData);
            return employeesResult;
        }

        public static string CreateEmployee(Employee employee)
        {
            jsonData = Task.Run(() => _restService.Post<Employee>(employee)).Result;
            return ResposeChecker(jsonData);  
        }

        public static string UpdateEmployee(Employee employee)
        {
            jsonData = Task.Run(() => _restService.Patch<Employee>(employee, employee.Id)).Result;
            return ResposeChecker(jsonData); 
        }

        public static string DeleteEmployee(int id)
        {
            jsonData = Task.Run(() => _restService.Delete(id)).Result;
            return ResposeChecker(jsonData); 
        }

        /// <summary>
        /// Shows the response code, status and error messages if there is.
        /// </summary>
        /// <param name="jsonData"></param>
        /// <returns></returns>
        public static string ResposeChecker(string jsonData)
        {
            var data = (JObject)JsonConvert.DeserializeObject(jsonData);
            string responseCode = data["code"].ToString();
            if (int.Parse(responseCode) >= 400)
            {
                var articles = data["data"].Children();
                StringBuilder sbErrorMessage = new StringBuilder();
                sbErrorMessage.AppendLine("Response Code: " + responseCode);
                if(dicResponseCodes.ContainsKey(responseCode)) sbErrorMessage.AppendLine("Response Details: " + dicResponseCodes[responseCode]); 
                sbErrorMessage.AppendLine("");
                sbErrorMessage.AppendLine("Error Details:");
                foreach (var article in articles)
                {
                    var author = article["field"].Value<string>();
                    var description = article["message"].Value<string>();
                    sbErrorMessage.AppendLine($"- field: " + author + ", Description: " + description + "\n");
                }
                return sbErrorMessage.ToString();
            }
            return dicResponseCodes[responseCode];
        }
    }
}
