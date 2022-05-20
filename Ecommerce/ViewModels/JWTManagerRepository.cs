using Ecommerce.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;


namespace Ecommerce.ViewModels
{
    public class JWTManagerRepository : IJWTRepository
    {
        Dictionary<string, string> UserRecords = new Dictionary<string, string>
        {
            { "user1","password1"},
             { "user2","password2"}

        };

        private readonly IConfiguration configuartion;

        public JWTManagerRepository(IConfiguration iconfiguration)
        {
            configuartion = iconfiguration;
        }


        public Tokan Authenticate(User users)
        {
            if (!UserRecords.Any(x => x.Key == users.Name && x.Value == users.Password))
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(configuartion["JWT:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name,users.Name)
                }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new Tokan { Token = tokenHandler.WriteToken(token) };
        }

        public Tokan authenticate(User user)
        {
            throw new NotImplementedException();
        }
    }
}

