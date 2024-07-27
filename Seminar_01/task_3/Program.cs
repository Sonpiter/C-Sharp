// Напишите программу, которая принимает на вход 
// трёхзначное целое число и на выходе показывает сумму 
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (99 < number && number < 1000) {
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int result = leftDigit + rightDigit;
    System.Console.WriteLine(result);
}