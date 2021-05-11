using System;

namespace HW3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nameBook = { { "Ivan", "Pavel", "Niko", "Ara", "Vasya" }, { "123", "456", "789", "101", "102" }};
            int rows = nameBook.GetUpperBound(0) + 1;
            int columns = nameBook.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{nameBook[i, j]} \t");
                }
                Console.WriteLine();

            }
        }
    }
}
