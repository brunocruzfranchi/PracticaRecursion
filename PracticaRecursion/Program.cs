using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nEl factorial de {0} es: {1}", n, Factorial(n));

            Console.WriteLine("Pregunta: Pueden haber más casos base para el factorial? Cuál podría ser otro?");

        }

        /// <summary>
        /// Esta funcion recibe un numero, para luego obtener el factorial del
        /// mismo utilizando recursividad
        /// </summary>
        /// <param name="numero">Numero para realizar el factorial</param>
        /// <returns></returns>
        static int Factorial(int numero)
        {
            // Caso base: Si llego a 1, retorno 1
            if (numero == 1) return 1;

            // Caso recursivo: Si el numero es diferente de 1, hago numero * Factorial(numero - 1)
            // Es decir, que voy a hacer la multiplicacion de numero * su decremento hasta que llegue a 1
            return numero * Factorial(numero - 1);
        }

        // Seguir con los ejercicios de la guia de recursion

    }
}
