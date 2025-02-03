using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/q2")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        // GET http://localhost:xx/greeting/Garry-> Hi Gary!
        [HttpGet(template: "greeting/{name}")]
        public string Get(string name)
        {
           string message = "Hi!"+name;
            return message;
           
        }
    }
}