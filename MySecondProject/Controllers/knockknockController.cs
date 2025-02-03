using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MySecondProject.Controllers
{
    [Route("api/q4")]
    [ApiController]
    public class KnockKnockController : ControllerBase
    {
        // GET http://localhost:xx/api/q4/knockknock -> Returns "Who's there?"
        [HttpGet("knockknock")]
        public string KnockKnock()
        {
            return "Who’s there?";
        }
    }
}
