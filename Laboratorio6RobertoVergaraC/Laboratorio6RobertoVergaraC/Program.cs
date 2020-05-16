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
            Empresa empresa = new Empresa();

            while (true)
            {
                Console.WriteLine("Seleccione la opción que desee:");
                Console.WriteLine("(a) Utilizar archivo existente\n(b) Crear empresa nueva\n(c) Ver información de la empresa\n(d) Salir");
                string des = Console.ReadLine();
                if (des == "a")
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                    try
                    {
                        empresa = (Empresa)formatter.Deserialize(stream);
                    }
                    catch
                    {
                        Console.WriteLine("\nLa opción seleccionada no es válida, ya que no hay ningún archivo guardado");
                        empresa = Create();
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
                else if (des == "b")
                {
                    Create();
                }
                else if (des == "c")
                {
                    //Ver INFO
                }
                else if (des == "d")
                {
                    if (empresa.Name != null && empresa.Rut != null)
                    {
                        Save(empresa);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\nLa opción seleccionada no es válida, por favor seleccionar una que si lo sea\n");
                }
            }
        }

        static private Empresa Create()
        {
            Console.WriteLine("\nSeleccione el nombre de la empresa:");
            string name = Console.ReadLine();
            Console.WriteLine("\nSeleccione el rut de la empresa (Ej: 20.153.414-3)");
            string rut = Console.ReadLine();
            Empresa empresa = new Empresa(name, rut);
            return empresa;
        }

        static private void Save(Empresa empresa)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa);
            stream.Close();
        }
    }
}
