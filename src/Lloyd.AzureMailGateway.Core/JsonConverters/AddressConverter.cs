using System;
using Lloyd.AzureMailGateway.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lloyd.AzureMailGateway.Core.JsonConverters
{
    public class AddressConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => (objectType == typeof(Address));

        public override bool CanWrite
        {
            get { return false; }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jobject = JObject.Load(reader);

            var email = (string)jobject["eMail"];
            var name = (string)jobject["name"];

            return new Address(email, name);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            => throw new InvalidOperationException("AddressConverter is for read only usage.");
    }
}