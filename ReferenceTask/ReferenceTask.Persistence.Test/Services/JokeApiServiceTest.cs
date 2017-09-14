using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Moq;
using ReferenceTask.Persistence.Models;
using ReferenceTask.Persistence.Services;
using ReferenceTask.Persistence.Services.Adapters;
using TestSupport;
using Xunit;

namespace ReferenceTask.Persistence.Test.Services
{
    public class JokeApiServiceTestBasicSetup : ArrangeActAssertTest
    {
        //private JokeApiService _sut;
        protected JokeApiService _sut;
        protected HttpClientAdapter _httpclientAdapter;
        protected override void Arrange()
        {

        }
        protected override void Act()
        {
            _sut = new JokeApiService();
        }

        [Fact]
        public void Then_It_Should_Create_Valid_Instance()
        {
            Setup();
            Assert.NotNull(_sut);
        }

    }

    public class JokeApiServiceTestMethods : JokeApiServiceTestBasicSetup
    {
        //private JokeApiService _sut;
        private Mock<HttpClientAdapter> _httpclientAdapterMock;
        private HttpResponseMessage _result;

        protected override void Arrange()
        {
            base.Arrange();
            _httpclientAdapterMock = new Mock<HttpClientAdapter>();
        }
        protected override void Act()
        {
            //_sut = new JokeApiService();
            base.Act();
            RunAsync();
        }

        private async void RunAsync()
        {
            _result = await _sut.GetJokesFromApi();
        }

        [Fact]
        public void Then_It_Should_Get_A_Valid_StatusCode()
        {
            Setup();
            Assert.Equal(HttpStatusCode.ProxyAuthenticationRequired, _result.StatusCode);
        }

        //[Fact]
        //public void Then_It_Should_Get_A_Valid_StatusCode_And_String()
        //{

        //}
    }
}
