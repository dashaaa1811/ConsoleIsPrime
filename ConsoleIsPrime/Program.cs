using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Определение, является ли число простым
//Структура:
//Входные данные: целое число number.
//Выходные данные: true, если число простое, иначе false.
//Простое число — это число, которое делится только на 1 и на себя (например, 2, 3, 5, 7, 11).

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
