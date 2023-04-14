// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int numToPrint = ReadNumberFromConsole("Введите число: ");
int[] array = new int[numToPrint];
Console.WriteLine($"Введите {numToPrint} чисел:");
FillArray(array);
PrintArray(array);
Console.WriteLine($"Вы ввели {PositiveNum(array)} положительных чисел.");


void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine(array[array.Length - 1] + "}");
}

int ReadNumberFromConsole(string message = "")
{
    if (message != "")
        Console.WriteLine(message);
    string input = Console.ReadLine();
    return int.Parse(input);
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
}

int PositiveNum(int[] array)
{
    int count = 0;
    for (int i  = 0; i  <  array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    return count;
}