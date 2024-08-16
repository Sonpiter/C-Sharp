// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.
// Пример:
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

double[] arr = { 2.2, 0.4, 9.11, 7.2, 78.98 };

double max = arr[0];
double min = arr[-1];

for (double i = 0; i < arr.Length; i++)
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
System.Console.Write(max, min);
// Console.Write($"Массив [ {string.Join(", ", arr)} ] => {countArr}");