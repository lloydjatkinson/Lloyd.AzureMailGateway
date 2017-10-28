using System;
using System.Diagnostics;

namespace Lloyd.AzureMailGateway.Models
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
        /// <param name="email">The E-Mail address string.</param>
        /// <param name="name">The display name of the recipient.</param>
        /// <exception cref="System.ArgumentNullException">E-Mail address must not be null.</exception>
        /// <exception cref="System.ArgumentException">E-Mail address must not be white-space.</exception>
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