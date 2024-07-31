﻿// Напишите программу, которая принимает на 
// вход трехзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000) {
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int result = leftDigit * 10 + rightDigit;
    System.Console.WriteLine(result);     
}
else {
    Console.WriteLine("Число не трехзначное!");
}