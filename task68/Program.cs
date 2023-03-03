// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n


Console.Clear();

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.WriteLine("введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("A(m,n): ");
Console.WriteLine(Ackerman(m, n));