using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    public class Bcc
    {
        public IEnumerable<Address> Addresses { get; }

        public Bcc(IEnumerable<Address> addresses)
        {
        }
    }
}