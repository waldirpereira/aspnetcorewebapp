using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using aspnetcorewebapp.Domain;
using Newtonsoft.Json;

namespace aspnetcorewebapp.Services
{
    public class NameService : INameService
    {
        public async Task<IEnumerable<PersonName>> Get()
        {
            using (var client = new HttpClient())
            {
                var url = new Uri($"http://uinames.com/api/?region=brazil&amount=25");
                var response = await client.GetAsync(url);
                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                return JsonConvert.DeserializeObject<IEnumerable<PersonName>>(json);
            }
        }
    }
}
