using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using ReferenceTask.Persistence.Contracts;

namespace ReferenceTask.Persistence.Services.Adapters
{
    public class HttpClientAdapter
        : IHttpClientAdapter
    {
        private HttpClient _httpClient;

        public HttpClientAdapter()
        {
            //_httpClient = new HttpClient {BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"])};
            _httpClient = new HttpClient {BaseAddress = new Uri("https://api.icndb.com")};
        }

        public async Task<HttpResponseMessage> GetAsync(string query)
        {
            return await _httpClient.GetAsync(query);
        }
    }
}