Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a / 10000) == (a % 10) || (a / 1000 == a % 100))
{
Console.WriteLine("Это полиндром");
}
else
{
    Console.WriteLine("это не полиндром");
}
