using System;
using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Models
{
    /// <summary>
    /// Builds the E-Mails.
    /// </summary>
    public class EMailBuilder
    {
        private EMail _mail;

        private string _subject = string.Empty;
        private Address _from;
        private List<Address> _to = new List<Address>();
        private List<Address> _bcc = new List<Address>();
        private List<Address> _cc = new List<Address>();

        private bool _fromSet;
        private bool _toSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="EMailBuilder"/> class.
        /// </summary>
        public EMailBuilder()
        {
            _mail = new EMail();
        }

        /// <summary>
        /// Sets the subject.
        /// </summary>
        /// <param name="subject">The subject.</param>
        /// <returns></returns>
        public EMailBuilder Subject(string subject)
        {
            _subject = subject;

            return this;
        }

        /// <summary>
        /// Sets the sender address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns></returns>
        public EMailBuilder From(string address)
        {
            _from = new Address(address, string.Empty);

            _fromSet = true;
            return this;
        }

        /// <summary>
        /// Sets the sender address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="displayName">The display name.</param>
        /// <returns></returns>
        public EMailBuilder From(string address, string displayName)
        {
            _from = new Address(address, displayName);

            _fromSet = true;
            return this;
        }

        /// <summary>
        /// Sets the recipient address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="displayName">The display name.</param>
        /// <returns></returns>
        public EMailBuilder To(string address, string displayName)
            => To(new List<Address>()
            {
                new Address(address, displayName)
            });

        /// <summary>
        /// Sets the recipient addresses.
        /// </summary>
        /// <param name="addresses">The addresses.</param>
        /// <returns></returns>
        public EMailBuilder To(IEnumerable<Address> addresses)
        {
            _to.AddRange(addresses);

            _toSet = true;
            return this;
        }

        /// <summary>
        /// Sets the CC addresses.
        /// </summary>
        /// <param name="addresses">The addresses.</param>
        /// <returns></returns>
        public EMailBuilder Cc(string address, string displayName)
            => Cc(new List<Address>()
            {
                new Address(address, displayName)
            });

        /// <summary>
        /// Sets the CC addresses.
        /// </summary>
        /// <param name="addresses">The addresses.</param>
        /// <returns></returns>
        public EMailBuilder Cc(IEnumerable<Address> addresses)
        {
            _cc.AddRange(addresses);

            return this;
        }

        /// <summary>
        /// Sets the BCC addresses.
        /// </summary>
        /// <param name="addresses">The addresses.</param>
        /// <returns></returns>
        public EMailBuilder Bcc(string address, string displayName)
            => Bcc(new List<Address>()
            {
                new Address(address, displayName)
            });

        /// <summary>
        /// Sets the BCC addresses.
        /// </summary>
        /// <param name="addresses">The addresses.</param>
        /// <returns></returns>
        public EMailBuilder Bcc(IEnumerable<Address> addresses)
        {
            _bcc.AddRange(addresses);

            return this;
        }

        /// <summary>
        /// Builds the E-Mail instance. The builder must be used correctly for the instance to be built correctly.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">The E-Mail object state is not valid. Ensure the usage of the builder is correct.</exception>
        public EMail Build()
        {
            if (!IsValidState())
            {
                throw new InvalidOperationException("The E-Mail object state is not valid. Ensure the usage of the builder is correct.");
            }

            return new EMail()
            {
                Subject = new Subject(_subject),
                From = new From(_from),
                To = new To(_to),
                Bcc = new Bcc(_bcc),
                Cc = new Cc(_cc),
            };
        }

        private bool IsValidState() => _fromSet && _toSet;
    }
}