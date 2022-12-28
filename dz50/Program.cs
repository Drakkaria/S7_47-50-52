// Задача №50. 
// Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве
//  или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет.


// int[,] arr = new int[2, 3];
//  for (int i = 0; i < arr.GetLength(0); i++)
//  {
//      for (int j = 0; j < arr.GetLength(1); j++)
//      {
//          arr[i, j] = new Random().Next(0, 10);
//      }
//  }
//  for (int i = 0; i < arr.GetLength(0); i++)
//  {
//      for (int j = 0; j < arr.GetLength(1); j++)
//      {
//          Console.Write(arr[i, j] + " ");
//      }
//      Console.WriteLine();
//  }

     

     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 4, 5, -183, 12, 34, 0, 2 ,-13 };

            Console.WriteLine("Исходный массив чисел: ");
            foreach (int x in myArr)
                Console.Write("\t{0}",x);

            // Реализуем сортировку массива
            Console.WriteLine("\n\nОтсортированный массив:");
            Array.Sort(myArr);
            foreach (int x in myArr)
                Console.Write("\t{0}",x);

            // Организуем поиск числа 12
            Console.WriteLine("\n\nПоиск числа:");
            int search = Array.BinarySearch(myArr, 12);
            Console.WriteLine("Число 12 находится на {0} позиции",search+1);

            
        }
    }
}