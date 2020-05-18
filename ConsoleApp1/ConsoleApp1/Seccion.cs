using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Seccion : Division
    {
        private List<Bloque> bloques = new List<Bloque>();
        public List<Bloque> Bloques { get => bloques; set => bloques = value; }


        public Seccion(string Nombre, Persona Encargado) : base(Nombre, Encargado)
        {

        }

    }
}
