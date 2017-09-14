
using ReferenceTask.Persistence.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReferenceTask.Mappers
{
    public class ApiToJokeListMapper
    {

        public ApiToJokeListMapper()
        {

        }

        public async Task<JokeList> ConvertJsonToJokeList(HttpResponseMessage json)
        {

            var jokesJson = await GetJsonAsString(json);

            var jokes = JsonConvert.DeserializeObject<JokeList>(jokesJson);

            return jokes;

        }

        private async Task<string> GetJsonAsString(HttpResponseMessage response)
        {
            var jokesJson = await response.Content.ReadAsStringAsync();

            return jokesJson;
        }

    }
}