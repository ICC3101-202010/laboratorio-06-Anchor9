using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Area : Division
    {
        private List<Departamento> dptos = new List<Departamento>();
        
        public List<Departamento> Dptos { get => dptos; set => dptos = value; }


        public Area(string Nombre, Persona Encargado) : base(Nombre,Encargado)
        {

        }
    }
}
