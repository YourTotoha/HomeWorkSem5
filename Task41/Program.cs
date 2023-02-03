//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

void CountNumbers(int NumberM)
{
    int CountAbove0 = 0;
    int FirstNumber = GetNum("Введите первое число: ");
    if (FirstNumber > 0)
    {
        CountAbove0 = CountAbove0 + 1;
    }
    for (int i = 1; i < NumberM; i++)
    {
        int NextNumber = GetNum($"Введите {i + 1} число: ");
        if (NextNumber > 0)
        {
            CountAbove0 = CountAbove0 + 1;
        }
    }
    Console.Write($"Количество чисел, которые больше 0 = {CountAbove0}");
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int Number = int.Parse(Console.ReadLine());
    return (Number);
}

Console.WriteLine("Программа работает следующим образом, вы вводите число - количество чисел, которые вы хотите ввести.\nВы по очередности их вводите. В конце опказывается количество чисел больше 0");

int NumberM = GetNum("Введите количество чисел, которые вы хотите ввести M: ");

CountNumbers(NumberM);
