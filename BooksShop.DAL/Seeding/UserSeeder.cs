using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Seeding
{
    public class UserSeeder : ISeeder<User>
    {
        private static readonly List<User> users = new List<User>()
        {
            new User
            {
                Id = "3b333929-f974-444e-a8d3-68f50a0459c0",
                UserName = "User1",
                FirstName = "Esmaralda",
                LastName = "Voigt",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password1")

            }, new User
            {
                Id = "61dfb9e3-1c27-424a-9963-9586ca110220",
                UserName = "User2",
                FirstName = "Ostap",
                LastName = "Bleier",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password2")
            }, new User
            {
                Id = "a36b02e1-81a9-47f4-89b6-d33c4f40ed5f",
                    UserName = "User3",
                    FirstName = "Sophia",
                    LastName = "Beringer",
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password3"),
            }
        };

        public void Seed(EntityTypeBuilder<User> builder) => builder.HasData(users);

    }
}
