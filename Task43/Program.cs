//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void EquationIntersection(double NumberB1, double NumberK1, double NumberB2, double NumberK2)
{
    double NumberX = (NumberB1 - NumberB2) * -1 / (NumberK1 - NumberK2);
    double NumberY = NumberK2 * NumberX + NumberB2;
    Console.Write($"Точка пересечения имеет следующие координаты: ({NumberX}, {NumberY})");
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int Number = int.Parse(Console.ReadLine());
    return (Number);
}

int NumberB1 = GetNum("Введите число для b1: ");
int NumberK1 = GetNum("Введите число для k1: ");
int NumberB2 = GetNum("Введите число для b2: ");
int NumberK2 = GetNum("Введите число для k2: ");

EquationIntersection(NumberB1, NumberK1, NumberB2, NumberK2);