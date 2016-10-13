using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2,2));
        }

        public static int Multiply(int one, int two)
        {
            return one + two;
        }
    }
}
