namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Somma di due numeri interi
            
            int sommaInteri = CalcoliHelper.Somma(5, 3);
            Console.WriteLine($"La somma tra 3 e 5 è {sommaInteri}");

            // Somma di due numeri double
            double sommaDouble = CalcoliHelper.Somma(5.5, 3.2);
            Console.WriteLine($"La somma tra 5,5 e 3,2 è {sommaDouble}");

            // Differenza tra due numeri interi
            int differenzaInt = CalcoliHelper.Differenza(10, 3);
            Console.WriteLine($"La differenza tra 10 e 3 è {differenzaInt}");

            // Differenza tra due numeri double
            double differenzaDouble = CalcoliHelper.Differenza(10.5, 3.8);
            Console.WriteLine($"La differenza tra 10,5 e 3,8 è {differenzaDouble}");

            // Moltiplicazione di due numeri interi
            int moltiplicazioneInt = CalcoliHelper.Moltiplicazione(5, 3);
            Console.WriteLine($"La moltiplicazione tra 5 e 3 è {moltiplicazioneInt}");

            // Moltiplicazione di due numeri double
            double moltiplicazioneDouble = CalcoliHelper.Moltiplicazione(5.5, 3.5);
            Console.WriteLine($"La moltiplicazione tra 5,5 e 3,5 è {moltiplicazioneDouble}");

            // Valore assoluto di un numero intero
            int valoreAssolutoInt = CalcoliHelper.ValoreAssoluto(-5);
            Console.WriteLine($"Il valore assoluto di -5 è {valoreAssolutoInt}");

            // Valore assoluto di un numero double
            double valoreAssolutoDouble = CalcoliHelper.ValoreAssoluto(-5.5);
            Console.WriteLine($"Il valore assoluto di -5,5 è {valoreAssolutoDouble}");

            // Minimo tra due numeri interi
            int minimoInt = CalcoliHelper.Minimo(5, 3);
            Console.WriteLine($"Il minimo tra 5 e 3 è {minimoInt}");

            // Minimo tra due numeri double
            double minimoDouble = CalcoliHelper.Minimo(5.5, 3.5);
            Console.WriteLine($"Il minimo tra 5,5 e 3,5 è {minimoDouble}");

            // Massimo tra due numeri interi
            int massimoInt = CalcoliHelper.Massimo(5, 3);
            Console.WriteLine($"Il massimo tra 5 e 3 è {massimoInt}");

            // Massimo tra due numeri double
            double massimoDouble = CalcoliHelper.Massimo(5.5, 3.5);
            Console.WriteLine($"Il massimo tra 5,5 e 3,5 è {massimoDouble}");

            // Potenza di un numero
            double potenzaNum = CalcoliHelper.Potenza(4, -2);
            Console.WriteLine($"La potenza di 4 alla -2 è {potenzaNum}");

            double potenzaNum2 = CalcoliHelper.Potenza(4, 0);
            Console.WriteLine($"La potenza di 4 alla 0 è {potenzaNum2}");

            double potenzaNum3 = CalcoliHelper.Potenza(-2, 3);
            Console.WriteLine($"La potenza di -2 alla 3 è {potenzaNum3}");

            double potenzaNum4 = CalcoliHelper.Potenza(0, 0);
            Console.WriteLine($"La potenza di 0 alla 0 è {potenzaNum4}");


        }
    }
}
