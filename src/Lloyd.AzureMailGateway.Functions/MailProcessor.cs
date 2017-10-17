using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Lloyd.AzureMailGateway.Core;
using Lloyd.AzureMailGateway.Factories;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace Lloyd.AzureMailGateway.Functions
{
    public static class MailProcessor
    {
        [FunctionName("MailProcessor")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            IMailProviderFactory factory = new MailProviderFactory();
            IConfigurationLoader configuration = new ConfigurationLoader();
            var config = configuration.GetConfiguration();

            if (!config.ContainsKey("MailProvider"))
            {
                return req.CreateErrorResponse(HttpStatusCode.InternalServerError, "Mail Provider not configured.");
            }

            log.Info($"Using \"{configuration.GetConfiguration()["MailProvider"]}\" provider.");
            var provider = factory.GetProvider(configuration);

            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}