using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcorewebapp.Domain;

namespace aspnetcorewebapp.Services
{
    public interface INameService
    {
        Task<IEnumerable<PersonName>> Get();
    }
}