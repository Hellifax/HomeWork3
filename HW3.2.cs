using System;

namespace HW3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            char[] arr = Console.ReadLine().ToCharArray();
            var a = arr.Length;
            Console.WriteLine("Кол-во элементов в массиве: {0}", a);
            Array.Reverse(arr);
            Console.WriteLine(arr);





        }
    }
}
