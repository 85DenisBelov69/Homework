//Напишите программу, 
//которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int s = 0;
int i = 1;
while (i <= a)
{
    s = i * i * i;
    
     i++;

        Console.Write($"{s},  ");
    
}