using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randomNuber = r.Next(0, 100);

            for (int i = 1; i < 6; i++)
            {

                Console.WriteLine($"try №{i} Enter the number between 0 and 100");
                int enter = int.Parse(Console.ReadLine());
                if (enter > randomNuber)
                {
                    Console.WriteLine("NO! Enter Smaller number");
                }
                else if (enter < randomNuber)
                {
                    Console.WriteLine("NO! Enter Biger number");
                }
                else if (enter == randomNuber)
                {
                    Console.WriteLine("YOU WIN!!!");
                    break;
                }
                if (i == 5)
                {
                    Console.WriteLine("SORRY! YOU LOSE!");
                }
            }

            Console.WriteLine(randomNuber);
            Console.ReadKey();


        }
    }
}
