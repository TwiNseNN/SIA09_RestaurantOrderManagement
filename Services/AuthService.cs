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
        private IHttpContextAccessor _httpContextAccessor;
        private string _secret = "Hrt6ynjliHMc0v3z7wHxUPv0GmBmUjXmHjMjBfcRL1UOG3st02DRIzMisbRw";

        public AuthService(Data.RestaurantManagementOrderContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Generates a JWT token using the given payload.
        /// </summary>
        private string GenerateJwt(UserType userType, string email)
        {
            var payload = new Dictionary<string, object>
            {
                { "type", Enum.GetName(typeof(UserType), userType) },
                { "email", email }
            };

            IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); // symmetric
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

            var token = encoder.Encode(payload, _secret);
            System.Diagnostics.Debug.WriteLine($"Generated jwt: {token}");
            return token;
        }

        public bool PasswordVerify(string hashed, string raw)
        {
            return BCrypt.Net.BCrypt.Verify(raw, hashed);
        }

        public string PasswordHash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        /// <summary>
        /// Generates a session, and returns the JWT token.
        /// </summary>
        public string GenerateSession(Models.Auth.Login loginModel) {
            var user = ValidateCredentials(loginModel);
            return GenerateJwt(user.Type, user.Email);
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

        public IActionResult? RejectIfNotRole(Controller controller, string role)
        {
            var redirect = controller.Redirect("/Auth/Login");
            var token = _httpContextAccessor.HttpContext.Request.Cookies["token"];
            if (token == null)
            {
                return redirect;
            }

            IDictionary<string, object> claims = null;
            try
            {
                claims = JwtBuilder.Create()
                                    .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
                                    .WithSecret(_secret)
                                    .MustVerifySignature()
                                    .Decode<IDictionary<string, object>>(token);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                return redirect;
            }

            if (role != (string)claims["type"])
            {
                return redirect;
            }
            return null;
        }
    }
}
