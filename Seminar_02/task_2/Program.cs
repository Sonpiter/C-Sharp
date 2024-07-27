// Напишите программу, которая принимает на вход
// трехзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000) {
    int middleDigit = number / 10 % 10;
    int rightDigit = number % 10;
    int power = 1;
    
    for( ; rightDigit > 0; rightDigit--) {
        power *= middleDigit;
    }
    
    System.Console.WriteLine(power);     
}
else {
    Console.WriteLine("Число не трехзначное!");
}