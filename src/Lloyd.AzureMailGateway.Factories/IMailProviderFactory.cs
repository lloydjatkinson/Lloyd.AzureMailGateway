using AutoMapper;
using Lloyd.AzureMailGateway.Core;
using Lloyd.AzureMailGateway.Providers;

namespace Lloyd.AzureMailGateway.Factories
{
    /// <summary>
    /// Creates instances of MailProvider.
    /// </summary>
    public interface IMailProviderFactory
    {
        /// <summary>
        /// Creates the instance of a MailProvider using the given configuration.
        /// </summary>
        /// <param name="configurationLoader">The configuration to be supplied to the MailProvider. The configuration key value pairs are specific to providers.</param>
        /// <param name="mapper">The object mapper, used for mapping between E-Mail domain models and models used by third-party provider libraries.</param>
        /// <returns>
        /// The instantiated MailProvider.
        /// </returns>
        IMailProvider GetProvider(IConfigurationLoader configurationLoader, IMapper mapper);

        /// <summary>
        /// Creates the instance of a MailProvider using the given configuration and provider type.
        /// </summary>
        /// <param name="configurationLoader">The configuration to be supplied to the MailProvider. The configuration key value pairs are specific to providers.</param>
        /// <param name="mapper">The object mapper, used for mapping between E-Mail domain models and models used by third-party provider libraries.</param>
        /// <param name="provider">The type of MailProvider to instantiate.</param>
        /// <returns>
        /// The instantiated MailProvider.
        /// </returns>
        IMailProvider GetProvider(IConfigurationLoader configurationLoader, IMapper mapper, Provider provider);
    }
}