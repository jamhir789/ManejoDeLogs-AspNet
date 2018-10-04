using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logs.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Logs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly IEmailService emailService;
        private readonly Serilog.ILogger seriLogger;

        public IndexModel(ILogger<IndexModel>logger, IEmailService emailService
            , Serilog.ILogger seriLogger)


        {
            this.logger = logger;
            this.emailService = emailService;
            this.seriLogger = seriLogger;
             }
        public void OnGet()
        {
            logger.LogDebug("esto es un mensaje debug");
            logger.LogWarning("este es un mensaje de warning");
            logger.LogError("Este es mensaje de error");
            seriLogger.Error("Este es mensaje de error");
            emailService.EnviarCorreo();
        }
    }
}
