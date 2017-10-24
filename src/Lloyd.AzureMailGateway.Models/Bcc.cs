using System;
using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class Bcc
    {
        /// <summary>
        /// Gets the addresses.
        /// </summary>
        /// <value>
        /// The addresses.
        /// </value>
        public IEnumerable<Address> Addresses { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bcc"/> class.
        /// </summary>
        /// <param name="addresses">The addresses.</param>
        /// <exception cref="ArgumentNullException">addresses</exception>
        public Bcc(IEnumerable<Address> addresses) => Addresses = addresses ?? throw new ArgumentNullException(nameof(addresses));
    }
}