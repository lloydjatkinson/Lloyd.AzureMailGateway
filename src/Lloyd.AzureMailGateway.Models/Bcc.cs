using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    public class Bcc
    {
        public IEnumerable<Address> Addresses { get; internal set; }

        //public Bcc(IEnumerable<Address> addresses) => Addresses = addresses ?? throw new ArgumentNullException(nameof(addresses));
    }
}