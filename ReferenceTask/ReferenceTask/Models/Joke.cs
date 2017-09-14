namespace ReferenceTask.Models
{
    public class Joke
    {
        public string Text { get; set; }
        public int Rating { get; set; }

        public Joke(string text, int rating)
        {
            Text = text;
            Rating = rating;

        }
        
    }
}
