using System;
using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    public class ConfigurationLoader : IConfigurationLoader
    {
        public IReadOnlyDictionary<string, string> GetConfiguration()
            => new Dictionary<string, string>()
            {
                { "MailProvider", Environment.GetEnvironmentVariable("MailProvider") },
                { "SendGridApiKey", Environment.GetEnvironmentVariable("SendGridApiKey") }
            };
    }
}