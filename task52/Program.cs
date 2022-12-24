// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FindAverage(int [,] array)
{
    float summa = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                 summa = summa + array[i, j];
            }
            Console.Write(summa / (array.GetLength(0) ) + " ; ");
            summa = 0;
        }
    }
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j]);
        }
     Console.WriteLine();  
    }
}
int [,] FillArray(int rows, int columns, int begin, int end)
{
    int [,] arr = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            arr[i,j] = new Random().Next(begin, end);
        }
    }
    return arr;
}
int [,] array = FillArray(3, 3, 0, 9);
PrintArray(array);
FindAverage(array);