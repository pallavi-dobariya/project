using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Deconstruct: PageModel
    {
        private readonly ILogger<Deconstruct> _logger;

        public Deconstruct(ILogger<Deconstruct> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
