// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Введите числоA: ");
int volueA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числоB: ");
int volueB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числоC: ");
int volueC = Convert.ToInt32(Console.ReadLine());
int max = volueA;

    if(volueA > max) max = volueA;
    if(volueB > max) max = volueB;
    if(volueC > max) max = volueC;

Console.WriteLine("Маквимально число = " + max); // А есть ключевая разница между записями?
Console.WriteLine($"Маквимально число = {max}"); // А есть ключевая разница между записями?