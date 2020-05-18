using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Bloque : Seccion
    {
        protected string name;
        protected List<Persona> personal;
    }
}
