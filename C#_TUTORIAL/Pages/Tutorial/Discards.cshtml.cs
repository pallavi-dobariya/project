using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class  Discards: PageModel
    {
        private readonly ILogger<Discards> _logger;

        public Discards(ILogger<Discards> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
