//Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int s = 1;

int b = 1;

while (b <=  a)
{
    s = s * b;
    b++;
  
}
Console.WriteLine($"{s}"); 