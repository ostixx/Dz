using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Введите длину 1 отрезка");
            a=Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Введите длину второго");
             b=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введите длину третего");
             c=Convert.ToInt32(Console.ReadLine());
             if (c>a&& c>b)
             {
                 Console.WriteLine("Третья сторона - самая большая");
                 if(a+b>c)
                 {
                     Console.WriteLine("Треугольник создать можно");
                 }
                 else
                 {
                     Console.WriteLine("Треугольник создать невозможно");
                 }
             }
              if (b>a&& b>c)
             {
                 Console.WriteLine("Вторая сторона - самая большая");
                 if(a+c>b)
                 {
                     Console.WriteLine("Треугольник создать можно");
                 }
                 else
                 {
                     Console.WriteLine("Треугольник создать невозможно");
                 }
             }
              if (a>b&& a>c)
             {
                 Console.WriteLine(" Первая сторона - самая большая");
                 if(c+b>a)
                 {
                     Console.WriteLine("Треугольник создать можно");
                 }
                 else
                 {
                     Console.WriteLine("Треугольник создать невозможно");
                 }
             }
        }
    }
} 

             



             