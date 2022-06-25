
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class  Exception_Use: PageModel
    {
        private readonly ILogger<Exception_Use> _logger;

        public Exception_Use(ILogger<Exception_Use> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
