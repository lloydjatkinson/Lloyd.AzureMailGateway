using System;
using Lloyd.AzureMailGateway.Core;
using Lloyd.AzureMailGateway.Providers;

namespace Lloyd.AzureMailGateway.Factories
{
    /// <summary>
    ///
    /// </summary>
    public class MailProviderFactory : IMailProviderFactory
    {
        /// <summary>
        /// Creates the instance of a MailProvider using the given configuration.
        /// </summary>
        /// <param name="configurationLoader">The configuration to be supplied to the MailProvider. The configuration key value pairs are specific to providers.</param>
        /// <returns>The instantiated MailProvider.</returns>
        public IMailProvider GetProvider(IConfigurationLoader configurationLoader)
        {
            if (configurationLoader == null)
            {
                throw new ArgumentNullException(nameof(configurationLoader));
            }

            IMailProvider mailProvider = null;

            var config = configurationLoader.GetConfiguration();
            if (config.TryGetValue("MailProvider", out string provider))
            {
                if (!string.IsNullOrWhiteSpace(provider))
                {
                    switch (provider)
                    {
                        case nameof(Provider.SendGrid):
                            mailProvider = new SendGridProvider(configurationLoader);
                            break;

                        default:
                            throw new ArgumentException("Unknown provider.");
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("Configuration is missing MailProvider.");
            }

            return mailProvider;
        }

        /// <summary>
        /// Creates the instance of a MailProvider using the given configuration and provider type.
        /// </summary>
        /// <param name="configurationLoader">The configuration to be supplied to the MailProvider. The configuration key value pairs are specific to providers.</param>
        /// <param name="provider">The type of MailProvider to instantiate.</param>
        /// <returns>The instantiated MailProvider.</returns>
        public IMailProvider GetProvider(IConfigurationLoader configurationLoader, Provider provider)
        {
            if (configurationLoader == null)
            {
                throw new ArgumentNullException(nameof(configurationLoader));
            }

            switch (provider)
            {
                case Provider.SendGrid:
                    return new SendGridProvider(configurationLoader);

                default:
                    throw new ArgumentOutOfRangeException("Unknown provider.");
            }
        }
    }
}