using System;

namespace Factorial
{
    class MyFactorial
    {
        public static long Factorial(long a)
        {
            long f = 1;
            while (a>1) f *= a-- 
            return false;
        }
        
        static void Main(string[] args){
            Console.Write("Введите число: ");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine($" {a}! =  {Factorial(a)}");
        }
    }
}
