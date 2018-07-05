using System;

namespace Rating
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число от 0 до 100");
            a=Convert.ToInt32 (Console.ReadLine());

            if (a>=90)
            {
                Console.WriteLine("Отлично");
            }
            if (a>=75)
            {
                Console.WriteLine("Хорошо");
            }
            if (a>=65)
            {
                Console.WriteLine("Нормально");
            }
            if (a>=60)
            {
                Console.WriteLine("Засчитан");
            }
            if (a<60)
            {
                Console.WriteLine("Не принят");
            }
        }
    }
}
