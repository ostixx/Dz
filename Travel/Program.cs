using System;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string b;   
            Console.WriteLine("Введите расстояние ");
            Console.WriteLine("Солнечно или дождь?");

            a=Convert.ToInt32 (Console.ReadLine());
            b=Console.ReadLine();


            if (a<10&&b=="Солнечно")
            {
                Console.WriteLine(" Вам не нужен транспорт");
            }
            if (a<40&&a>10&&b=="Солнечно")
            {
                Console.WriteLine("Вам нужен байк");
            }
            if (a<400&&a>40&&b=="Солнечно")
            {
                Console.WriteLine("Вам нужна машина");
            }
            if (a<900&&a>400&&b=="Солнечно")
            {
                Console.WriteLine("Вам нужен самолет или поезд");
            }
            if (a>40&&b=="дождь")
            {
                Console.WriteLine("Вам нужна машина");
                Console.WriteLine("Будьте осторожны !!!");
            }
            if (a<40&&b=="дождь")
            {
                Console.WriteLine("Вам не нужен транспорт");
                Console.WriteLine("Будьте осторожны !!!");
            }
            
        }
    }
}
