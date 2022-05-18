using Brive.Bootcamp.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.API.Controllers
{
    [EnableCors("Bootcamp")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        List<Person> persons = new List<Person>();
        public PersonController()
        {
            for (int i = 0; i <= 10; i++)
            {
                persons.Add(new Person
                {
                    Id = i + 1,
                    Name = $"Persona {i + 1}",
                    Age = 18 + i,
                    Email = $"correo{i + 1}@correo.com",
                    CreatedDate = DateTime.UtcNow
                });
            }
        }
        //apiBase/controlador/endpoint
        [HttpGet]
        [Route("all")]
        public ActionResult<List<Person>> GetAllPersons()
        {      
            return StatusCode(StatusCodes.Status200OK, persons);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            return StatusCode(StatusCodes.Status200OK, persons.Where(person => person.Id == id).FirstOrDefault());
        }

        [HttpPost]
        [Route("savePerson")]
        public ActionResult<Person> SavePerson([FromBody] Person person)
        {
            return StatusCode(StatusCodes.Status200OK, person);
        }

        [HttpPut]
        public ActionResult<Person> EditedPerson([FromBody] Person person)
        {
            Person editedPerson = persons.Where( x => x.Id == person.Id).FirstOrDefault();
            if (editedPerson == null) return StatusCode(StatusCodes.Status400BadRequest, editedPerson);

            person.Name = "Nombre editado";
            person.Age = 22;
            person.CreatedDate = editedPerson.CreatedDate;
            person.Email = editedPerson.Email;

            return StatusCode(StatusCodes.Status200OK, person);
        }

        [HttpDelete]
        public ActionResult<List<Person>> DeletedPerson([FromBody] int id)
        {
            return StatusCode(StatusCodes.Status200OK, persons.Where(person => person.Id != id));
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<bool> Deleted2Person()
        {
            return StatusCode(StatusCodes.Status200OK, true);
        }
    }
}
