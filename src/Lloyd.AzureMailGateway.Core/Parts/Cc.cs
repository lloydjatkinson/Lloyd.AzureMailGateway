using System;
using System.Collections.Generic;
using Lloyd.AzureMailGateway.Core.Parts;

namespace Lloyd.AzureMailGateway.Core
{
    public class Cc : Part
    {
        public Cc(IEnumerable<Address> addresses) : base(addresses)
        {
        }
    }
}