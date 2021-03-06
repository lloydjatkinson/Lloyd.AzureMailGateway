﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Lloyd.AzureMailGateway.Core;
using Lloyd.AzureMailGateway.Models;
using SendGrid;

namespace Lloyd.AzureMailGateway.Providers
{
    public class SendGridProvider : IMailProvider
    {
        private SendGridClient _client;
        private IConfigurationLoader _configuration;
        private IMapper _mapper;

        public SendGridProvider(IConfigurationLoader configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _configuration.GetConfiguration();

            if (configuration.GetConfiguration().TryGetValue("SendGridApiKey", out string apiKey))
            {
                _client = new SendGridClient(apiKey);
            }
        }

        public async Task SendAsync(EMail email)
        {
            throw new NotImplementedException();
        }

        public async Task SendAsync(IEnumerable<EMail> emails)
        {
            throw new NotImplementedException();
        }
    }
}