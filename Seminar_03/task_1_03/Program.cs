﻿// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве. Программа 
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

int[] numbers = {1, 3, 4, 19, 3};

// for(int i = 0; i < numbers.Length; i++) 
// {
//     System.Console.Write(numbers[i] + " ");
// }

foreach(int number in numbers)
{
    Console.Write(number + " ");
}
System.Console.WriteLine();

Console.Write("Введите число: ");

int numberToFind = Convert.ToInt32(Console.ReadLine());

bool numberIsFinded = false;

foreach(int number in numbers)
{
    if(number == numberToFind)
    {
        numberIsFinded = true;
    }
}

if(numberIsFinded)
System.Console.WriteLine("Значение найдено!");
else
System.Console.WriteLine("Значения НЕТ");
