using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
             Console.WriteLine("Введите год");
            a=Convert.ToInt32 (Console.ReadLine());
            if (a%4==0)
            {
                Console.WriteLine("Этот год высокосный");

            }
            else
            {
                Console.WriteLine("Этот год не является высокосным");
            }
        }
    }
}
