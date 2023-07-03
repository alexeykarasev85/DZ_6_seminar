// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[numbers];

void massive(int numbers)
{
    for (int i = 0; i < numbers; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
massive(numbers);


int SumArray(int[] array)
{
    int i = 0;
    int sum = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
            sum = sum + 1;
        i = i + 1;
    }
    return sum;
}

Console.Write($"Чисел больше нуля: {SumArray(Array)}");


