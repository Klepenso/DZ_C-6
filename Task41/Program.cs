﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите элементы(через пробел): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int count = arr.Count(x => x > 0);
        Console.WriteLine($"Кол-во элементов > 0: {count}");
    }
}