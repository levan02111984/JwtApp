using JwtApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JwtApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("Public")]
        public IActionResult Public()
        {
            return Ok("Hi, you are in public method");
        }

        [HttpGet("Admin")]
        [Authorize]
        public IActionResult AdminArea()
        {
            var validUser = GetValidUser();
            return Ok($"Hello {validUser.UserName } , You are a {validUser.Role }");

        }

        private UserModel GetValidUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaim = identity.Claims;

                return new UserModel
                {
                    UserName = userClaim.FirstOrDefault(p => p.Type == ClaimTypes.NameIdentifier)?.Value,
                    EmailAddress = userClaim.FirstOrDefault(p => p.Type == ClaimTypes.Email)?.Value,
                    Role = userClaim.FirstOrDefault(p => p.Type == ClaimTypes.Role)?.Value,
                    Surname = userClaim.FirstOrDefault(p => p.Type == ClaimTypes.Surname)?.Value,
                    GivenName = userClaim.FirstOrDefault(p => p.Type == ClaimTypes.GivenName)?.Value
                };
            }

            return null;
        }
    }
}
