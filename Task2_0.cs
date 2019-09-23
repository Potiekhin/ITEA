using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14ton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть ціле число");
            int enter = int.Parse(Console.ReadLine());
            int LengNum = enter.ToString().Length;

            int evenSumm = 0;
            int thereDivineNumbers = 0;

            for (int i = 0; i < LengNum; i++)
            {
                int Numbers = enter / 10 * 10;
                Numbers = enter - Numbers;
                enter = enter / 10;

                if (Numbers % 2 == 0)
                {
                    evenSumm += Numbers;
                }

                if (Numbers % 3 == 0)
                {
                    thereDivineNumbers++;
                }

            }

            Console.WriteLine("Кількість символів у введеному числі : " + LengNum);
            Console.WriteLine("Сумма парних чисел : " + evenSumm);
            Console.WriteLine("Кількість цифр кратних 3 : " + thereDivineNumbers);
            Console.ReadKey();
        }
    }
}
