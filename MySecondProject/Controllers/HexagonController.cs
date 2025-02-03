using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MySecondProject.Controllers
{
    [Route("api/q6")]
    [ApiController]
    public class HexagonController : ControllerBase
    {
        // GET http://localhost:xx/api/q6/hexagon?side={S} -> Returns the area of the hexagon with side length S
        [HttpGet("hexagon")]
        public double GetHexagonArea(double side)
        {
            // Formula: Area = (3 * sqrt(3) / 2) * side^2
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return area;
        }
    }
}