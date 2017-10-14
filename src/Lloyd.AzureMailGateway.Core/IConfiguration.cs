using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    /// <summary>
    /// Provides configurations for the mail provider(s).
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Contains the keys value pairs used by providers.
        /// </summary>
        IReadOnlyDictionary<string, string> Values { get; set; }
    }
}