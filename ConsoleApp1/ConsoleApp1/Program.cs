using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Console.WriteLine("¿Desea cargar archivo con informacion de la empresa?\n[1]Si\n[2]No");
            string opcion = Convert.ToString(Console.ReadLine());
            while (opcion != "1" && opcion != "2")
            {
                opcion = Convert.ToString(Console.ReadLine());
            }
            if (opcion == "1")
            {

                try
                {
                    
                    ShowAllCompanyInfo(LoadINFO());
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("No se encuentra archivo");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Se creará un nuevo archivo");
                    CrearEmpresa();
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

        private static void ShowAllCompanyInfo(Empresa empresa) 
        {
            Console.WriteLine("Su empresa es" + empresa.Nombre + "y su rut es" + empresa.Rut); 
            try
            {
                int largo =  empresa.Divisiones.Count;
                if (largo == 4)
                {
                    foreach (Area area in empresa.Divisiones)
                    {
                        Console.WriteLine("Nombre area: " + area.Name + "\nNombre encargado: " + area.Encargado);
                        foreach (Departamento departamento in area.Dptos)
                        {
                            Console.WriteLine("Nombre departamento: " + departamento.Name + "\nNombre encargado: " + departamento.Encargado);
                            foreach (Seccion seccion in departamento.Seccion)
                            {
                                Console.WriteLine("Nombre seccion: " + seccion.Name + "\nNombre encargado: " + seccion.Encargado);
                                foreach (Bloque bloque in seccion.Bloques)
                                {
                                    Console.WriteLine("Nombre bloque: " + bloque.Name + "\nNombre encargado: " + bloque.Encargado);
                                    foreach (Persona persona in bloque.Personal)
                                    {
                                        Console.WriteLine("Nombre persona: " + persona.Nombre + "\nrut: " + persona.Rut);

                                    }
                                }
                            }
                        }
                    }

                }
                else if (largo == 3)
                {
                    foreach (Departamento departamento in empresa.Divisiones)
                    {
                        Console.WriteLine("Nombre departamento: " + departamento.Name + "\nNombre encargado: " + departamento.Encargado);
                        foreach (Seccion seccion in departamento.Seccion)
                        {
                            Console.WriteLine("Nombre seccion: " + seccion.Name + "\nNombre encargado: " + seccion.Encargado);
                            foreach (Bloque bloque in seccion.Bloques)
                            {
                                Console.WriteLine("Nombre bloque: " + bloque.Name + "\nNombre encargado: " + bloque.Encargado);
                                foreach (Persona persona in bloque.Personal)
                                {
                                    Console.WriteLine("Nombre persona: " + persona.Nombre + "\nrut: " + persona.Rut);

                                }
                            }
                        }
                    }

                }
                else if (largo == 2)
                {
                    foreach (Seccion seccion in empresa.Divisiones)
                    {
                        Console.WriteLine("Nombre seccion: " + seccion.Name + "\nNombre encargado: " + seccion.Encargado);
                        foreach (Bloque bloque in seccion.Bloques)
                        {
                            Console.WriteLine("Nombre bloque: " + bloque.Name + "\nNombre encargado: " + bloque.Encargado);
                            foreach (Persona persona in bloque.Personal)
                            {
                                Console.WriteLine("Nombre persona: " + persona.Nombre + "\nrut: " + persona.Rut);

                            }
                        }
                    }
                }
                else if (largo == 1) 
                {
                    foreach (Bloque bloque in empresa.Divisiones)
                    {
                        Console.WriteLine("Nombre bloque: " + bloque.Name + "\nNombre encargado: " + bloque.Encargado);
                        foreach (Persona persona in bloque.Personal)
                        {
                            Console.WriteLine("Nombre persona: " + persona.Nombre + "\nrut: " + persona.Rut);

                        }
                    }

                }

         
            }
            catch 
            {
            
            }
        
        }

        public static void CrearEmpresa() //con un minimo de lo que pide el enunciado, para que pueda cargar
        {
            Console.WriteLine("Ingrese nombre de la empresa");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese rut de la empresa");
            string rut = Console.ReadLine();
            Empresa empresa_nueva = new Empresa(nombre, rut);

            Departamento dep1 = crearDepartamento();
            Seccion sec1 = crearSeccion();
            Bloque bloque1 = crearBloque();
            bloque1.personal.Add((crearPersona()));
            Bloque bloque2 = crearBloque();
            bloque2.personal.Add((crearPersona()));

            sec1.Bloques.Add(bloque1);
            sec1.Bloques.Add(bloque2);
            dep1.Seccion.Add(sec1);
            empresa_nueva.Divisiones.Add(dep1);
            SaveINFO(empresa_nueva);


        }
        public static Persona crearPersona() 
        {
            Console.WriteLine("Ingrese nombre de la persona");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese rut");
            string rut = Console.ReadLine();
            Console.WriteLine("Ingrese cargo");
            string cargo = Console.ReadLine();
            Persona persona = new Persona(nombre, rut, cargo);
            return persona;
        }
        public static Bloque crearBloque() 
        {
            Console.WriteLine("Ingrese nombre de Bloque");
            string nombre = Console.ReadLine();
            Console.WriteLine("Informacion del encargdo");
            Bloque bloque = new Bloque(nombre, crearPersona());
            return bloque;
        }
        public static Seccion crearSeccion() 
        {
            Console.WriteLine("Ingrese nombre de la seccion");
            string nombre_Sec = Console.ReadLine();
            Console.WriteLine("Informacion del encargdo");
            Seccion seccion = new Seccion(nombre_Sec, crearPersona());
            return seccion;

        }
        public static Departamento crearDepartamento() 
        {
            Console.WriteLine("Ingrese nombre de departamento");
            string nombre_dep = Console.ReadLine();
            Console.WriteLine("Informacion del encargdo");
            Departamento departamento = new Departamento(nombre_dep, crearPersona());
            return departamento;
        }
        public static Area CrearArea() 
        {
            Console.WriteLine("Ingrese nombre de Area");
            string nombre_area = Console.ReadLine();
            Console.WriteLine("Informacion del encargdo");
            Area area = new Area(nombre_area, crearPersona());
            return area;

        }
    }
}
