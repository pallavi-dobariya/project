using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Anonymous : PageModel
    {
        private readonly ILogger<Anonymous> _logger;

        public Anonymous(ILogger<Anonymous> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
