//  Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
// 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

System.Console.Write("Введите координату X : ");
int cor_X = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y : ");
int cor_Y = Convert.ToInt32(Console.ReadLine());

if (cor_X > 0 && cor_Y > 0) {
    System.Console.WriteLine($"{cor_X}, {cor_Y} => '1' четверть");
}
if (cor_X < 0 && cor_Y > 0) {
    System.Console.WriteLine($"{cor_X}, {cor_Y} => '2' четверть");
}
if (cor_X < 0 && cor_Y < 0) {
    System.Console.WriteLine($"{cor_X}, {cor_Y} => '3' четверть");
}
if (cor_X > 0 && cor_Y < 0) {
    System.Console.WriteLine($"{cor_X}, {cor_Y} => '4' четверть");
}