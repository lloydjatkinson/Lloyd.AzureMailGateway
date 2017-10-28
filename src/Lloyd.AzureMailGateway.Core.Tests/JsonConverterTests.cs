using System.Collections.Generic;
using System.Linq;
using AutoFixture.Xunit2;
using Lloyd.AzureMailGateway.Core.JsonConverters;
using Lloyd.AzureMailGateway.Models;
using Newtonsoft.Json;
using Shouldly;
using Xunit;

namespace Lloyd.AzureMailGateway.Core.Tests
{
    public class JsonConverterTests
    {
        [Theory, AutoData]
        public void AddressJsonConvertorShouldDeserializeCorrectly(IEnumerable<Address> addresses, AddressConverter converter)
        {
            // Arrange

            var serializedAddresses = new List<string>();
            var deserializedAddresses = new List<Address>();
            var settings = SerializationSettings.GetJsonSettings();
            settings.Converters.Add(converter);

            // Act

            foreach (var address in addresses)
            {
                serializedAddresses.Add(JsonConvert.SerializeObject(address, settings));
            }

            foreach (var address in serializedAddresses)
            {
                deserializedAddresses.Add(JsonConvert.DeserializeObject<Address>(address, settings));
            }

            // Assert

            foreach (var address in deserializedAddresses)
            {
                addresses
                    .FirstOrDefault(a => a.EMail == address.EMail && a.Name == address.Name)
                    .ShouldNotBeNull("Address converter serialization/deserialization failed.");
            }
        }
    }
}