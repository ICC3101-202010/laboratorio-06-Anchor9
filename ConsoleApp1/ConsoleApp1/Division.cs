using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Division
    {
        protected string name;
        protected Persona encargado;
        public  string Name { get => name; set => name = value; }
        public Persona Encargado { get => encargado; set => encargado = value; }

        public Division(string Nombre, Persona Encargado) 
        {
            this.name = Nombre;
            this.encargado = Encargado;
        
        }

        
    }
}
