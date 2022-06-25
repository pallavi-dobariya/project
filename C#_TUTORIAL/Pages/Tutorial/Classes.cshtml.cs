using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Classes : PageModel
    {
        private readonly ILogger<Classes> _logger;

        public Classes(ILogger<Classes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
