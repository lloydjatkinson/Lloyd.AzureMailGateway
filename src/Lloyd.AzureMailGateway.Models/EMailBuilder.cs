using System.Collections.Generic;

namespace Lloyd.AzureMailGateway.Core
{
    public class EMailBuilder
    {
        private EMail _mail;

        private Address _from;
        private List<Address> _to = new List<Address>();
        private List<Address> _bcc = new List<Address>();
        private List<Address> _cc = new List<Address>();

        public EMailBuilder()
        {
            _mail = new EMail();
        }

        public EMail Build()
        {
            return new EMail()
            {
                From = new From(_from),
                To = new To(_to),
                Bcc = new Bcc(_bcc),
                Cc = new Cc(_cc),
            };
        }

        private EMailBuilder From(string address)
        {
            _from = new Address(address, string.Empty);

            return this;
        }

        private EMailBuilder From(string address, string displayName)
        {
            _from = new Address(address, displayName);

            return this;
        }

        public EMailBuilder To(string address, string displayName)
            => To(new List<Address>()
            {
                new Address(address, displayName)
            });

        public EMailBuilder To(IEnumerable<Address> addresses)
        {
            _to.AddRange(addresses);

            return this;
        }

        public EMailBuilder Cc(IEnumerable<Address> addresses)
        {
            _cc.AddRange(addresses);

            return this;
        }

        public EMailBuilder Bcc(IEnumerable<Address> addresses)
        {
            _bcc.AddRange(addresses);

            return this;
        }
    }
}