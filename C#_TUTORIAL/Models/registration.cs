using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using C__TUTORIAL.Models;
namespace C__TUTORIAL.Models
{

    public class registration
    {
        public int id{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string UserName{get;set;}
        public string Password { get; set; }
        public string Email{get;set;}
        public string Address{get;set;}


    }
}