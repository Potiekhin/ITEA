using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayS = {4, 5, 6};
            int[] arrayL = { 1, 2, 3, 0, 0, 0, 7, 8, 9};
            for (int i = 0; i < arrayS.Length; i++)
            {
                arrayL[i + 3] = arrayS[i];
            }
            for (int i = 0; i < arrayL.Length; i++)
            {
                Console.WriteLine("index [" + i + "] = " + arrayL[i]);
            }
            Console.ReadKey();
        }
    }
}
