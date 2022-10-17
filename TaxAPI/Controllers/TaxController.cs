using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace TaxAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxController : ControllerBase
    {
        public TaxController()
        {
        }

        [HttpGet]
        [Route("GetInterestRate")]
        public Tax GetInterestRate()
        {
            return new Tax
            {
                InterestRate = 0.01
            };
        }
    }
}