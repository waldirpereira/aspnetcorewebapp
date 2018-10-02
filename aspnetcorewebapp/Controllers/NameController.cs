using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcorewebapp.Domain;
using aspnetcorewebapp.Services;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcorewebapp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        private readonly INameService _nameService;

        public NameController(INameService nameService)
        {
            _nameService = nameService;
        }

        // GET: api/Name
        [HttpGet]
        public async Task<IEnumerable<PersonName>> Get()
        {
            var names = await _nameService.Get();

            return names;
        }

        // GET: api/Name/5
        [HttpGet("{id}", Name = "Get")]
        public PersonName Get(int id)
        {
            return new PersonName { Name = "Bob" };
        }

        // POST: api/Name
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Name/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
