using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    class Task_2
    {
        static void Main(string[] args)
        {
            double Money = 2.22;
            double Leffe = 80;
            double Hoegaarden = 70;
            double Stella_Artois = 60;
            double Obolon = 7;

            string answer =
                Money >= Leffe ? $" Your choise Leffe and rest {Money - Leffe}" :
                Money < Leffe && Money >= Hoegaarden ? $" Your choise Hoegaarden and rest {Money - Hoegaarden}" :
                Money < Hoegaarden && Money >= Stella_Artois ? $" Your choise Hoegaarden and rest {Money - Stella_Artois}" :
                Money < Stella_Artois && Money >= Obolon ? $" Your choise Hoegaarden and rest {Money - Obolon}" :
                $"You have only {Money}, Surprise your liver! drink water!!!";
            Console.WriteLine(answer);
            Console.ReadKey();



        }
    }
}
