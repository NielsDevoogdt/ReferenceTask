using ReferenceTask.Domain.Models;
using TestSupport;
using Xunit;

namespace ReferenceTask.Domain.Test.Models
{
    public class JokeTest
        : ArrangeActAssertTest
    {
        private Joke _sut;
        private string _id;
        private string _text;
        private int _rating;

        protected override void Arrange()
        {
            _id = "001";
            _text = "Chuck Norris doesn't breath, breath breaths Chuck Norris";
            _rating = 1;

        }
        protected override void Act()
        {
            _sut = new Joke(_id, _text, _rating);

        }

        [Fact]
        public void Then_It_Should_Create_Valid_Instance()
        {
            Setup();
            Assert.NotNull(_sut);
        }

    }
}
