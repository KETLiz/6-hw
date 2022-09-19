// See https://aka.ms/new-console-template for more information
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите число, соответствующее количеству чисел, которые Вы введете: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

void CreateArray(int size)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число под номером {i+1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int size)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine(arr[i]);
    }
}

int PositiveNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += 1;
        else sum = 0;
    }
    return sum;
}

CreateArray(n);
PrintArray(n);
int result = PositiveNumbers(arr);
Console.WriteLine(result);