// Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23
// a=50 => нет
// a=7 => нет
// a=322 => да


System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0) {
    System.Console.WriteLine($"{number} => Yes");
}
else {
    System.Console.WriteLine($"{number} => No");
}