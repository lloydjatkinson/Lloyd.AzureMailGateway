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
        public void ToConstructorShouldSetProperty(string emailAddress, string name)
        {
            var to = new To(new List<Address>() { new Address(emailAddress, name) });
            to.Addresses.FirstOrDefault().EMail.ShouldBe(emailAddress);
            to.Addresses.FirstOrDefault().Name.ShouldBe(name);
        }

        [Theory, AutoData]
        public void FromConstructorShouldSetProperty(string emailAddress, string name)
        {
            var from = new From(new Address(emailAddress, name));
            from.Address.EMail.ShouldBe(emailAddress);
            from.Address.Name.ShouldBe(name);
        }

        [Theory, AutoData]
        public void CcConstructorShouldSetProperty(string emailAddress, string name)
        {
            var cc = new Cc(new List<Address>() { new Address(emailAddress, name) });
            cc.Addresses.FirstOrDefault().EMail.ShouldBe(emailAddress);
            cc.Addresses.FirstOrDefault().Name.ShouldBe(name);
        }

        [Theory, AutoData]
        public void BccConstructorShouldSetProperty(string emailAddress, string name)
        {
            var bcc = new Bcc(new List<Address>() { new Address(emailAddress, name) });
            bcc.Addresses.FirstOrDefault().EMail.ShouldBe(emailAddress);
            bcc.Addresses.FirstOrDefault().Name.ShouldBe(name);
        }
    }
}