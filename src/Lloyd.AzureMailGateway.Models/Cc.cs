﻿using System;
using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Models
{
    /// <summary>
    /// Contains the E-Mail addresses that are to be in the E-Mail CC recipient list.
    /// </summary>
    public class Cc
    {
        /// <summary>
        /// Gets the E-Mail addresses.
        /// </summary>
        /// <value>
        /// The addresses.
        /// </value>
        public IEnumerable<Address> Addresses { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cc"/> class.
        /// </summary>
        /// <param name="addresses">The addresses.</param>
        /// <exception cref="System.ArgumentNullException">The address collection must not be null.</exception>
        public Cc(IEnumerable<Address> addresses) => Addresses = addresses ?? throw new ArgumentNullException(nameof(addresses));
    }
}