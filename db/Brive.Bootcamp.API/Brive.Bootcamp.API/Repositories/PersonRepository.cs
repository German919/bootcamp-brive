using Brive.Bootcamp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.API.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly BootcampContext context;
        public PersonRepository(BootcampContext _context) 
        {
            context = _context;
        }

        public void DeletedPerson(Person person)
        {
            context.Person.Remove(person);
            context.SaveChanges();
        }

        public Person EditedPerson(Person person)
        {
            Person editedPerson = context.Person.Find(person.Id);
            if (editedPerson == null)
                return null;
            editedPerson.Name = person.Name;
            editedPerson.Age = person.Age;
            editedPerson.Email = person.Email;

            context.Person.Update(editedPerson);
            context.SaveChanges();

            return editedPerson;
        }

        public List<Person> GetAllPersons()
        {
            return context.Person.ToList();
        }

        public Person GetPersonById(int Id)
        {
            return context.Person.Find(Id);
        }

        public Person SavePerson(Person person)
        {
            context.Person.Add(person);
            context.SaveChanges();
            return person;
        }
    }
}
