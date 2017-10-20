﻿using System;
using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    public class Cc
    {
        public IEnumerable<Address> Addresses { get; }

        public Cc(IEnumerable<Address> addresses) => Addresses = addresses ?? throw new ArgumentNullException(nameof(addresses));
    }
}