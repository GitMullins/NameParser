using System;
using Xunit;

namespace NameParser.Tests
{
    public class NameParsingTests
    {
        [Fact]
        public void FirstAndLastNameShouldBeParsedAccurately()
        {
            //Arrange
            var name = "Martin Cross";
            var parser = new Parser();

            //Act
            var result = parser.ParseName(name);

            //Assert
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal(result.LastName, "Cross");
        }
    }
}
