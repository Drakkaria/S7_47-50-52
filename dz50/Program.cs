// Задача №50. 
// Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве
//  или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет.


int[,] arr = new int[2, 3];

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

 for (int i = 0; i < arr.GetLength(0); i++)
 {
     for (int j = 0; j < arr.GetLength(1); j++)
     {
         arr[i, j] = new Random().Next(0, 10);
     }
 }
 for (int i = 0; i < arr.GetLength(0); i++)
 {
     for (int j = 0; j < arr.GetLength(1); j++)
     {
         Console.Write(arr[i, j] + " ");
     }
     Console.WriteLine();
 }
 for (int i = 0; i < arr.GetLength(0); i++)
 {
     for (int j = 0; j < arr.GetLength(1); j++)
     {
         if ( a! == arr.GetLength(0)  );
         if ( a! == arr.GetLength(1)  );
          
     }
     
     
  }
Console.WriteLine("Такого числа нет в массиве!");
