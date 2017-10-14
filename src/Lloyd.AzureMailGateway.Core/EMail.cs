using System;

namespace Lloyd.AzureMailGateway.Core
{
    public class EMail
    {
        public To To { get; }

        public From From { get; }

        public EMail(To to, From from)
        {
            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            if (from == null)
            {
                throw new ArgumentNullException(nameof(from));
            }
        }
    }
}