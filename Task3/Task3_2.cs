using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] daysInMonths = new int[12];
            
            for (int i = 0; i < daysInMonths.Length; i++)
            {
                int year = DateTime.Now.Year;
                int month = i+1;
                daysInMonths[i] = DateTime.DaysInMonth(year, month);
                
                Console.WriteLine("Month " + month + " have " + daysInMonths[i] + " days");
            }
            
            
            Console.ReadKey();
        }


    }
}
