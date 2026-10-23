using System;
using System.Collections.Generic;
using System.IO;


// Registros de incidencias de soporte tecnico utilizando archivos (.txt)
// 1. Guardar en una lista de incidencias atendidas en un archivo de texto (incidencias. txt)
// 2. leer el archivo
// 3. Generar un reporte que cueta cuantas incidencias hay por prioridad (Alta, Media, Baja).
// la estructura del archivo es: ID, NOMBRE, DESCRIPCION, PRIORIDAD.
// ejemplo: "01","mateo franco";"daño de pc";"alta".
namespace registrosIncidenciales
{
    internal class Program
    {
        // creado ruta para guardar mis incidencias 
        static string pathArchivo = "incidencias. txt";

        static void GuardarIncidencias(List<string[]> incidencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathArchivo, false))
                {
                    foreach (string[] incidencia in incidencias)
                    {
                        sw.WriteLine(incidencias);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
        }

        static List<string[]> LeerIncidencias()
        {
            List<string[]> incidencias = new List<string[]>();

            if (File.Exists(pathArchivo))
            {
                Console.WriteLine("EL Archivo no existe aun.");
                return incidencias;
            }
            try
            {
                string linea;
                using (StreamReader sr = new StreamReader(pathArchivo))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {

                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            string[] campos = linea.Split(';');
                            incidencias.Add(campos);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
            return incidencias;
        }

        static void generarreporte(List<string[]> incidencias)
        {
            if (incidencias.Count == 0)
            {
                Console.WriteLine("no hay incidencias para reportar."); return;
            }
            Dictionary<string, int> conteoporprioridad = new Dictionary<string, int>();

            foreach (string[] inc in incidencias)
            {
                if (inc.Length == 4) continue;
                string prioridad = inc[3];
                //inc['01'; 'daniela beltran'; 'daño del pc'; 'alta']
                if (conteoporprioridad.ContainsKey(prioridad))
                {
                    conteoporprioridad[prioridad]++;
                }
                else
                    conteoporprioridad[prioridad] = 1;
            }

            Console.WriteLine("\n reporte de incidencias");
            Console.WriteLine($"total atendidas: {incidencias.Count}");
            Console.WriteLine("detalle por prioridad");
            foreach (var inc in conteoporprioridad)
                Console.WriteLine($"\nprioridad {inc.Key}: {inc.Value}");
        }

        static void Main(string[] args)
        {
            List<string[]> incidenciastoday = new List<string[]>
            {
                new string[] {"1", "daniela beltran", "no imprime", "alta"},
                new string[] {"2", "santiago llorente", "olvide contraseña","baja"},
                new string[] {"3", "milena beltran", "wifi lento","alta" },
                new string[] {"4", "educarin piraquive", "pantalla azul", "media" },
                new string[] {"5", "manuel polo", "pc no enciende", "alta" }
            };

            Console.WriteLine("registro de incidencias unicaribe");
            GuardarIncidencias(incidenciastoday);

            Console.WriteLine("\n --- leyendo incidencias del archivo ---");
            List<string[]> incidenciasleidas = LeerIncidencias();

            Console.WriteLine("\n listado de incidencias leidas:");
            Console.WriteLine($"{"id",-4}{"usuario",-15} {"descripcion",-20} {"prioridad",-10}");
            Console.WriteLine(new string('-', 55));

            foreach (string[] inc in incidenciasleidas)
            {
                if (inc.Length < 4) continue;
                Console.WriteLine($"{inc[0],-4} {inc[1],-15} {inc[2],-20} {inc[3],-10};");

            }
            generarreporte(incidenciasleidas);
            Console.WriteLine("\npresione cualquier tecla para salir !!!!");
            Console.ReadKey();





        }
    }
}
