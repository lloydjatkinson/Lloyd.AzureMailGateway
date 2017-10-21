using AutoFixture.Xunit2;
using Xunit;

namespace Lloyd.AzureMailGateway.Core.Tests
{
    public class JsonConverterTests
    {
        [Theory, AutoData]
        public void AddressJsonConvertorShouldDeserializeCorrectly(string emailAddress, string name)
        {
            //var address = new Address(emailAddress, name);
            //vat to = new To()
        }
    }
}