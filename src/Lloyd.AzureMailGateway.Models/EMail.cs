﻿namespace Lloyd.AzureMailGateway.Models
{
    public class EMail
    {
        public Subject Subject { get; internal set; }

        public To To { get; internal set; }

        public From From { get; internal set; }

        public Cc Cc { get; internal set; }

        public Bcc Bcc { get; internal set; }

        //public EMail()
        //{
        //}

        //public EMail(To to, From from)
        //{
        //    if (to == null)
        //    {
        //        throw new ArgumentNullException(nameof(to));
        //    }

        //    if (from == null)
        //    {
        //        throw new ArgumentNullException(nameof(from));
        //    }
        //}
    }
}