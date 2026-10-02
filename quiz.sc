
class Program
{
    static void Main()
    {
        int CANTIDAD = 20;

        // Tus 4 estudiantes ya fijos
        string[] nombres = new string[] { "Daniela", "ronald", "Santiago", "Milena", "sandoval", "peyo", "reel","ben" ," saul","deleon","elmas" };
        double[] calificaciones = new double[CANTIDAD];

        Console.WriteLine($"--- REGISTRO DE {CANTIDAD} ESTUDIANTES ---");

        // 1. REGISTRO DE NOTAS CON VALIDACIÓN SOLO CON FOR
        for (int i = 0; i < CANTIDAD; i++)
        {
            Console.WriteLine($"\nEstudiante #{i + 1}: {nombres[i]}");

            for (int v = 0; v < 1; v++)
            {
                Console.Write($"Nota para {nombres[i]} (0.0 - 5.0): ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out double nota))
                {
                    if (nota >= 0.0 && nota <= 5.0)
                    {
                        calificaciones[i] = nota;
                    }
                    else
                    {
                        Console.WriteLine("Error: La nota debe estar entre 0.0 y 5.0");
                        v--;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un número decimal válido.");
                    v--;
                }
            }
        }

        // 2. CÁLCULOS FINALES
        double suma = 0;
        double mayor = calificaciones[0];
        double menor = calificaciones[0];
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 0; i < CANTIDAD; i++)
        {
            suma += calificaciones[i];
            if (calificaciones[i] > mayor) mayor = calificaciones[i];
            if (calificaciones[i] < menor) menor = calificaciones[i];

            if (calificaciones[i] >= 3.0)
                aprobados++;
            else
                reprobados++;
        }

        double promedio = suma / CANTIDAD;

        // 3. REPORTE FINAL
        Console.WriteLine("\n--- REPORTE FINAL DEL GRUPO ---");
        for (int i = 0; i < CANTIDAD; i++)
        {
            Console.WriteLine($"{nombres[i]} - Nota: {calificaciones[i]}");
        }

        Console.WriteLine($"\nPromedio del grupo: {promedio:F2}");
        Console.WriteLine($"Nota mayor: {mayor}");
        Console.WriteLine($"Nota menor: {menor}");
        Console.WriteLine($"Cantidad de aprobados (>= 3.0): {aprobados}");
        Console.WriteLine($"Cantidad de reprobados (< 3.0): {reprobados}");
    }
}
