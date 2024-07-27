// Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли первое число 
// кратным второму. Если первое число некратно 
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

System.Console.Write("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

if (firstValue % secondValue == 0) {
    System.Console.WriteLine($"{firstValue}, {secondValue} => Yes");
}
else {
    System.Console.WriteLine($"{firstValue}, {secondValue} => No, {firstValue % secondValue}");
}