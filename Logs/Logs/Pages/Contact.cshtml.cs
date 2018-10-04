using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Logs.Pages
{
    public class ContactModel : PageModel
    {
        private readonly  ILogger<ContactModel> logger;

        public ContactModel (ILogger<ContactModel>logger)
        {
            this.logger = logger;
        }



        public string Message { get; set; }

        public void OnGet()
        {
            logger.LogDebug("esto es un mensaje debug");
            logger.LogWarning("este es un mensaje de warning");
        }
    }
}
