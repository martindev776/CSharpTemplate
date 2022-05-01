using Shared.Models;

namespace Shared.Contracts
{
    public interface IPersonsContract
    {
        PersonDto GetPersonById(int id);
    }
}
