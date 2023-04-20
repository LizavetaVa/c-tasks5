// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int m = ReadNumberFromConsole("Введите число строк: ");
int n = ReadNumberFromConsole("Введите число колон: ");

double[,] nums = MassNums(m, n);
Print(nums);

double[,] MassNums(int row, int column)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 1);
    return arr;
}

void Print(double[,] arr)
{
    double row = arr.GetLength(0);
    double column = arr.GetLength(1);
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j], 4} ");
        Console.WriteLine();
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
