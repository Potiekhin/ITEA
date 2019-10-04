using System;
namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int arrayLenght = 10;
            char space = '_';

            char dog = '@';
            int dogIndexI = 0;
            int dogIndexJ = 0;

            char mine = '*';
            char health = '+';
            int mineIndex = 0;
            int healthIndex = 0;


            int life = 100;

            char[][] area = new char[arrayLenght][];


            for (int i = 0; i < area.Length; i++)       //створює внутрішні масиви массиви
            {
                area[i] = new char[arrayLenght];            //заповнює масиви чаром _
                for (int j = 0; j < area.Length; j++)
                {
                    area[i][j] = space;
                }
            }

            area[dogIndexI][dogIndexJ] = dog; //позиція собаки

            for (int i = 0; i < area.Length; i++)
            {
                if (i == 0)
                {
                    mineIndex = random.Next(1, 9);
                    healthIndex = random.Next(1, 9);
                    while (mineIndex == healthIndex)
                        healthIndex = random.Next(1, 9);
                }
                else
                {
                    mineIndex = random.Next(0, 9);
                    healthIndex = random.Next(0, 9);
                    while (mineIndex == healthIndex)
                        healthIndex = random.Next(0, 9);
                }
                area[i][mineIndex] = mine;
                area[i][healthIndex] = health;
            } // індекси * і +

            Console.WriteLine("LIFE = " + life);

            for (int i = 0; i < area.Length; i++)       //вивід на консоль
            {
                for (int j = 0; j < area.Length; j++)
                {
                    Console.Write(area[i][j] + "  ");
                }
                Console.WriteLine();
            }
            while (true)                    //логіка руху собаки
            {
                string key = Console.ReadLine();

                if (key == "d")
                {
                    life -= 5;
                    dogIndexJ++;
                    Console.WriteLine("\n" + area[0][healthIndex]);
                    area[dogIndexI][dogIndexJ - 1] = space; // рух собаки по колу
                    if (dogIndexJ > 9)
                        dogIndexJ = 0;

                    if (area[dogIndexI][dogIndexJ] == Convert.ToChar(health)) life += 40;
                    if (area[dogIndexI][dogIndexJ] == Convert.ToChar(mine)) life -= 40;

                    Console.Clear();
                    Console.WriteLine("First massive 5 el " + area[0][1]);
                    Console.WriteLine("\n" + healthIndex);
                    Console.WriteLine("LIFE = " + life);
                    if (life <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("YOU LOOOOOOOOOOOOSE!!! /n YOUR LIFE IS : " + life);
                        break;
                    }

                    area[dogIndexI][dogIndexJ] = dog; //позиція собаки

                    for (int i = 0; i < area.Length; i++)       //вивід на консоль
                    {
                        for (int j = 0; j < area.Length; j++)
                        {
                            Console.Write(area[i][j] + "  ");
                        }
                        Console.WriteLine();
                    }
                }

                if (key == "a")
                {
                    life -= 5;
                    dogIndexJ--;

                    area[dogIndexI][dogIndexJ + 1] = space; // рух собаки по колу
                    if (dogIndexJ < 0)
                        dogIndexJ = 9;

                    if (area[dogIndexI][dogIndexJ] == Convert.ToChar(health)) life += 40;
                    if (area[dogIndexI][dogIndexJ] == Convert.ToChar(mine)) life -= 40;

                    Console.Clear();
                    Console.WriteLine("LIFE = " + life);
                    if (life <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("YOU LOOOOOOOOOOOOSE!!! /n YOUR LIFE IS : " + life);
                        break;
                    }

                    area[dogIndexI][dogIndexJ] = dog; //позиція собаки

                    for (int i = 0; i < area.Length; i++)       //вивід на консоль
                    {
                        for (int j = 0; j < area.Length; j++)
                        {
                            Console.Write(area[i][j] + "  ");
                        }
                        Console.WriteLine();
                    }
                }

                if (key == "s")
                {
                    life -= 5;
                    dogIndexI++;

                    area[dogIndexI - 1][dogIndexJ] = space; // рух собаки по колу
                    if (dogIndexI > 9)
                        dogIndexI = 0;
                    if (area[dogIndexI][dogIndexJ] == Convert.ToChar(health)) life += 40;
                    if (area[dogIndexI][dogIndexJ] == Convert.ToChar(mine)) life -= 40;

                    Console.Clear();
                    Console.WriteLine("LIFE = " + life);
                    if (life <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("YOU LOOOOOOOOOOOOSE!!! /n YOUR LIFE IS : " + life);
                        break;
                    }

                    area[dogIndexI][dogIndexJ] = dog; //позиція собаки

                    for (int i = 0; i < area.Length; i++)       //вивід на консоль
                    {
                        for (int j = 0; j < area.Length; j++)
                        {
                            Console.Write(area[i][j] + "  ");
                        }
                        Console.WriteLine();
                    }
                }

                if (key == "w")
                {
                    life -= 5;
                    dogIndexI--;

                    area[dogIndexI + 1][dogIndexJ] = space; // рух собаки по колу
                    if (dogIndexI < 0)
                        dogIndexI = 9;
                    if (area[dogIndexI][dogIndexJ] == Convert.ToChar(health)) life += 40;
                    if (area[dogIndexI][dogIndexJ] == Convert.ToChar(mine)) life -= 40;

                    Console.Clear();
                    Console.WriteLine("LIFE = " + life);
                    if (life <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("YOU LOOOOOOOOOOOOSE!!! /n YOUR LIFE IS : " + life);
                        break;
                    }

                    area[dogIndexI][dogIndexJ] = dog; //позиція собаки

                    for (int i = 0; i < area.Length; i++)       //вивід на консоль
                    {
                        for (int j = 0; j < area.Length; j++)
                        {
                            Console.Write(area[i][j] + "  ");
                        }
                        Console.WriteLine();
                    }
                }
                if (dogIndexI == 9 && dogIndexJ == 9)
                {
                    Console.Clear();
                    Console.WriteLine("YOU WIN!!!!!");
                    Console.ReadKey();
                    break;
                }

            }
        }
    }
}