using System;

namespace Prime_numbers
{
    class Program
    {
        static bool isPrime(int n)
        {
            if (n == 1 || n == 0) return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int N = 18;
            for (int i = 5; i <= N; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
