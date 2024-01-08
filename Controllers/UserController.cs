using Microsoft.AspNetCore.Mvc;
using Test_API_For_TAP.Models;

namespace Test_API_For_TAP.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet, Route("Get-Message")]
        public IActionResult GetMessage()
        {
            UserInfo user = new UserInfo { FirstName = "John", LastName = "Eads" };



            return Ok($"{user.FirstName} {user.LastName} can suck it");
        }
    }
}
