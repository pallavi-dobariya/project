using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace C__TUTORIAL.Pages
{
    public class Class_Struct_Record : PageModel
    {
        private readonly ILogger<Class_Struct_Record> _logger;

        public Class_Struct_Record(ILogger<Class_Struct_Record> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
