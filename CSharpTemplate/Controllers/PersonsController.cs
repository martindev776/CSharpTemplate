using Composer;
using Microsoft.AspNetCore.Mvc;

namespace CSharpTemplate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsComposer _personsComposer;

        public PersonsController(IPersonsComposer personsComposer)
        {
            _personsComposer = personsComposer;
        }

        public IActionResult Index()
        {
            return Ok("This is persons controller");
        }

        [HttpGet, Route("GetPersonWithAge/{id}")]
        public IActionResult GetPersonWithAge(int id)
        {
            var result = _personsComposer.GetPersonWithAgeById(id);
            return Ok(result);
        }
    }
}
