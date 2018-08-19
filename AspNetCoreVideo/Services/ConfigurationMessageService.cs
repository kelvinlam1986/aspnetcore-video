using Microsoft.Extensions.Configuration;
using System;

namespace AspNetCoreVideo.Services
{
    public class ConfigurationMessageService : IMessageService
    {
        private IConfiguration _configuration;

        public ConfigurationMessageService(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public string GetMessage()
        {
            return _configuration["Message"];
        }
    }
}
