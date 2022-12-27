// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

int[,] array = new int[3,4];
for (int i =0; i <array.GetLength(0); i++)
{
    for(int j =0; j <array.GetLength(1); j++)
    {
    array [i,j] = new Random().Next(0, 10);
     Console.Write(array[i,j] + ", ");
    }
     Console.WriteLine();
}
Console.WriteLine();

for (int i =0; i <array.GetLength(0); i++) 
{
    for(int j =0; j <array.GetLength(1); j++)
    
    {
        if (i==0) 
        {
    Console.Write(array[array.GetLength(0)-1,j] + ", ");
        }
       else if (i==array.GetLength(0)-1)
       {
    Console.Write(array[0,j] + ", ");
       }
    else Console.Write(array[i,j] + ", ");
    } 
    Console.WriteLine();
}
// for (int i =0; i <1; i++)
// {
//     for(int j =0; j <array.GetLength(1); j++)
    
//     {
//     Console.Write(array[1,j] + ", ");
    
//     }
//      Console.WriteLine();
// }
// for (int i =0; i <1; i++)
// {
//     for(int j =0; j <array.GetLength(1); j++)
    
//     {
//     Console.Write(array[0,j] + ", ");
    
//     }
//      Console.WriteLine();
// }
