using System.Collections.Generic;
using System.Threading.Tasks;
using Lloyd.AzureMailGateway.Core;

namespace Lloyd.AzureMailGateway.Providers
{
    public interface IMailProvider
    {
        // TODO: Make Result return.
        Task SendAsync(EMail email);

        Task SendAsync(IEnumerable<EMail> emails);
    }
}