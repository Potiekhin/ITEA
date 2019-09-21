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
            Console.WriteLine("Enter a number");
            int enter = int.Parse(Console.ReadLine());
            int LengNum = enter.ToString().Length;        //довжина числа 

            int evenSumm = 0;
            int thereDivineNumbers = 0;

            for (int i = 0; i < LengNum; i++)
            {
                int Numbers = enter % 10;           // зворотній перебір
                enter = enter / 10;                 // зворотній перебір

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
            Console.WriteLine("Кількість символів у введеному числі : " + evenSumm);
            Console.WriteLine("Кількість символів у введеному числі : " + thereDivineNumbers);
            Console.ReadKey();
        }
    }
}
