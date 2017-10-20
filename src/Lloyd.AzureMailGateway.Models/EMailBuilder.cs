using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    public class EMailBuilder
    {
        private EMail _mail;

        public EMailBuilder()
        {
            _mail = new EMail();
            _mail.To = new To() { Addresses = new List<Address>() };
            _mail.From = new From() { Address = new Address() };
            _mail.Cc = new Cc() { Addresses = new List<Address>() };
            _mail.Bcc = new Bcc() { Addresses = new List<Address>() };
        }

        public EMail Build() => _mail;

        public EMailBuilder To(string toAddress, string toDisplayName)
            => To(new List<Address>()
            {
                new Address(toAddress, toDisplayName)
            });

        public EMailBuilder To(IEnumerable<Address> addresses)
        {
            _mail.To = new To(addresses);

            return this;
        }

        public EMailBuilder From(string fromAddress, string fromDisplayName)
        {
            _mail.From = new From(new Address(fromAddress, fromDisplayName));

            return this;
        }

        public EMailBuilder Cc(IEnumerable<Address> addresses)
        {
            _mail.
        }
    }
}