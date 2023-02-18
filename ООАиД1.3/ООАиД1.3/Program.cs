using System;
namespace ООАиД1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 108;
            int mult = x * y;
            Console.WriteLine("multiplication = " + mult);
            Console.WriteLine("Сань, как дела?");
            Console.WriteLine("Сань, как дела, заебал");
            Console.WriteLine("Че молчишь");
            double Дима;
            Дима = 40; //кг
            while(true)
            {
                try
                {
                    Console.Write("Введите число: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    i %= 5;

                    ОпределениеТипаДимы(i);
                }
                catch
                {
                    break;
                }
            }
        }

        static void ОпределениеТипаДимы(int i)
        {
            string[] DimaArray = new string[] { "Нуб", "Про", "Перекач", "Нафидил", "В муте" };

            Console.WriteLine(DimaArray[i]);
        }
    }
}