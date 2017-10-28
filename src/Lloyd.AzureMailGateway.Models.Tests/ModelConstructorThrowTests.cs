using System;
using Shouldly;

namespace Lloyd.AzureMailGateway.Models.Tests
{
    public class ModelConstructorThrowTests
    {
        public void AddressConstructorShouldThrowOnNullArguments() => Should.Throw<NullReferenceException>(() => new Address(null, null));

        public void ToConstructorShouldThrowOnNullArguments() => Should.Throw<NullReferenceException>(() => new To(null));

        public void FromConstructorShouldThrowOnNullArguments() => Should.Throw<NullReferenceException>(() => new From(null));

        public void BccConstructorShouldThrowOnNullArguments() => Should.Throw<NullReferenceException>(() => new Bcc(null));

        public void CcConstructorShouldThrowOnNullArguments() => Should.Throw<NullReferenceException>(() => new Cc(null));
    }
}