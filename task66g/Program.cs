// Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.Clear();

int Recursion(int N, int M)
{
    int sum = 0;
    if (N == M) return N;
    else
    {

        return sum = N + Recursion(N + 1, M);

    }

}
Console.WriteLine("введите число от");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число до  ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Сумма натуральных элементов:");
Console.WriteLine(Recursion(N, M));
