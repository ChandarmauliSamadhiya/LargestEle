using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestEle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 25, 5, 30, 15 };
            int largest = numbers[0];

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine("Largest element: " + largest);
            Console.ReadLine();
        }
    }
}
