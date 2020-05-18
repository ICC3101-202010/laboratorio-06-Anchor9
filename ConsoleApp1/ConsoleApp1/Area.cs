using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Area : Division
    {
        protected string name;
        protected List<Departamento> dptos;
    }
}
