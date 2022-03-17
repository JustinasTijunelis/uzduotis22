using System;

namespace uzduotis22
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 uzduotis 
            double r = 6371;

            double x = 4 * Math.PI * r;
            Console.WriteLine($"Rutulio pavirsiaus plotas: {x}");

            //2 uzduotis
            double y = (4 / 3) * Math.PI * (r * r * r);
            Console.WriteLine($"Rutulio turis {y}");

            //3 uzduotis
        }
    }
}
