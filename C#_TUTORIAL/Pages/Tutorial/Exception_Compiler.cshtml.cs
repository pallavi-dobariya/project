using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class  Exception_Compiler: PageModel
    {
        private readonly ILogger<Exception_Compiler> _logger;

        public Exception_Compiler(ILogger<Exception_Compiler> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}