// Задача №47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0


double[,] array = new double[3, 4];

for (int i = 0; i < array.GetLength(0); i++)

{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double number = new Random().Next(-10,10) + new Random().NextDouble();
        number = Math.Round (number, 3);
        array [i,j] = number;
         Console.Write(array[i,j] + ", ");
    
    }
    Console.WriteLine();
}
// arr[i, j] =Convert.ToSingle(linesCount);
// arr[i, j] =Convert.ToSingle(columnsCount);

// float result;
// int m =3;
// int n = 4;
// result = Convert.ToSingle(m);
// Console.WriteLine();

