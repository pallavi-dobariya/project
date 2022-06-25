using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Interfaces : PageModel
    {
        private readonly ILogger<Interfaces> _logger;

        public Interfaces(ILogger<Interfaces> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
