using System;

namespace Lloyd.AzureMailGateway.Models
{
    public class From
    {
        public Address Address { get; }

        public From(Address address) => Address = address ?? throw new ArgumentNullException(nameof(address));
    }
}