using System;
using System.Collections.Generic;
using System.Text;

namespace Defontana_Test1.Clases
{
    class NodoOrganismo
    {
        public Organismo organimso { get; set; }

        public List<NodoOrganismo> childs { get; set; }
    }
}
