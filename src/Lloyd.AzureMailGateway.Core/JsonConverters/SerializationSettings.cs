using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Lloyd.AzureMailGateway.Core.JsonConverters
{
    public static class SerializationSettings
    {
        public static JsonSerializerSettings GetJsonSettings()
        {
            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Newtonsoft.Json.Formatting.Indented,
            };

            return settings;
        }
    }
}