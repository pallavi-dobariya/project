using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Generic : PageModel
    {
        private readonly ILogger<Generic> _logger;

        public Generic(ILogger<Generic> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
