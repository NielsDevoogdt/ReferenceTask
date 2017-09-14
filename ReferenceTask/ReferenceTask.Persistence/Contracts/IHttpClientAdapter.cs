using System.Net.Http;
using System.Threading.Tasks;

namespace ReferenceTask.Persistence.Contracts
{
    public interface IHttpClientAdapter
    {
        Task<HttpResponseMessage> GetAsync(string query);
    }
}