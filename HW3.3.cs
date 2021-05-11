using System;

namespace HW3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("«Морской бой»: Х — элементы кораблей, О — свободные клетки");

            char[,] map = new char[10, 10];

            var rand = new Random();

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    map[i, j] = rand.Next(20) < 2 ? 'X' : 'O';

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(map[i, j].ToString() + ' ');
                }
                Console.WriteLine();
            }
        }
    }
}
