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
        private List<Division> divisiones;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }

        public Empresa(string Nombre, string Rut) 
        {
            this.rut = Rut;
            this.nombre = Nombre;
        }
        public void Main() 
        {
            Console.WriteLine("¿Desea cargar archivo con informacion de la empresa?\n[1]Yes\n[2]No");
            string opcion = Convert.ToString(Console.ReadLine());
            while (opcion != "1" && opcion != "2") 
            {
                opcion = Convert.ToString(Console.ReadLine()); 
            }
            if (opcion == "1")
            {

            }
            else if (opcion == "2") 
            {
                Console.WriteLine("Ingrese nombre empresa ");
                string RUT = Console.ReadLine();

                Console.WriteLine("Ingrese rut");
                string NOMBRE = Console.ReadLine();

                Empresa empresa = new Empresa(NOMBRE, RUT);
                SaveINFO(empresa);
                
            
            }




        }
        private static Empresa LoadINFO() 
        {
            FileStream file = new FileStream("empresa.bin", FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            Empresa cargada = formatter.Deserialize(file) as Empresa;
            file.Close();
            return cargada;
            



        }

        private static void SaveINFO(Empresa empresa) 
        {
            FileStream file_name = new FileStream("empresa.bin", FileMode.CreateNew);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file_name, empresa);
            file_name.Close();



        }

    }
}
