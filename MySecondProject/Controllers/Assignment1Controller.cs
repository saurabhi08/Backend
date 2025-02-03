using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/q")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        //GET http://localhost:xx/welcome -> Welcome to 5125!
        [HttpGet(template: "welcome")]
        public string Get()
        {
            return "Welcome to 5125!";
        }
    }
}
