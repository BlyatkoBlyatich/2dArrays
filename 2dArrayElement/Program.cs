// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.0

int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // интересны габариты массива
{
    int [,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void ShowArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++) // определили внешний параметр
    {
        for(int j = 0; j < array.GetLength(1); j++) // определили внутренний параметр
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void IsArrayElement(int pos1, int pos2, int [,] array)
{
    if(pos1 < array.GetLength(0) && pos2 < array.GetLength(1))
    {
        Console.Write($"{array[pos1, pos2]}");
    }
    else
    {
        Console.Write("There are no numbers in array!");
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximum possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input position 1: ");
int pos1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input position 2: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2dArray(m, n, min, max);
ShowArray(array);
IsArrayElement(pos1, pos2, array);