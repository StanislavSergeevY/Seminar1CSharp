// Задача №2. Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число больше, а какое меньше/

Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
    Console.Write("Число A: " + a + " равно числу B: " + b);
else if(a > b)
    Console.Write("Число A: " + a + " больше числа B: " + b);
else
    Console.Write("Число A: " + a + " меньше числа B: " + b);