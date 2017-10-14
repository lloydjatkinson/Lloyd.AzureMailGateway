using System;
using Lloyd.AzureMailGateway.Core;
using Lloyd.AzureMailGateway.Providers;

namespace Lloyd.AzureMailGateway.Factories
{
    public class MailProviderFactory : IMailProviderFactory
    {
        public IMailProvider GetProvider(IConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            if (configuration.Values.TryGetValue("MailProvider", out string apiKey))
            {

            }

            throw new NotImplementedException();
        }

        public IMailProvider GetProvider(IConfiguration configuration, Provider provider)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            switch (provider)
            {
                case Provider.SendGrid:
                    return new SendGridProvider(configuration);

                default:
                    throw new ArgumentOutOfRangeException("Unknown provider.");
            }
        }
    }
}