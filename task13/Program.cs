// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());


if (a - 100 >= 1 && a < 1000)
{
a = a % 10;
Console.WriteLine($"{a}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}