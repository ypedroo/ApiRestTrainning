using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest_training.Models;
using api_rest_training.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_rest_training.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        //Instaciate DI obj
        private readonly IPersonServices personService;

        public PersonsController(IPersonServices personServices)
        {
            this.personService = personServices;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(personService.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = personService.FindViewById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return NotFound();
            return new ObjectResult(personService.Create(person));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) return NotFound();
            return new ObjectResult(personService.Update(person));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            personService.Delete(id);
            return NoContent();
        }
    }
}
