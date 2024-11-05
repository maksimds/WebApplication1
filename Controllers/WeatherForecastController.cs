using Microsoft.AspNetCore.Mvc;

namespace YourProjectNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        // Denis Maksimov
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { Name = "Denis Maksimov" });
        }
    }
}

