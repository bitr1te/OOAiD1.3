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
            ОпределениеТипаДимы();
        }

        static void ОпределениеТипаДимы()
        {
            int i = 0;
            string[] DimaArray = new string { "Нуб", "Про", "Перекач", "Нафидил", "В муте" };
            bool otvet = false;
            while (choslo > 4 || choslo < 0)
            {
                Console.WriteLine("Введите число: ");
                int choslo = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < DimaArray.Length; i++)
            {
                if (choslo == DimaArray[i])
                {
                    Console.WriteLine("Дима = " + DimaArray[i]);
                    break;
                }
            }
        }
    }
}