using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Top_Level_Stat : PageModel
    {
        private readonly ILogger<Top_Level_Stat> _logger;

        public Top_Level_Stat(ILogger<Top_Level_Stat> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
