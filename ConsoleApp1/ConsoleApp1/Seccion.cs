using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Seccion : Departamento
    {

        protected string name;
        protected List<Bloque> bloques;
    }
}
