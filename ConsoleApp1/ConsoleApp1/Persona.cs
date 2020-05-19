using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Persona
    {
        
        private string nombre;
        private string rut;
        private string cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Cargo { get => cargo; set => cargo = value; }


        public Persona(string nombre, string rut, string cargo) 
        {
            this.nombre = nombre;
            this.rut = rut;
            this.cargo = cargo;
        
        }

    }
}
