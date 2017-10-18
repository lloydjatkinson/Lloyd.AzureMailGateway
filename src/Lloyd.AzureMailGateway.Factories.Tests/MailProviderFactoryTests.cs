using System;
using System.Collections.Generic;
using AutoMapper;
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

            var mapper = Substitute.For<IMapper>();
            var configuration = Substitute.For<IConfigurationLoader>();
            configuration.GetConfiguration().Returns(new Dictionary<string, string>()
            {
                { "MailProvider", "SendGrid" }
            });

            var factory = new MailProviderFactory();

            // Act

            var provider = factory.GetProvider(configuration, mapper);

            // Assert

            provider.ShouldNotBeNull();
            provider.ShouldBeOfType<SendGridProvider>();
        }

        [Fact]
        public void ShouldThrowWhenMailProviderKeyDoesNotExist()
        {
            // Arrange

            var mapper = Substitute.For<IMapper>();
            var configuration = Substitute.For<IConfigurationLoader>();
            configuration.GetConfiguration().Returns(new Dictionary<string, string>());

            var factory = new MailProviderFactory();

            // Act / Assert

            Should.Throw<InvalidOperationException>(() => factory.GetProvider(configuration, mapper));
        }

        [Fact]
        public void ShouldThrowWhenUnknownProviderIsGiven()
        {
            // Arrange

            var mapper = Substitute.For<IMapper>();
            var configuration = Substitute.For<IConfigurationLoader>();
            configuration.GetConfiguration().Returns(new Dictionary<string, string>()
            {
                { "MailProvider", "NotARealProvider" }
            });

            var factory = new MailProviderFactory();

            // Act / Assert

            Should.Throw<ArgumentException>(() => factory.GetProvider(configuration, mapper));
        }

        [Fact]
        public void ShouldThrowWhenInvalidNumberIsGiven()
        {
            // Arrange

            var mapper = Substitute.For<IMapper>();
            var configuration = Substitute.For<IConfigurationLoader>();
            configuration.GetConfiguration().Returns(new Dictionary<string, string>());
            var factory = new MailProviderFactory();

            // Act / Assert

            Should.Throw<ArgumentOutOfRangeException>(() => factory.GetProvider(configuration, mapper, (Provider)100));
        }
    }
}