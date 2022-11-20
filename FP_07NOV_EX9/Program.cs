using System;
namespace oglinditul
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, p, q, min, max;

            Console.WriteLine("p =");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("q =");
            q = int.Parse(Console.ReadLine());
            
            if (p < q)
            {
                min = p;
                max = q;
            }
            else
            {
                min = q;
                max = p;
            }
            for (i = 1; i <= min; i++)
            {
                if (min % i == 0)
                    if (max % 1 == 0)
                        Console.WriteLine($"{i}");
            }
        }
    }
}