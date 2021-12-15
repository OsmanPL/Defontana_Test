using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Defontana_Test1.Clases
{
    public class Organismo
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("Name")]
        public String Name { get; set; }

        [JsonPropertyName("Parent")]
        public int Parent { get; set; }
    }
}
