using System.Collections.Generic;
using System.Threading.Tasks;
using ReferenceTask.Domain.Models;
using ReferenceTask.Persistence.Contracts;
using ReferenceTask.Persistence.Models;

namespace ReferenceTask.Domain.Repositories
{
    public class JokeRepository
    {
        private readonly IApiService<JokeList> _apiService;

        public JokeRepository(IApiService<JokeList> jokeApiService)
        {
            _apiService = jokeApiService;
        }
        
        public async Task<IList<Joke>> GetJokes()
        {
            //var jokes = await apiService.GetAsync();
            var input = await _apiService.GetJokesFromApi();
            var jokes = new List<Joke>();

            //foreach (var jokeInfo in input.Value)
            //{
            //    jokes.Add(new Joke(jokeInfo.Id, jokeInfo.Joke,0));
            //}

            return jokes;
        }
    }
}