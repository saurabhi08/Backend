using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MySecondProject.Controllers
{
    [Route("api/q3")]
    [ApiController]
    public class CubeController : ControllerBase
    {
        // GET http://localhost:xx/cube/{base} -> Returns the cube of {base}
        [HttpGet("cube/{number}")]
        public int GetCube(int number)
        {
            return number * number * number;
        }
    }
}