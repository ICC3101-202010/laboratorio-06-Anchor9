using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Departamento : Area
    {
        protected string name;
        protected List<Seccion> secciones;

    }
}
