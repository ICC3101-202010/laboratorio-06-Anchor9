using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            Console.WriteLine("¿Desea cargar archivo con informacion de la empresa?\n[1]Yes\n[2]No");
            string opcion = Convert.ToString(Console.ReadLine());
            while (opcion != "1" && opcion != "2")
            {
                opcion = Convert.ToString(Console.ReadLine());
            }
            if (opcion == "1")
            {
                
                try
                {
                    LoadINFO();
                }
                catch (FileNotFoundException e) 
                {
                    Console.WriteLine("No se encuentra archivo");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Se creará un nuevo archivo");

                }

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
