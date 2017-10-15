using System.Collections.Generic;
using Lloyd.AzureMailGateway.Core.Parts;

namespace Lloyd.AzureMailGateway.Core
{
    public class Bcc : Part
    {
        public Bcc(IEnumerable<Address> addresses) : base(addresses)
        {
        }
    }
}