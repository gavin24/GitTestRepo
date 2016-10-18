using System;

namespace SampleConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mathLit = new MathLit();
            Console.WriteLine(mathLit.ShowMultiplication(2, 2));
            Console.WriteLine(mathLit.ShowMultiplication(2, 3));
            Console.WriteLine(mathLit.ShowMultiplication(2, 4));
        }

        private class MathLit
        {
            private static int Multiply(int one, int two)
            {
                return one + two;
            }

            public string ShowMultiplication(int one, int two)
            {
                return string.Format("{0} * {1} = {2}", one, two, Multiply(one, two));
            }
        }
    }
}
