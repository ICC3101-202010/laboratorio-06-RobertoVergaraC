using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratorio6RobertoVergaraC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación Personas Random
            Persona persona0 = new Persona("Juanito","Pérez","19.467.433-5","Jefe");
            Persona persona1 = new Persona("Richard", "Muñoz", "19.467.434-5", "Jefe");
            Persona persona2 = new Persona("Alex", "González", "19.467.435-5", "Jefe");
            Persona persona3 = new Persona("Paul", "Diaz", "19.467.436-5", "Jefe");
            Persona persona4 = new Persona("Ignacio", "Diáz", "19.467.437-5", "Obrero");
            Persona persona5 = new Persona("Gustavo", "Howard", "19.467.438-5", "Obrero");
            Persona persona6 = new Persona("Byron", "Nuñez", "19.467.439-5", "Obrero");
            Persona persona7 = new Persona("Bob", "Palma", "19.467.440-5", "Obrero"); 
            Persona persona8 = new Persona("Javier", "Valenzuela", "19.468.445-7", "Obrero");
            List<Persona> jefes = new List<Persona>() { persona0, persona1, persona2, persona3 };
            List<Persona> obreros = new List<Persona>() { persona4, persona5, persona6, persona7, persona8 };

            Empresa empresa = new Empresa();

            while (true)
            {
                Console.WriteLine("Seleccione la opción que desee:");
                Console.WriteLine("(a) Utilizar archivo existente\n(b) Crear empresa nueva\n(d) Salir");
                string des = Console.ReadLine();
                if (des == "a")
                {
                    try
                    {
                        LoadCompanyInformation(empresa);
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("\nNo se pudo abrir el archivo");
                        Console.WriteLine(e.Message);
                        Console.WriteLine("\nLa opción seleccionada no es válida, ya que no hay ningún archivo guardado");
                        empresa = Create(jefes, obreros);
                    }
                    ShowEmpresa(empresa);
                }
                else if (des == "b")
                {
                    Create(jefes,obreros);
                }
                else if (des == "d")
                {
                    if (empresa.Name != null && empresa.Rut != null)
                    {
                        SaveCompanyInformation(empresa);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\nLa opción seleccionada no es válida, por favor seleccionar una que si lo sea\n");
                }
            }
        }

        static private Empresa Create(List<Persona> jefes,List<Persona> obreros)
        {
            List<Persona> jefes2 = new List<Persona>();
            List<Persona> obreros2 = new List<Persona>();
            Console.WriteLine("\nSeleccione el nombre de la empresa:");
            string name = Console.ReadLine();
            Console.WriteLine("\nSeleccione el rut de la empresa (Ej: 20.153.414-3)");
            string rut = Console.ReadLine();
            //Random Jefes (3) y Obreros(5)
            jefes2 = DesordenarLista(jefes);
            obreros2 = DesordenarLista(obreros);
            Departamento depto = new Departamento("Departamento BASE", jefes2[0]);
            Sección secc = new Sección("Sección BASE", jefes2[1]);
            Bloque bloq1 = new Bloque("Bloque BASE 1", jefes2[2], new List<Persona>() {obreros2[0],obreros2[1] });
            Bloque bloq2 = new Bloque("Bloque BASE 2", jefes2[3], new List<Persona>() { obreros2[2], obreros2[3] });
            Empresa empresa = new Empresa(name, rut,new List<División>() {depto,secc,bloq1,bloq2 });
            return empresa;
        }

        static private void SaveCompanyInformation(Empresa empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa);
            stream.Close();
        }

        static private void LoadCompanyInformation(Empresa empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            empresa = (Empresa)formatter.Deserialize(stream);
            stream.Close();
        }

        public static void ShowEmpresa(Empresa empresa)
        {

        }

        public static List<Persona> DesordenarLista<Persona>(List<Persona> personas)
        {
            List<Persona> jefe = personas;
            List<Persona> arrDes = new List<Persona>();

            Random randNum = new Random();
            while (jefe.Count > 0)
            {
                int val = randNum.Next(0, jefe.Count - 1);
                arrDes.Add(jefe[val]);
                jefe.RemoveAt(val);
            }
            return arrDes;
        }
    }
}
