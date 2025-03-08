using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIsPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }
        static bool IsPrime(int num)
        {
            if(num<2) return false;
            int i = 2;
            while (i * i >= num)
            {
                if(num%i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}
