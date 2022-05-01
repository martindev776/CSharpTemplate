using Repositories.Models;
using Shared.Models;

namespace Mappers
{
    public interface IPersonsMapper
    {
        PersonDto MapToDto(Person person);
    }

    public class PersonsMapper : IPersonsMapper
    {
        public PersonDto MapToDto(Person person)
        {
            return new PersonDto
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                DateOfBirth = person.DateOfBirth
            };
        }
    }
}
