using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApiCoreTest.Data;
using WebApiCoreTest.Model;

namespace WebApiCoreTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private ApplicationDBContext context;
        private UserManager<ApplicationUser> userManager;
        public AccountController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return context.Users.Select(u => u.UserName).ToArray();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                };

                var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecureKey"));

                var token = new JwtSecurityToken(
                    issuer: "http://faisal.com",
                    audience: "http://faisal.com",
                    expires: DateTime.Now.AddHours(1),
                    claims: claims,
                    signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(signingKey,SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo

                });
            }
            return Unauthorized();
        }


    }
}