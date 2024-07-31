// Напишите программу, которая выводит третью с 
// конца цифру заданного числа или сообщает, что 
// третьей цифры нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99) {
    Console.WriteLine(number % 1000 / 100);
}
else {
    System.Console.WriteLine("Третьей цифры нет!");
}