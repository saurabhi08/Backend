using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MySecondProject.Controllers
{
    [Route("api/q7")]
    [ApiController]
    public class TimemachineController : ControllerBase
    {
        // GET localhost:xx/api/q7//timemachine?days={days} -> Returns the adjusted date
        [HttpGet("timemachine")]
        public string GetAdjustedDate([FromQuery] int days)
        {
            // Get the current date
            DateTime currentDate = DateTime.Today;

            // Adjust the date by the specified number of days
            DateTime adjustedDate = currentDate.AddDays(days);

            // Return the adjusted date as a string formatted as yyyy-MM-dd
            return adjustedDate.ToString("yyyy-MM-dd");
        }
    }
}