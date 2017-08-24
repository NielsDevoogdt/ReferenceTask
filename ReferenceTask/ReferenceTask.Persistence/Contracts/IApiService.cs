using System.Collections.Generic;

namespace ReferenceTask.Persistence.Contracts
{
    public interface IApiService
    {
        IEnumerable<Joke> Get();
    }
}