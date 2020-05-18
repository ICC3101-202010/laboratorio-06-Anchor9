using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Departamento : Division
    {
        private List<Seccion> seccion = new List<Seccion>();

        public Departamento(string Nombre, Persona Encargado) : base(Nombre, Encargado)
        {

        }

        public List<Seccion> Seccion { get => seccion; set => seccion = value; }
    }
}
