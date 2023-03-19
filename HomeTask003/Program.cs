// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число, чтобы узнать является ли оно чётным: ");
int volue = Convert.ToInt32(Console.ReadLine());
bool x = volue%2 == 0;
Console.WriteLine($"{x}!");