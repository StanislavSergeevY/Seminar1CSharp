// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число, чтобы узнать содержащиеся в нём чётные числа: ");
int volue = Convert.ToInt32(Console.ReadLine());
Console.Write("Чётные числа, числа: " + volue + " - ");
for (int i = 1; i <= volue; i++)
{
  if (i % 2 == 0)
    if (i < volue)
      if (i + 1 == volue)
        Console.Write($"{i}.");
      else
        Console.Write($"{i}, ");
    else
      Console.Write($"{i}.");
}