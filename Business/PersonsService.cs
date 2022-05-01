using Business.Models;
using Shared.Contracts;

namespace Business
{
    public interface IPersonsService
    {
        PersonWithAgeDto GetPersonWithAgeById(IPersonsContract personsContract, int id);
    }

    public class PersonsService : IPersonsService
    {
        public PersonWithAgeDto GetPersonWithAgeById(IPersonsContract personsContract, int id)
        {
            var personDto = personsContract.GetPersonById(id);

            return new PersonWithAgeDto
            {
                Name = $"{personDto.LastName}, {personDto.FirstName}",
                Age = CalculateAge(personDto.DateOfBirth)
            };            
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            var now = DateTime.Today;
            var age = now.Year - dateOfBirth.Year;
            if (dateOfBirth > now.AddYears(-age))
                age--;

            return age;
        }
    }
}
