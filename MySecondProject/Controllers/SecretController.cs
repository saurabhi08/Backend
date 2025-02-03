using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MySecondProject.Controllers
{
    [Route("api/q5")]
    [ApiController]
    public class SecretController : ControllerBase
    {
        // POST http://localhost:xx/api/q5/secret -> Returns "Shh.. the secret is {secret}"
        [HttpPost("secret")]
        public string Secret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}
