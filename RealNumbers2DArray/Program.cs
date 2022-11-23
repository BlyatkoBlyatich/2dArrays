//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // интересны габариты массива
{
    double [,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 1);
        }
    }
    return array;
}

void ShowArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++) // определили внешний параметр
    {
        for(int j = 0; j < array.GetLength(1); j++) // определили внутренний параметр
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximum possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double [,] array = CreateRandom2dArray(m, n, min, max);
ShowArray(array);
