using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Inheritance : PageModel
    {
        private readonly ILogger<Inheritance> _logger;

        public Inheritance(ILogger<Inheritance> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
