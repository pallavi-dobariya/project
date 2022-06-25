using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Pattern_Matching : PageModel
    {
        private readonly ILogger<Pattern_Matching> _logger;

        public Pattern_Matching(ILogger<Pattern_Matching> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
