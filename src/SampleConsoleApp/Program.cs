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
            var mathLit = new MathLit();
            Console.WriteLine(mathLit.ShowCalculation(2, 2));
            Console.WriteLine(mathLit.ShowCalculation(2, 3));
            Console.WriteLine(mathLit.ShowCalculation(2, 4));
        }

        private class MathLit
        {
            private int _one;
            private int _two;

            private int Multiply(int one, int two)
            {
                _one = one;
                _two = two;
                return _one + _two;
            }

            public string ShowCalculation(int one, int two)
            {
                _one = one;
                _two = two;
                return string.Format("{0} * {1} = {2}", _one, _two, Multiply(_one, _two));
            }
        }
    }
}
