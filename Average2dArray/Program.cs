// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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

void MyArray(double [] array)
{
    for(int i = 0; i < array.GetLength(0); i ++) 
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double [] AverageSum(int [,] array)
{
    double [] average = new double[array.GetLength(1)]; //(1) поскольку ср. арифметическое столбцов.
    double sum = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        average[j] = Math.Round(sum / array.GetLength(1), 2);
        sum = 0;
    } 
    return average;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximum possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2dArray(m, n, min, max);
ShowArray(array);
MyArray(AverageSum(array));