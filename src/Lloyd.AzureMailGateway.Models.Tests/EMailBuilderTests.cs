using System;
using Shouldly;
using Xunit;

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

        [Fact]
        public void BuildShouldThrowOnInvalidState()
        {
            // Arrange
            var builder = new EMailBuilder();

            // Act / Assert
            Should.Throw<InvalidOperationException>(() => new EMailBuilder().Build());
        }
    }
}