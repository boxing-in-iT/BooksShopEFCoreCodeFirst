using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Entities
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Year { get; set; }
    }
}
