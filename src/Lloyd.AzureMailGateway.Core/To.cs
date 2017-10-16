using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    public class To
    {
        public IEnumerable<Address> Addresses { get; }

        public To(IEnumerable<Address> addresses)
        {
        }
    }
}