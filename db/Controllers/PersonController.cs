
using Microsoft.AspNetCore.Mvc;
using db.Services;
using System.Linq;
using db.Model;
namespace db.Controllers
{
    [ApiController]
    [Route("/api/[controllers]")]
    public class PersonController : ControllerBase
    {

       private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        [Produces(typeof(Person))]
        public IActionResult Get()
        {
            var persons = _personService.GetAll();

            if(persons.Count() == 0){
                    return NoContent();
            }

            return Ok(persons);
        
         }
    }
}