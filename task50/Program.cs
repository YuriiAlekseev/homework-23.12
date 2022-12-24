// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что 
// такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

string FindElement(int [,] array, int numberrows, int numbercolumns)
{
    string text = "такого числа в массиве НЕТ";
    bool a = true; 
    string nextText = string.Empty;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(i == numberrows - 1 && j == numbercolumns - 1)
                {
                    a = true;
                    nextText = String.Join(" ", array[i, j]);
                }
            } 
    }
    if (a == false)
    {
        return text;
    }
    else 
    {
        return nextText;
    }
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
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

int [,] array = FillArray(8, 7, 0, 9);
PrintArray(array);
int numberrows =  EnterData("Введите номер строки: ");
int numbercolumns = EnterData("Введите номер столбца: ");
string element = FindElement(array, numberrows, numbercolumns);
Console.WriteLine();
Console.WriteLine("Элемент в массиве = " + element);