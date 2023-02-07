//Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int s = 0;
int b = 2;

while (b <= a)
{
    s = b * b * b;
    b = b + 2;
    Console.Write($"{s}, ");
}

