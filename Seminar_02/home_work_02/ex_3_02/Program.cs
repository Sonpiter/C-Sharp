// Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7

Console.Write("Введите число от 10 до 99 включительно: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 9 && number < 100) {
    int leftDigit = number / 10;
    int rightDigit = number % 10;

    if(leftDigit > rightDigit || leftDigit == rightDigit) {
        System.Console.WriteLine($"{number} => наибольшая цифра {leftDigit}");
    }

    if(leftDigit < rightDigit) {
        System.Console.WriteLine($"{number} => наибольшая цифра {rightDigit}");
    }
}

else {
    Console.WriteLine("Введено неверное число!");
}
