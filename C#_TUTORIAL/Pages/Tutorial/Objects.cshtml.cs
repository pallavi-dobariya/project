using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Objects : PageModel
    {
        private readonly ILogger<Objects> _logger;

        public Objects(ILogger<Objects> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
