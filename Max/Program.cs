using System;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Введите первое число");
            a=Convert.ToInt32 (Console.ReadLine());
             Console.WriteLine("Введите второе число");
            b=Convert.ToInt32 (Console.ReadLine());
             Console.WriteLine("Введите третье число");
            c=Convert.ToInt32 (Console.ReadLine());
            if (a>b&&a>c)
            {
                Console.WriteLine("Первое число -самое большое");
            }
            if (b>a&&b>c)
            {
                Console.WriteLine("Второе число -самое большое");
            }
            else
            {
                Console.WriteLine("Третье число-самое большое");
            }
        }
    }
}
