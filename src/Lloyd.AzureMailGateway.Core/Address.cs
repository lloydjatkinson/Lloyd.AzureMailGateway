using System;

namespace Lloyd.AzureMailGateway.Core
{
    /// <summary>
    /// Contains the E-Mail address and an optional display name.
    /// </summary>
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
        /// <param name="email"></param>
        /// <param name="name"></param>
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
        }
    }
}