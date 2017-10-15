using System;
using System.Collections.Generic;
using System.Text;

namespace Lloyd.AzureMailGateway.Core.Parts
{
    public abstract class Part
    {
        public IEnumerable<Address> Addresses { get; }

        public Part(IEnumerable<Address> addresses) => Addresses = addresses ?? throw new ArgumentNullException(nameof(addresses));
    }
}