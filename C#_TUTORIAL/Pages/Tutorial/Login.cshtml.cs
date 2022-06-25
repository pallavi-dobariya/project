using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using C__TUTORIAL.Models;


namespace C__TUTORIAL.Pages
{
    public class Login : PageModel
    {
        public string nm{get;set;}
        public string ps{get;set;}
        private readonly ILogger<Login> _logger;

        public Login(ILogger<Login> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPostSubmit()
         {             
        
        } 
        private static void PrintData()
        {
        
      // Gets and prints all books in database
      using (var context = new Connection())
      { 
        var regist = context.registration;
        foreach(var reg in regist)
        {
           
         var nm= reg.UserName;
         var ps= reg.Password;
        }
      }
    }
    }
}