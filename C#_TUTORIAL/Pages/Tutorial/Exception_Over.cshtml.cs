using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class  Exception_Over: PageModel
    {
        private readonly ILogger<Exception_Over> _logger;

        public Exception_Over(ILogger<Exception_Over> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
