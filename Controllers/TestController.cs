using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GETController : Controller
    {
        [HttpGet("Mitarbeiter")]
        [AllowAnonymous]
        public string First()
        {
            return "Susanne Hilfiger \n" +
                "Friedrich-strasse 69 \n" +
                "079 420 69 69 \n" +
                "Grosser Service \n" +
                "Standard";
        }

        [HttpGet("Admin")]
        [Authorize]
        public string Second()
        {
            return "Tony Montana \n" +
                "Königsalee 69 \n" +
                "061 420 44 44 \n" +
                "Heisswaschen \n" +
                "Express";
        }
    }
}
