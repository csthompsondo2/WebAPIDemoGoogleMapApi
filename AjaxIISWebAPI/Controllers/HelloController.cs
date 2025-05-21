using Microsoft.AspNetCore.Mvc;

namespace AjaxIISWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return Ok(new { message = "Hello from Scott's IIS" });
        }
    }
}
