using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using C__TUTORIAL.Models;

namespace C__TUTORIAL.Pages
{
    public class Registration : PageModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName{get;set;}
        public string Password { get; set; }
        public string Email{get;set;}
        public string Address{get;set;}

        public void OnGet()
        {

        }
        public void OnPostSubmit(registration person)
         {             
        this.FirstName=string.Format("{0}",person.FirstName);
        this.LastName=string.Format("{0}",person.LastName);
        this.UserName=string.Format("{0}",person.UserName);
        this.Password=string.Format("{0}",person.Password); 
        this.Email=string.Format("{0}",person.Email);
        this.Address=string.Format("{0}",person.Address);
        RedirectPreserveMethod("~/Tutorial/Login");
        if(InsertData(FirstName,LastName,UserName,Password,Email,Address)==true)
        {
                RedirectPreserveMethod("~/Tutorial/Login");
        }
        else
        {
                RedirectPreserveMethod("~/Tutorial/Registration");
        }
        }    
        private static Boolean InsertData(string fnm,string lnm,string unm,string pass,string eml,string address)
      {
        using(var context = new Connection())
        {
            // Creates the database if not exists
            context.Database.EnsureCreated();

            // Adds some books
            context.registration.Add(new registration
            {                
                id=0,   
                FirstName = fnm,
                LastName = lnm,
                UserName = unm,
                Password=pass,
                Email=eml,
                Address=address              
            }
            
            );
           
            context.SaveChanges();
        }
        return true;
     }
    }
}