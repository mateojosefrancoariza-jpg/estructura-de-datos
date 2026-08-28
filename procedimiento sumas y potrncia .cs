using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
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
        static void Main(string[] args)
        {
            int x = 10, y = 20;

            ImprimirSuma(y, x);
            ImprimirSuma(1000, -1);
            ImprimirPotencia(5, 3);
        }
    }
}
