using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MySecondProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SquashFellowsController : ControllerBase
    {
        // POST http://localhost:xx/api/q8/squashfellows -> Returns checkout summary for SquashFellows order
        [HttpPost("squashfellows")]
        public IActionResult CheckoutSummary([FromForm] int Small, [FromForm] int Large)
        {
            // Prices and tax rate
            decimal smallPrice = 25.50m;
            decimal largePrice = 40.50m;
            decimal hstRate = 0.13m;

            // Calculate subtotal
            decimal smallTotal = Small * smallPrice;
            decimal largeTotal = Large * largePrice;
            decimal subtotal = smallTotal + largeTotal;

            // Calculate tax
            decimal tax = subtotal * hstRate;

            // Calculate total
            decimal total = subtotal + tax;

            // Prepare the checkout summary string
            string summary = $"{Small} Small @ ${smallPrice:F2} = ${smallTotal:F2}; " +
                             $"{Large} Large @ ${largePrice:F2} = ${largeTotal:F2}; " +
                             $"Subtotal = ${subtotal:F2}; " +
                             $"Tax = ${tax:F2} HST; Total = ${total:F2}";

            return Ok(summary);
        }
    }
}