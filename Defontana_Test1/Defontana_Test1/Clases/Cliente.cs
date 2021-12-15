using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Defontana_Test1.Clases
{
    class Cliente
    {
        private readonly HttpClient cliente;
        
        public Cliente()
        {
            cliente = new HttpClient();
        }

        public async Task<List<Organismo>> ListarOrganismos()
        {
            var baseurl = "https://test.defontana.com";
            var response = await cliente.GetStringAsync(baseurl);
            String data = response.ToString();
            data = data.Replace("{\"data\":", "").Replace("]}", "]");
            List<Organismo> organismos = JsonConvert.DeserializeObject<List<Organismo>>(data);
            return organismos;
        }
    }
}
