
using Microsoft.AspNetCore.Mvc;
using TwotoFourEndpoints.Services;

namespace TwotoFourEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComparisonController : ControllerBase
    {
          private readonly ComparisonService _comparisonService;

          public ComparisonController(ComparisonService comparisonService)
          {
            _comparisonService = comparisonService;
          }
          [HttpGet("{num1}/ {num2}")]
           public ActionResult<string> CompareNumbers(int num1, int num2)
           {
             string result = _comparisonService.CompareNumbers(num1, num2);
            return Ok(result);
           }
    }
}