using Brive.Bootcamp.API.Models;
using Brive.Bootcamp.API.Services;
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
        private IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        //apiBase/controlador/endpoint
        [HttpGet]
        [Route("all")]
        public ActionResult<List<Person>> GetAllPersons()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _personService.GetAllPersons());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _personService.GetPersonById(id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        [HttpPost]
        [Route("savePerson")]
        public ActionResult<Person> SavePerson([FromBody] Person person)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _personService.SavePerson(person));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        public ActionResult<Person> EditedPerson([FromBody] Person person)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _personService.EditedPerson(person));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult<List<Person>> DeletedPerson([FromBody] int id)
        {
            try
            {
                Person person = _personService.GetPersonById(id);
                if (person == null)
                    return StatusCode(StatusCodes.Status400BadRequest, null);
                return StatusCode(StatusCodes.Status200OK, _personService.DeletedPerson2(person));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<bool> Deleted2Person(int id)
        {
            try
            {
                Person person = _personService.GetPersonById(id);
                if (person == null)
                    return StatusCode(StatusCodes.Status400BadRequest, false);
                return StatusCode(StatusCodes.Status200OK, _personService.DeletedPerson2(person));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
