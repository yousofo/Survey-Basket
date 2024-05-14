using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SurveyBasket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopmentController : ControllerBase
    {
        [HttpGet]
        
        public IActionResult Run()
        {
            return Ok();
        }
    }
}
