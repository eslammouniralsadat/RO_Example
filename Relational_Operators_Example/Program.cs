using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relational_Operators_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 15;

            // ----- Start Example ----- \\

            if (x == y)
                Console.WriteLine(" x is equal to y");
            else
                Console.WriteLine(" x is not equal to y");

            // ----------------- \\
            Console.WriteLine("\n====================\n");
            // ----------------- \\

            if (x != y)
                Console.WriteLine(" x is not equal to y");
            else
                Console.WriteLine(" x is  equal to y");

            // ----------------- \\
            Console.WriteLine("\n====================\n");
            // ----------------- \\

            if (x < y)
                Console.WriteLine("x is less than y");
            else
                Console.WriteLine(" x is not less than y");

            // ----------------- \\
            Console.WriteLine("\n====================\n");
            // ----------------- \\

            if (x <= y)
                Console.WriteLine("x is less than y");
            else
                Console.WriteLine(" x is not less than y");

            // ----------------- \\
            Console.WriteLine("\n====================\n");
            // ----------------- \\

            if (x > y)
                Console.WriteLine("x is greater than y");
            else
                Console.WriteLine("x is not greater than y");

            // ----------------- \\
            Console.WriteLine("\n====================\n");
            // ----------------- \\

            if (x >= y)
                Console.WriteLine("x is greater than y");
            else
                Console.WriteLine("x is not greater than y");

            // ----- End Example ----- \\
        }
    }
}
