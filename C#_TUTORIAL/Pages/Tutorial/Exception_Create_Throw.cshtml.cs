using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class  Exception_Create_Throw: PageModel
    {
        private readonly ILogger<Exception_Create_Throw> _logger;

        public Exception_Create_Throw(ILogger<Exception_Create_Throw> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
