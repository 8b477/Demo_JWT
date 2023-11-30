using DemoSecurity_DAL.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace TFCyberSecu_DemoSecurity_API.Tools
{
    public class JwtGenerator
    {
        private IConfiguration _config;

        public JwtGenerator(IConfiguration config)
        {
            _config = config;
        }
        public string Generate(User user)
        {
            if(user is null)
            {
                throw new ArgumentNullException("user");
            }

            //Génération de la clé de signature du token
            string key = _config.GetSection("tokenInfo").GetSection("secretKey").Value;
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            SigningCredentials signingKey = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

            //Création du payload (information contenue dans le token)
            Claim[] myClaims = new[]
            {
                new Claim(ClaimTypes.Sid, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.IsAdmin ? "Admin" : "User"),
                new Claim("Nickname", user.Nickname)
            };

            JwtSecurityToken jwt = new JwtSecurityToken(
                    claims : myClaims,
                    signingCredentials : signingKey,
                    expires : DateTime.Now.AddDays(1),
                    issuer : "monAdresseAPI.com", //Emetteur du token
                    audience : "adresseDuSiteClient.com" //Consomateur du token
                );

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(jwt);
        }
    }
}
