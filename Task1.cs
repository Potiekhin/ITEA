using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double checkSumm = 337.77;
            /*
            double discount = 0;
            
            if (checkSumm <= 300)
            {
                
                Console.WriteLine($"Сумма до сплати - {checkSumm - discount}\nВаша знижка - {discount}");
            }
            else if (checkSumm > 300 && checkSumm <= 400)
            {
                discount = checkSumm * 0.02;
                Console.WriteLine($"Сумма до сплати - {checkSumm - discount}\nВаша знижка - {discount}");
            }
            else if (checkSumm > 400 && checkSumm < 500)
            {
                discount = checkSumm * 0.03;
                Console.WriteLine($"Сумма до сплати - {checkSumm - discount}\nВаша знижка - {discount}");
            }
            else if (checkSumm >= 500)
            {
                discount = checkSumm * 0.05;
                Console.WriteLine($"Сумма до сплати - {checkSumm - discount}\nВаша знижка - {discount}");
            }
            Console.ReadKey();
            */

            double discount =
                checkSumm <= 300 ? 0 : 
                checkSumm > 300 && checkSumm <= 400 ? checkSumm * 0.02 : 
                checkSumm > 400 && checkSumm < 500 ? checkSumm * 0.03 : 
                checkSumm * 0.05;

            discount = Math.Round(discount, 2);

            Console.WriteLine($"Сумма до сплати - {checkSumm - discount}\nВаша знижка - {discount}");
            Console.ReadKey();
        }
    }
}
