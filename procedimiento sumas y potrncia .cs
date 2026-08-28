using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp900
{
    internal class Program
    { //PROCEDIMIENTO SUMAR E IMPRIMIR 
        public static void ImprimirSuma(int a, int b) //a, b son los parametros
        {
            int suma = a + b;
            Console.WriteLine(suma);

        }
        public static void ImprimirPotencia(int a, int b)
        {
            double baseNumero = 5;
            double exponente = 3;

            double resultado = Math.Pow(baseNumero, exponente);


            Console.WriteLine(resultado);
        }
        static void ModificarValor(int a)
        {
            a = a + 1;
            Console.WriteLine($"DENTRO DEL METODO: {a}");
        }
        static void Main(string[] args)
        {
            int x = 10, y = 20;

            ImprimirSuma(y, x);
            ImprimirSuma(1000, -1);
            ImprimirPotencia(5, 3);

            int edad = 16;
            Console.WriteLine($"ANTES DEL METODO: {edad}");
            ModificarValor(edad);
            Console.WriteLine($"DESPUES DEL METODO: {edad}");

        }
    }
}
