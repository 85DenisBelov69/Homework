Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

int b = 1;

while (b <= a)
{
    if (b%2 == 0)
    Console.WriteLine($"{b}");
    b++;
    
}
