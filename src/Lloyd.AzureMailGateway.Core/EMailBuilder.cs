using System;
using System.Collections.Generic;
using System.Text;

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

        public EMailBuilder To(To to)
        {
            _mail.To = to ?? throw new ArgumentNullException(nameof(to));

            return this;
        }

        public EMailBuilder From(From from)
        {
            _mail.From = from ?? throw new ArgumentNullException(nameof(from));

            return this;
        }
    }
}
