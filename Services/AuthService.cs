using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Serializers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Services
{
    public class EmailPasswordIncorrect : Exception {}

    public class AuthService
    {
        protected Data.RestaurantManagementOrderContext _context;

        public AuthService(Data.RestaurantManagementOrderContext context)
        {
            _context = context;
        }

        public bool PasswordVerify(string hashed, string raw)
        {
            return BCrypt.Net.BCrypt.Verify(raw, hashed);
        }

        public string PasswordHash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public Models.IUser ValidateCredentials(Models.Auth.Login loginModel)
        {
            // search in all users
            var users = new List<Models.IUser>();
            users.AddRange(_context.Admin.ToList<Models.IUser>());
            users.AddRange(_context.Cook.ToList<Models.IUser>());
            users.AddRange(_context.Waiter.ToList<Models.IUser>());

            var user = users.Find(a => a.Email == loginModel.Email);
            if (user != null)
            {
                if (!PasswordVerify(user.Password, loginModel.Password))
                {
                    throw new EmailPasswordIncorrect();
                }
                return user;
            }
            throw new EmailPasswordIncorrect();
        }
    }
}
