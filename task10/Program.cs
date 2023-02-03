// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");

int a = Convert.ToInt32(Console.ReadLine());

int b = (a/10 - a / 100 * 10);

Console.WriteLine($"{b}");
