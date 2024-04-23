using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal static class CalcoliHelper
    {
        /*------------------------------------------------------------------------------------------------------------
        // In questo caso vi è un overload di metodi, nonostante abbiano lo stesso nome e svolgono la stessa funzione,
        // il compilatore, in base ai tipi di dato passati come parametro sceglierà quello appropriato
        ------------------------------------------------------------------------------------------------------------*/

        // Somma di due numeri interi

        public static void Somma(int num1, int num2)
        {
            Console.WriteLine($"La somma di {num1} e {num2} è {num1 + num2}");
        }

        // Somma di due numeri double

        public static void Somma(double num1, double num2)
        {
            Console.WriteLine($"La somma di {num1} e {num2} è {num1 + num2}");
        }

        // Differenza tra due numeri interi

        public static void Differenza(int num1, int num2)
        {
            Console.WriteLine($"La differenza tra {num1} e {num2} è: {num1 - num2}");
        }

        // Differenza tra due numeri double

        public static void Differenza(double num1, double num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"La differenza tra {num1} e {num2} è: {num1 - num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} è minore di {num2}, non è possibile effettuare una sottrazione tra interi");
            }
            else
            {
                Console.WriteLine($"La differenza tra {num1} e {num2} è zero");
            }
        }

        // Moltiplicazione di due numeri interi

        public static void Moltiplicazione(int num1, int num2)
        {
            Console.WriteLine($"{num1} moltiplicato {num2} è uguale a {num1 * num2}");
        }

        // Moltiplicazione di due numeri double

        public static void Moltiplicazione(double num1, double num2)
        {
            Console.WriteLine($"{num1} moltiplicato {num2} è uguale a {num1 * num2}");
        }

        // Valore assoluto di un numero intero

        public static void ValoreAssoluto(int num)
        {
            int numeroAssoluto = num;
            if (num < 0)
            {
                num = -num;
            }
            Console.WriteLine($"Il valore assoluto di {numeroAssoluto} è {num}");
        }

        // Valore assoluto di un numero double

        public static void ValoreAssoluto(double num)
        {
            double numeroAssoluto = num;
            if (num < 0)
            {
                num = -num;
            }
            Console.WriteLine($"Il valore assoluto di {numeroAssoluto} è {num}");
        }

        // Minimo tra due numeri interi

        public static void Minimo(int num1, int num2)
        {
            if(num1 > num2)
            {
                Console.WriteLine($"{num2} è il valore minimo");
            }
            else if(num1 < num2)
            {
                Console.WriteLine($"{num1} è il valore minimo");
            }
            else
            {
                Console.WriteLine("I numeri sono uguali");
            }
        }

        // Minimo tra due numeri double

        public static void Minimo(double num1, double num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num2} è il valore minimo");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} è il valore minimo");
            }
            else
            {
                Console.WriteLine("I numeri sono uguali");
            }
        }

        // Massimo tra due numeri interi

        public static void Massimo(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} è il valore massimo");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} è il valore massimo");
            }
            else
            {
                Console.WriteLine("I numeri sono uguali");
            }
        }

        // Massimo tra due numeri double

        public static void Massimo(double num1, double num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} è il valore massimo");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} è il valore massimo");
            }
            else
            {
                Console.WriteLine("I numeri sono uguali");
            }
        }
    }
}
