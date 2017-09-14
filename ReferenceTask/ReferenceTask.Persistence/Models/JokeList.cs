using System.Collections.Generic;

namespace ReferenceTask.Persistence.Models
{
    public class JokeList
    {

        public string Type { get; set; }
        //public JokeInfo[] Value { get; set; }
        public IEnumerable<JokeInfo> Value { get; set; }
        //public List<Joke>[] Value { get; set; }
        //public string Value { get; set; }
    }
}