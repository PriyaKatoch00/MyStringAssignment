using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStringAssignment
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter first no");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second no");
            y = int.Parse(Console.ReadLine());
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After Swapping x=" + x + "y=" + y);
        }

        }
    }
