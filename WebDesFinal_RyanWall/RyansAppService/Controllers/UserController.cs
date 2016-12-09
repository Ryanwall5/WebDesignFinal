using WedDesign_Final_RyanWall.Models;
using WedDesign_Final_RyanWall.Data;
using System.Collections.Generic;

using System.Web.Http;

namespace RyansAppService.Controllers
{
    public class PersonController : ApiController
    {
        private IDataRepository repository;

        public PersonController()
        {

            repository = new EfDataRepository();
        }

        public List<Person> GetAllUsers()
        {
            List<Person> people = repository.GetAllPeople();

            return people;
        }
    

        public IHttpActionResult GetPerson(int id)
        {
            var person = repository.GetPerson(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }




    }
}
