using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using TwotoFourEndpoints.Services;

namespace TwotoFourEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumController : ControllerBase
    {

        private readonly SumService _sumService;
        public SumController(SumService sumService)
        {
            _sumService = sumService;
        }

        [HttpGet("{num1}/{num2}")]
        public ActionResult<string> GetSum(int num1, int num2)
        {
            string results = _sumService.GetSum(num1, num2);
        return Ok(results);
        }

    }
}