using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        public static int Somma(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        // Somma di due numeri double

        public static double Somma(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        // Differenza tra due numeri interi

        public static int Differenza(int num1, int num2)
        {
            int diff = num1 - num2;
            return diff;
        }

        // Differenza tra due numeri double

        public static double Differenza(double num1, double num2)
        {
            double diff = num1 - num2;
            return diff;
        }

        // Moltiplicazione di due numeri interi

        public static int Moltiplicazione(int num1, int num2)
        {
            int mult = num1 * num2;
            return mult;
        }

        // Moltiplicazione di due numeri double

        public static double Moltiplicazione(double num1, double num2)
        {
            double mult = num1 * num2;
            return mult;
        }

        // Valore assoluto di un numero intero

        public static int ValoreAssoluto(int num)
        {
            if (num < 0)
            {
                num = -num;
                return num;
            }
            return num;
        }

        // Valore assoluto di un numero double

        public static double ValoreAssoluto(double num)
        {
            if (num < 0)
            {
                num = -num;
                return num;
            }
            return num;
        }

        // Minimo tra due numeri interi

        public static int Minimo(int num1, int num2)
        {
            if(num1 <= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
       
        }

        // Minimo tra due numeri double

        public static double Minimo(double num1, double num2)
        {
            if (num1 <= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        // Massimo tra due numeri interi

        public static int Massimo(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        // Massimo tra due numeri double

        public static double Massimo(double num1, double num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        /*----------------
        // BONUS POTENZA
        -----------------*/

        public static double Potenza(int baseNum, int exp)
        {
            if(baseNum == 0 && exp == 0)
            {
                return 1;
            }
            if(exp == 0)
            {
                return 1;
            }
            if(baseNum == 0)
            {
                return 0;
            }
            if(exp < 0)
            {
                return 1.0 /Potenza(baseNum, ValoreAssoluto(-exp));
            }

            double risultato = 1.0;
            for (int i = 0; i < exp; i++)
            {
                risultato *= baseNum;
            }
            return risultato;
        }
    }
}
