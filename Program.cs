using System;

namespace Lab3ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, apelati-o si afisati-i rezultatul.

            Console.WriteLine("introduceti un numar:");

            int n = int.Parse(Console.ReadLine());

            int result = n;

            Console.WriteLine($"suma numerelor pana  la {n} este: {GetSum(result, n)-n}");

        }

        static int GetSum( int result, int n)
        { 

            if (n<0)
            {
                return result;
            }

            result = n + GetSum(result, n-1);


            return result;
        }
    }
}
