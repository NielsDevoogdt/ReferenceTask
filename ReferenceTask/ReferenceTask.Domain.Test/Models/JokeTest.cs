using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReferenceTask.Domain;

namespace ReferenceTask.Domain.Test
{
    [TestClass]
    public class JokeTest
    {

        [TestMethod]
        public void Then_It_Should_Create_Valid_Instance()
        {
            //Arrange
            Joke _sut = new Joke("Chuck Norris doesn't breath, breath breaths Chuck Norris", 1);

            //Act

            //Assert
            Assert.IsNotNull((_sut));

        }




    }
}
