﻿// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве.
// Пример:
// массив [6 7 19 34 3 1 4 7 9 1] => 3 
// массив [1 8 43 4 55 60 3 2 1 3] => 4

int[] arr = { 6, 7, 19, 34, 3, 1, 4, 7, 9, 1 };
// int[] arr = { 1, 8, 43, 4, 55, 60, 3, 2, 1, 3 };

int countArr = 0;

for (int i = 0; i < arr.Length; i++)
    if (arr[i] % 2 == 0)
    {
        countArr++;
    }
Console.Write($"Массив [ {string.Join(", ", arr)} ] => {countArr}");
