
using Microsoft.AspNetCore.Mvc;
using TwotoFourEndpoints.Services;

namespace TwotoFourEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonalInfoController : ControllerBase
    {
        private readonly PersonalInfoService _personalInfoService;

        public PersonalInfoController (PersonalInfoService personalInfoService)
        {
            _personalInfoService = personalInfoService;
        }

        [HttpGet("{name}/ {wakeUp}")]
        public ActionResult<string> GetPersonalInfo(string name, string wakeUp)
        {
            string results = _personalInfoService.GetPersonalInfo(name, wakeUp);
            return Ok(results);
        }
    }
}