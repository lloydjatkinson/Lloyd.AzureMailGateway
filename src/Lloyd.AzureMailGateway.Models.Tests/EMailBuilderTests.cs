using System;
using System.Collections.Generic;
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

        [Theory, AutoData]
        public void BuilderToOverloadShouldSetProperties(IEnumerable<Address> toAddresses, Address fromAddress)
        {
            // Arrange
            var builder = new EMailBuilder();

            // Act
            builder
                .To(toAddresses)
                .From(fromAddress.EMail, fromAddress.Name);

            var email = builder.Build();

            // Assert
            email.To.Addresses.ShouldBe(toAddresses);
        }

        [Theory, AutoData]
        public void BuilderShouldSetCcProperty(Address toAddress, Address fromAddress, Address ccAddress)
        {
            // Arrange
            var builder = new EMailBuilder();

            // Act
            builder
                .To(toAddress.EMail, toAddress.Name)
                .From(fromAddress.EMail, fromAddress.Name)
                .Cc(ccAddress.EMail, ccAddress.Name);

            var email = builder.Build();

            // Assert
            email.Cc.Addresses.First().EMail.ShouldBe(ccAddress.EMail);
            email.Cc.Addresses.First().Name.ShouldBe(ccAddress.Name);
        }

        [Theory, AutoData]
        public void BuilderShouldSetBccProperty(Address toAddress, Address fromAddress, Address bccAddress)
        {
            // Arrange
            var builder = new EMailBuilder();

            // Act
            builder
                .To(toAddress.EMail, toAddress.Name)
                .From(fromAddress.EMail, fromAddress.Name)
                .Bcc(bccAddress.EMail, bccAddress.Name);

            var email = builder.Build();

            // Assert
            email.Bcc.Addresses.First().EMail.ShouldBe(bccAddress.EMail);
            email.Bcc.Addresses.First().Name.ShouldBe(bccAddress.Name);
        }

        [Theory, AutoData]
        public void BuilderShouldSetSubjectProperty(Address toAddress, Address fromAddress, string subject)
        {
            // Arrange
            var builder = new EMailBuilder();

            // Act
            builder
                .To(toAddress.EMail, toAddress.Name)
                .From(fromAddress.EMail, fromAddress.Name)
                .Subject(subject);

            var email = builder.Build();

            // Assert
            email.Subject.Text.ShouldBe(subject);
        }
    }
}