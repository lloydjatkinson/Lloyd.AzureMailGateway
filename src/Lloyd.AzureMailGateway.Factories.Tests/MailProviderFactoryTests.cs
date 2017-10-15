using System;
using System.Collections.Generic;
using Lloyd.AzureMailGateway.Core;
using Lloyd.AzureMailGateway.Providers;
using NSubstitute;
using Shouldly;
using Xunit;

namespace Lloyd.AzureMailGateway.Factories.Tests
{
    public class MailProviderFactoryTests
    {
        [Fact]
        public void ShouldReturnCorrectProvider()
        {
            // Arrange

            var configuration = Substitute.For<IConfigurationLoader>();
            configuration.GetConfiguration().Returns(new Dictionary<string, string>()
            {
                { "MailProvider", "SendGrid" }
            });

            var factory = new MailProviderFactory();

            // Act

            var provider = factory.GetProvider(configuration);

            // Assert

            provider.ShouldNotBeNull();
            provider.ShouldBeOfType<SendGridProvider>();
        }

        [Fact]
        public void ShouldThrowWhenMailProviderKeyDoesNotExist()
        {
            // Arrange

            var configuration = Substitute.For<IConfigurationLoader>();
            configuration.GetConfiguration().Returns(new Dictionary<string, string>());

            var factory = new MailProviderFactory();

            // Act / Assert

            Should.Throw<InvalidOperationException>(() => factory.GetProvider(configuration));
        }

        [Fact]
        public void ShouldThrowWhenUnknownProviderIsGiven()
        {
            // Arrange

            var configuration = Substitute.For<IConfigurationLoader>();
            configuration.GetConfiguration().Returns(new Dictionary<string, string>()
            {
                { "MailProvider", "NotARealProvider" }
            });

            var factory = new MailProviderFactory();

            // Act / Assert

            Should.Throw<ArgumentException>(() => factory.GetProvider(configuration));
        }

        [Fact]
        public void ShouldThrowWhenInvalidNumberIsGiven()
        {
            // Arrange

            var configuration = Substitute.For<IConfigurationLoader>();
            configuration.GetConfiguration().Returns(new Dictionary<string, string>());
            var factory = new MailProviderFactory();

            // Act / Assert

            Should.Throw<ArgumentOutOfRangeException>(() => factory.GetProvider(configuration, (Provider)100));
        }
    }
}