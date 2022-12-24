// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray(double [,] arr)
{
    for( int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " "); 
        }
        Console.WriteLine();
    }
}

double [,] FillArray(int rows, int columns, int begin, int end)
{
    double [,] arr = new double[rows, columns];
    for( int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            arr [i, j] = Convert.ToDouble(new Random().Next(begin, end))/10; 
        }
    }
    return arr;
} 

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
double [,] array  = FillArray(rows, columns, -100, 100);
PrintArray(array);
