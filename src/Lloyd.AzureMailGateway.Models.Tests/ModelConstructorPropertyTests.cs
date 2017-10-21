using System.Collections.Generic;
using System.Linq;
using AutoFixture.Xunit2;
using Lloyd.AzureMailGateway.Core;
using Shouldly;
using Xunit;

namespace Lloyd.AzureMailGateway.Models.Tests
{
    public class ModelConstructorPropertyTests
    {
        [Theory, AutoData]
        public void AddressConstructorShouldSetProperties(string emailAddress, string name)
        {
            var address = new Address(emailAddress, name);
            address.EMail.ShouldBe(emailAddress);
            address.Name.ShouldBe(name);
        }

        [Theory, AutoData]
        public void ToConstructorShouldSetProperties(string emailAddress, string name)
        {
            var to = new To(new List<Address>() { new Address(emailAddress, name) });
            to.Addresses.FirstOrDefault().EMail.ShouldBe(emailAddress);
            to.Addresses.FirstOrDefault().Name.ShouldBe(name);
        }

        [Theory, AutoData]
        public void FromConstructorShouldSetProperties(string emailAddress, string name)
        {
            var from = new From(new Address(emailAddress, name));
            from.Address.EMail.ShouldBe(emailAddress);
            from.Address.Name.ShouldBe(name);
        }

        [Theory, AutoData]
        public void CcConstructorShouldSetProperties(string emailAddress, string name)
        {
            var cc = new Cc(new List<Address>() { new Address(emailAddress, name) });
            cc.Addresses.FirstOrDefault().EMail.ShouldBe(emailAddress);
            cc.Addresses.FirstOrDefault().Name.ShouldBe(name);
        }

        [Theory, AutoData]
        public void BccConstructorShouldSetProperties(string emailAddress, string name)
        {
            var bcc = new Bcc(new List<Address>() { new Address(emailAddress, name) });
            bcc.Addresses.FirstOrDefault().EMail.ShouldBe(emailAddress);
            bcc.Addresses.FirstOrDefault().Name.ShouldBe(name);
        }
    }
}