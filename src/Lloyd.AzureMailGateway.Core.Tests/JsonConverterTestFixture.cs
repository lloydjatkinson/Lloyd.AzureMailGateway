using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Lloyd.AzureMailGateway.Core.Tests
{
    public class JsonConverterTestFixture : IDisposable
    {
        public IEnumerable<JsonConverter> JsonConverters { get; }

        public JsonConverterTestFixture()
        {

        }

        public void Dispose()
        {

        }
    }
}
