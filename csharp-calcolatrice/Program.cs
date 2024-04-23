namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Somma di due numeri interi
            CalcoliHelper.Somma(5, 3);

            // Somma di due numeri double
            CalcoliHelper.Somma(5.5, 3.2);

            // Differenza tra due numeri interi
            CalcoliHelper.Differenza(10, 3);

            // Differenza tra due numeri double
            CalcoliHelper.Differenza(10.5, 3.8);

            // Moltiplicazione di due numeri interi
            CalcoliHelper.Moltiplicazione(5, 3);

            // Moltiplicazione di due numeri double
            CalcoliHelper.Moltiplicazione(5.5, 3.5);

            // Valore assoluto di un numero intero
            CalcoliHelper.ValoreAssoluto(-5);

            // Valore assoluto di un numero double
            CalcoliHelper.ValoreAssoluto(-5.5);

            // Minimo tra due numeri interi
            CalcoliHelper.Minimo(5, 3);

            // Minimo tra due numeri double
            CalcoliHelper.Minimo(5.5, 3.5);

            // Massimo tra due numeri interi
            CalcoliHelper.Massimo(5, 3);

            // Massimo tra due numeri double
            CalcoliHelper.Massimo(5.5, 3.5);

        }
    }
}
