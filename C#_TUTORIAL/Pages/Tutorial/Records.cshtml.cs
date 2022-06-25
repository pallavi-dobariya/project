using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Records : PageModel
    {
        private readonly ILogger<Records> _logger;

        public Records(ILogger<Records> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
