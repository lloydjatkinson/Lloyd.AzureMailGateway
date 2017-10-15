using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    /// <summary>
    /// Provides configuration for the mail provider(s).
    /// </summary>
    public interface IConfigurationLoader
    {
        /// <summary>
        /// Contains the keys value pairs used by providers.
        /// </summary>
        IReadOnlyDictionary<string, string> GetConfiguration();
    }
}