using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Namespaces : PageModel
    {
        private readonly ILogger<Namespaces> _logger;

        public Namespaces(ILogger<Namespaces> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
