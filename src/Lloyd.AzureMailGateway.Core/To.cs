﻿using System;
using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    public class To
    {
        public IEnumerable<Address> Addresses { get; internal set; } = new List<Address>();

        public To(IEnumerable<Address> addresses) => Addresses = addresses ?? throw new ArgumentNullException(nameof(addresses));
    }
}