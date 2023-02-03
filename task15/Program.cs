// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Clear();

Console.WriteLine("Ведите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 5 && a <= 7)
{
    Console.WriteLine("Выходной");
}
else if (a >= 1 && a <= 5)
{
    Console.WriteLine("Будний");
}
else
{
    Console.WriteLine("Неисуществует");
}