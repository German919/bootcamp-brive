using Brive.Bootcamp.API.Models;
using Brive.Bootcamp.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.API.Services
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public bool DeletedPerson(Person person)
        {
            try
            {
                _personRepository.DeletedPerson(person);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Person> DeletedPerson2(Person person)
        {
            try
            {
                _personRepository.DeletedPerson(person);
                return _personRepository.GetAllPersons();
            }
            catch
            {
                return null;
            }
        }

        public Person EditedPerson(Person person)
        {
            return _personRepository.EditedPerson(person);
        }

        public List<Person> GetAllPersons()
        {
            return _personRepository.GetAllPersons();
        }

        public Person GetPersonById(int Id)
        {
            return _personRepository.GetPersonById(Id);
        }

        public Person SavePerson(Person person)
        {
            return _personRepository.SavePerson(person);
        }
    }
}
