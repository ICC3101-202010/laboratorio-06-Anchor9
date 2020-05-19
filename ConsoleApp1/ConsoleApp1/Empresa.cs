using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    [Serializable]
    class Empresa
    {
        private string nombre;
        private string rut;
        private List<Division> divisiones = new List<Division>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }
        public List<Division> Divisiones { get => divisiones; set => divisiones = value; }

        public Empresa(string Nombre, string Rut) 
        {
            this.rut = Rut;
            this.nombre = Nombre;
        }
   





    }
}
