using System;
using Shouldly;

namespace Lloyd.AzureMailGateway.Models.Tests
{
    public class EMailBuilderTests
    {
        //[Fact]
        //public void BuilderShouldReturnNonNullEMailInstance()
        //{
        //    // Arrange
        //    var builder = new EMailBuilder();


        //    // Act
        //    var email = new EMailBuilder().Build();


        //    // Assert

        //}

        public void BuildShouldThrowOnInvalidState()
        {
            // Arrange
            var builder = new EMailBuilder();


            // Act / Assert
            Should.Throw<InvalidOperationException>(() => new EMailBuilder().Build());
        }
    }
}
