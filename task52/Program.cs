// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int row = ReadNumberFromConsole("Введите чисто строк: ");
int column = ReadNumberFromConsole("Введите чисто колон: ");

int[,] array = MassNums(row, column);
Print(array);
double[] array2 = ArifmMean(array);
Print2(array2);


int[,] MassNums(int row, int column)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(-9, 10);
    return array;
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" {array[i, j], 4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Print2(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i], 4} ");
    }
    Console.WriteLine();
}

int ReadNumberFromConsole(string message = "")
{
    if (message != "")
        Console.WriteLine(message);
    string input = Console.ReadLine();
    return int.Parse(input);
}

double[] ArifmMean(int[,] array)
{
    double[] array2 = new double[array.GetLength(1)];
    double sum = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        } 
        sum = sum / array.GetLength(0);
        array2[j] = Math.Round(sum, 1);
        sum = 0;
        
    }
    return array2;
}