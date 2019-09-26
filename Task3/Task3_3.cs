using System;

namespace Task3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ch = new char[10];
            char dog = '@';
            char mine = '*';
            char health = '+';
            char space = '_';
            int indexDogPosition = 0;
            int life = 100;
            Random rand = new Random();
            int mineIndex = rand.Next(1, 9);
            int healthIndex = rand.Next(1, 9);

            
            if (healthIndex == indexDogPosition)
            {
                life = life + 40;
            }
            if (mineIndex== healthIndex)
            {
                healthIndex = rand.Next(1, mineIndex - 1);
                
            }
            Console.Write("\n \tLIFE=" + life + "\n");
            for (int i = 0; i < ch.Length; i++)     //Заливає в массив -_ 
            {
                ch[i] = Convert.ToChar("_");
                ch[indexDogPosition] = dog;
                ch[mineIndex] = mine;
                ch[healthIndex] = health;
            }
            for (int i = 0; i < ch.Length; i++)     //Виводить на консоль результат
            {
                string s = Convert.ToString(ch);
                Console.Write("\t" + ch[i] + " ");
            }
            while (true)
            {
                string key = Console.ReadLine();
                if (key == "d" && indexDogPosition < 9)
                {
                    Console.Clear();
                    Console.Write("\n \tLIFE=" + (life-5) + "\n");
                    life = life - 5;
                    indexDogPosition++;
                    ch[indexDogPosition] = dog;
                    ch[indexDogPosition - 1] = space;
                    if (mineIndex == indexDogPosition)
                    {
                        Console.Clear();
                        Console.Write("\n \tLIFE=" + (life - 40) + "\n");
                        life = life - 40;
                        mineIndex = -1;
                    }
                    else if (healthIndex == indexDogPosition)
                    {
                        Console.Clear();
                        Console.Write("\n \tLIFE=" + (life + 40) + "\n");
                        life = life + 40;
                        healthIndex = -1;
                    }
                    else if (life <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("YOU LOSE");
                        break;
                    }
                    for (int i = 0; i < ch.Length; i++)     //Виводить на консоль результат
                    {
                        string s = Convert.ToString(ch);
                        Console.Write("\t" + ch[i] + " ");
                    }
                }
                else if (key == "a" && indexDogPosition > 0)
                {
                    Console.Clear();
                    Console.Write("\n \tLIFE=" + (life - 5) + "\n");
                    life = life - 5;
                    indexDogPosition--;
                    ch[indexDogPosition] = dog;
                    ch[indexDogPosition + 1] = space;
                    for (int i = 0; i < ch.Length; i++)     //Виводить на консоль результат
                    {
                        string s = Convert.ToString(ch);
                        Console.Write("\t" + ch[i] + " ");
                    }
                    if (life <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("YOU LOSE");
                        break;
                    }
                }
                else if (indexDogPosition >= 9)
                {
                    Console.Clear();
                    Console.WriteLine("YOU WIN");
                    break;
                }
                
                else
                    Console.WriteLine("WRONG MOVE");
            }
            Console.ReadKey();
        }
    }
}
