using System;
using System.Collections.Generic;
using Lloyd.AzureMailGateway.Core.Parts;

namespace Lloyd.AzureMailGateway.Core
{
    public class To : Part
    {
        public To(IEnumerable<Address> addresses) : base(addresses)
        {
        }
    }
}