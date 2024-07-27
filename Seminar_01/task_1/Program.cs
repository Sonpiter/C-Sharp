﻿// Напишите программу, которая на вход 
// принимает два целых числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 => да 
// a = 2, b = 10 => нет 
// a = 9, b = -3 => да 
// a = -3, b = 9 => нет

Console.Write("Введите первое значение: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе значение: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue == secondValue * secondValue) {
    Console.WriteLine("a = " + firstValue + ", b = " + secondValue + " => Yes");
}
else {
    Console.WriteLine($"a = {firstValue}, b = {secondValue} => No");
}