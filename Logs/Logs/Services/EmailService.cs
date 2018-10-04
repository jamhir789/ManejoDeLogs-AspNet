using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logs.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> logger;

        public EmailService(ILogger<EmailService> logger)
        {
            this.logger = logger;
        }
        public void EnviarCorreo()
        {
            logger.LogWarning("enviando correo");
        }
    }

    public interface IEmailService
    {
        void EnviarCorreo();
    }
}
