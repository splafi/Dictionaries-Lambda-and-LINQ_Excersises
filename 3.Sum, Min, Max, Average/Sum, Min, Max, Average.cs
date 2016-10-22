using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double[] nums = new double[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = double.Parse(Console.ReadLine());
            }
            var sum = nums.Sum();
            var min = nums.Min();
            var max = nums.Max();
            var avarege = nums.Average();
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {avarege}");
        }
    }
}
