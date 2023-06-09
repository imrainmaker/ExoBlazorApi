using Blazor.API.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Blazor.API.Services
{
    public class JwtService
    {
        private readonly IConfiguration _configuration;

        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(User user)
        {
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt:key"]));

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);



            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
            };

            SecurityTokenDescriptor newToken = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Issuer = _configuration["jwt:issuer"],
                Audience = _configuration["jwt:audience"],
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials
            };

            var handler = new JwtSecurityTokenHandler();
            var jwtUser = handler.CreateToken(newToken);
            string tokenAvance = handler.WriteToken(jwtUser);

            return tokenAvance;

        }
    }
}
