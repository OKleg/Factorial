using System;

namespace FactorialNS
{
    public class MyFactorial
    {
        public static long Factorial(long a)
        {
            long f = 1;
            while (a>1) f *= a--; 
            return f;
        }
        
        static void Main(string[] args){
            Console.Write("Введите число: ");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine($" {a}! =  {Factorial(a)}");
        }
    }
}
