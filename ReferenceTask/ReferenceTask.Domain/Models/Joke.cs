namespace ReferenceTask.Domain.Models
{
    public class Joke
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }

        public Joke(string id, string text, int rating)
        {
            Id = id;
            Text = text;
            Rating = rating;

        }
        
    }
}
