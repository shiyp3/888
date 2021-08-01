using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult HelloWorld() => Ok("Hello World!");
    }
}