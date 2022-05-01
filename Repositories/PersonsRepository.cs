using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IPersonsRepository
    {
        Person GetPersonById(int id);
    }

    public class PersonsRepository : IPersonsRepository
    {
        public Person GetPersonById(int id)
        {
            var person = GetPersons().FirstOrDefault(x => x.Id == id);

            if (person == null)
                throw new Exception($"Can't find person with Id: {id}");

            return person;
        }


        //Simulating a database table
        private IEnumerable<Person> GetPersons()
        {
            return new[]
            {
                new Person{ Id = 1, FirstName = "John", LastName = "Smith", DateOfBirth = Convert.ToDateTime("1905-01-01") },
                new Person{ Id = 2, FirstName ="Jane", LastName = "Smith", DateOfBirth = Convert.ToDateTime("1907-02-01")},
                new Person{ Id = 3, FirstName = "John", LastName = "Doe", DateOfBirth = Convert.ToDateTime("1985-03-01") },
                new Person{ Id = 4, FirstName ="Jane", LastName = "Doe", DateOfBirth = Convert.ToDateTime("1987-04-01")},
            };
        }
    }
}
