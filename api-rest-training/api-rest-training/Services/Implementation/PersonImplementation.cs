using api_rest_training.Models;
using api_rest_training.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace api_rest_training.Services.Implementation
{
    public class PersonImplementation : IPersonServices
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
       
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindViewById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Ynoa",
                LastName = "Pedro",
                Address = "Fortaleza - Ceará - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrmentAndGet(),
                FirstName = "PersonName" + i,
                LastName = "PersonLastName" + i,
                Address = "PersonAddress" + i,
                Gender = "Male"
            };
        }

        private long IncrmentAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
