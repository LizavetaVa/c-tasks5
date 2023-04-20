// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int row = ReadNumberFromConsole("Введите количество строк: ");
int column = ReadNumberFromConsole("Введите количество столбцов: ");
int rowEl = ReadNumberFromConsole("Введите позицию стоки искомого элемента: ");
int columnEl = ReadNumberFromConsole("Введите позицию столбца искомого элемента: ");

int[,] nums = MassNums(row, column);
Print(nums);
FindArr(nums, rowEl, columnEl);


int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(-9, 10);
    return arr;
}

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j],4} ");
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

void FindArr(int[,] arr, int rowEl, int columnEl)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == rowEl - 1 && j == columnEl - 1)
            {
                Console.WriteLine($"Этот элемент равен: {arr[i, j]}");
                return;
            }
            else if (rowEl > arr.GetLength(0) || columnEl > arr.GetLength(1) || rowEl == 0 || columnEl == 0)
            {
                Console.WriteLine("Такого элемента в массиве нет!");
                return;
            }
        }
    }
}