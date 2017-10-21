using System;
using System.Diagnostics;

namespace Lloyd.AzureMailGateway.Core
{
    /// <summary>
    /// Contains the E-Mail address and an optional display name.
    /// </summary>
    [DebuggerDisplay("E-Mail = {EMail}, Name = {Name}")]
    public class Address
    {
        /// <summary>
        /// The E-Mail address.
        /// </summary>
        public string EMail { get; }

        /// <summary>
        /// The display name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="email">The E-Mail address.</param>
        /// <param name="name">The optional display name.</param>
        /// <exception cref="ArgumentNullException">email</exception>
        /// <exception cref="ArgumentException">email</exception>
        public Address(string email, string name)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException(nameof(email));
            }

            EMail = email;
            Name = name;
        }
    }
}