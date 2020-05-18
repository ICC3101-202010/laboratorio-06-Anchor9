using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Bloque :  Division
    {
        public List<Persona> personal = new List<Persona>();
        public List<Persona> Personal { get => personal; set => personal = value; }

        public Bloque(string Nombre, Persona Encargado) : base(Nombre, Encargado)
        {

        }
    }
}
