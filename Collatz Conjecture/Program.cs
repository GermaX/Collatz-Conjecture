using System;

namespace Collatz_Conjecture
{
    class Program
    {
        static void Main(string[] args)
        {

            Collatz();
            
        }

        public static void Collatz()
        {
            double n, aux;
            double count = 0;
            double par = 0;
            double impar = 0;
            double mayor = 0;

            Console.Clear();

            Console.WriteLine("Introduce un número a calcular:");
            double.TryParse(Console.ReadLine(), out n);
            Console.WriteLine();

            while (n > 1)
            {
                if (IsOdd(n))
                {
                    aux = (n * 3) + 1;
                    if (aux > mayor)
                        mayor = aux;
                    n = aux;
                    impar++;
                }
                else if (!IsOdd(n))
                {
                    aux = n / 2;
                    if (aux > mayor)
                        mayor = aux;
                    n = aux;
                    par++;
                }

                Console.WriteLine(n);
                count++;
            }
            Console.WriteLine("\nIteraciones: " + count);
            Console.WriteLine("Números pares: " + par);
            Console.WriteLine("Números impares: " + impar);
            Console.WriteLine("Número mayor alcanzado: " + mayor);

            Console.WriteLine("\n¿Iniciar de nuevo? S/N");
            if(Console.ReadLine().ToLowerInvariant() == "s")
            {
               Collatz();
            }
            else
            {
                Console.WriteLine("Adios ;)");
            }
            
        }

        public static bool IsOdd(double value)
        {
            return value % 2 != 0;
        }
    }
}
