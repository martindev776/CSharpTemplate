using Mappers;
using Repositories;
using Shared.Contracts;
using Shared.Models;

namespace RepositoryBridge
{
    public interface IPersonsBridge
    {
        PersonDto GetPersonById(int id);
    }

    public class PersonsBridge : IPersonsBridge, IPersonsContract
    {
        private readonly IPersonsRepository _personsRepository;
        private readonly IPersonsMapper _personsMapper;

        public PersonsBridge(IPersonsRepository personsRepository,
                             IPersonsMapper personsMapper)
        {
            _personsRepository = personsRepository;
            _personsMapper = personsMapper;
        }

        public PersonDto GetPersonById(int id)
        {
            var person = _personsRepository.GetPersonById(id);
            return _personsMapper.MapToDto(person);            
        }
    }
}
