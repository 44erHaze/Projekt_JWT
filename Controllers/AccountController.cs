using JWTAuthentication.Models;
using JWTAuthentication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace JWTAuthentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        public AccountController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] AuthenticateUser model)
        {
            if (model.Username != "admin" || model.Password != "1234")
                return Unauthorized("Invalid Credentials");
            else
                return new JsonResult(new { userName = model.Username, token = _tokenService.CreateToken(model.Username) });
        }
    }
}