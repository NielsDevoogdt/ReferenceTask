using System.Threading.Tasks;

namespace ReferenceTask.Persistence.Contracts
{
    public interface IApiService<T>
        where T : class
    {
        //Task<T> GetAsync();
        Task<T> GetJokesFromApi();
    }
}