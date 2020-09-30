using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UPS.RestLayer
{
    public class RestService
    {
        private static string url = "https://gorest.co.in/public-api/users";
        static HttpClient client = new HttpClient();

        public RestService() {
            client.Timeout = TimeSpan.FromMilliseconds(10000);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
        }
        public async Task<string> GetAll(long pageNum)
        {
            using (HttpResponseMessage response = await client.GetAsync($"{url}?page={pageNum}", HttpCompletionOption.ResponseHeadersRead))
            {
                Debug.WriteLine("GetAll : " + $"{url}?page={pageNum}");
                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> GetByName(string name )
        {
            using (HttpResponseMessage response = await client.GetAsync($"{url}?name={name}"))
            {
                Debug.WriteLine("GetByName : " + $"{url}?name={name}");
                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> GetById(long id)
        {
            using (HttpResponseMessage response = await client.GetAsync($"{url}?id={id}"))
            {
                Debug.WriteLine("GetSingle : " + $"{url}?id={id}");
                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> Post<T>(T instance) where T : class, new()
        {
            StringContent httpContent = new StringContent(JsonConvert.SerializeObject(instance), Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await client.PostAsync($"{url}", httpContent))
            {
                Debug.WriteLine("GET-Post : " + $"{url}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> Patch<T>(T instance, long id) where T : class, new()
        {
            StringContent httpContent = new StringContent(JsonConvert.SerializeObject(instance), Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await client.PatchAsync($"{url}/{id}", httpContent))
            {
                Debug.WriteLine("GET-Patch : " + $"{url}/{id}");
                string ss = response.StatusCode.ToString();
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> Delete(long id)
        {
            using (HttpResponseMessage response = await client.DeleteAsync($"{url}/{id}"))
            {
                Debug.WriteLine("GET-Delete : " + $"{url}/{id}");
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
