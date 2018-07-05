using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            char c;
            Console.WriteLine("Введите первое число");
            a=Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Введите второе число");
             b=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("+ - * / %");
             c=Convert.ToChar (Console.ReadLine());
             if( c=='+')
             { 
                 Console.WriteLine (a+b);
             }
              if( c=='-')
             { 
                 Console.WriteLine (a-b);
             }
              if( c=='*')
             { 
                 Console.WriteLine (a*b);
             }
              if( c=='/')
             { 
                 Console.WriteLine (a/b);
             }
              if( b==0 && c=='/')
             { 
                 Console.WriteLine ("Тебя не учили что на 0 делить нельзя?  :D ");
             }
              
              if( c=='%')
             { 
                 Console.WriteLine (a%b);
             }

                 
             




        }
    }
}
