using Business;
using Business.Models;
using RepositoryBridge;
using Shared.Contracts;

namespace Composer
{
    public interface IPersonsComposer
    {
        PersonWithAgeDto GetPersonWithAgeById(int id);
    }

    public class PersonsComposer : IPersonsComposer
    {
        private readonly IPersonsBridge _personsBridge;
        private readonly IPersonsService _personsService;

        public PersonsComposer(IPersonsBridge personsBridge,
                               IPersonsService personsService)
        {
            _personsBridge = personsBridge;
            _personsService = personsService;
        }

        public PersonWithAgeDto GetPersonWithAgeById(int id)
        {
            return _personsService.GetPersonWithAgeById((IPersonsContract)_personsBridge, id);            
        }
    }
}
