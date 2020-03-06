using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreRoutingIssue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("{a}.{b}.{c}/{d}")]
        public IActionResult Test(string a, string b, string c, string d)
        {
            return Ok();
        }
    }
}
