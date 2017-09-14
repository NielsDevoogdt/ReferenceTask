using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ReferenceTask.Persistence.Contracts;
using ReferenceTask.Persistence.Models;
using ReferenceTask.Persistence.Services.Adapters;


namespace ReferenceTask.Persistence.Services
{
    public class JokeApiService
        : IApiService<HttpResponseMessage>
    {
        private readonly IHttpClientAdapter _httpClient;

        public JokeApiService()
        {
            _httpClient = new HttpClientAdapter();
        }

        //public async Task<JokeList> GetJokesFromApi()
        public async Task<HttpResponseMessage> GetJokesFromApi()
        //public Task<JokeList> IApiService<JokeList>.GetJokesFromApi()
        {

            var response = await _httpClient.GetAsync("jokes/random/10");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            // moved to mapper
            //var jokesJson = await GetJsonAsString(response);

            //var jokes = JsonConvert.DeserializeObject<JokeList>(jokesJson);

            //return jokes;
            return response;
        }

        //Task<JokeList> IApiService<JokeList>.GetJokesFromApi()
        //{
        //    throw new NotImplementedException();
        //}
        // moved to ApiToJokelistmapper
        //private async Task<string> GetJsonAsString(HttpResponseMessage response)
        //{
        //    var jokesJson = await response.Content.ReadAsStringAsync();

        //    return jokesJson;
        //}
    }
}