// Ввести с клавиатуры M чисел. Вывести количество чисел больше 0.

int GetNumber()
{
    Console.WriteLine("Введите число M :");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write($"Число {i + 1} = ");
        matr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void CountPositive(int[] matr)
{
    int count = 0;
    for (int i = 0; i < matr.Length; i++)
    {
        if (matr[i] > 0) count++;
    }
    Console.WriteLine($"Количество чисел больше 0 = {count}");
}

int number = GetNumber();
int[] massive = CreateArray(number);
Console.WriteLine();
FillArray(massive);
Console.WriteLine();
CountPositive(massive);
