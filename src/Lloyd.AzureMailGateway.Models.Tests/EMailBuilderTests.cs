using System;
using System.Linq;
using AutoFixture.Xunit2;
using Shouldly;
using Xunit;

namespace Lloyd.AzureMailGateway.Models.Tests
{
    public class EMailBuilderTests
    {
        [Fact]
        public void BuildShouldThrowOnInvalidState()
        {
            // Arrange
            var builder = new EMailBuilder();

            // Act / Assert
            Should.Throw<InvalidOperationException>(() => new EMailBuilder().Build());
        }

        [Theory, AutoData]
        public void BuilderShouldSetToAndFromProperties(Address toAddress, Address fromAddress)
        {
            // Arrange
            var builder = new EMailBuilder();

            // Act
            builder
                .To(toAddress.EMail, toAddress.Name)
                .From(fromAddress.EMail, fromAddress.Name);

            var email = builder.Build();

            // Assert
            email.To.Addresses.First().EMail.ShouldBe(toAddress.EMail);
            email.To.Addresses.First().Name.ShouldBe(toAddress.Name);
        }
    }
}