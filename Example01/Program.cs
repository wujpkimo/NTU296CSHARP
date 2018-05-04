using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 5;
            numbers[3] = 7;

            int[] number1s = new int[]
            {
                1,2,3,4,5,6
            };
            Console.WriteLine("陣列的長度是{0}", numbers.Length);
            Console.WriteLine("numbers[3] = {0}", numbers[3]);
            Console.WriteLine("陣列的長度是{0}", number1s.Length);
            Console.WriteLine(number1s[3]);
        }
    }
}