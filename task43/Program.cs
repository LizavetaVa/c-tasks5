// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int b1 = ReadNumberFromConsole("Введите первую координату: ");
int k1 = ReadNumberFromConsole("Введите вторую координату: ");
int b2 = ReadNumberFromConsole("Введите третью координату: ");
int k2 = ReadNumberFromConsole("Введите четвертую координату: ");
Intersection(b1, k1, b2, k2);

int ReadNumberFromConsole(string message = "")
{
    if (message != "")
        Console.WriteLine(message);
    string input = Console.ReadLine();
    return int.Parse(input);
}

void Intersection(double b1, double k1, double b2, double k2)
{
    double k = k1 - k2;
    if (k != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Ошибка.");
    else
    Console.WriteLine("Нет точек пересечения.");
}