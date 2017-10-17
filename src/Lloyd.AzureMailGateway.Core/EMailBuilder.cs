using System;
using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    public class EMailBuilder
    {
        private EMail _mail;

        public EMailBuilder() => _mail = new EMail();

        public EMail Build()
        {
            throw new NotImplementedException();
        }

        public EMailBuilder To(string toAddress, string toDisplayName)
        {
            

            return this;
        }

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
    }
}