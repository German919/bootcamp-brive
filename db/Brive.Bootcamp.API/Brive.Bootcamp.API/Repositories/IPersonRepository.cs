using Brive.Bootcamp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.API.Repositories
{
     public interface IPersonRepository
    {
        List<Person> GetAllPersons();
        Person GetPersonById(int Id);
        Person SavePerson(Person person);
        Person EditedPerson(Person person);
        void DeletedPerson(Person person);
    }
}
