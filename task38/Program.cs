// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

Console.Clear();

int[] array = GetArray(6, 0, 100);
Console.WriteLine(String.Join(", ", array));

int min = 100;
int max = 0;
int d = 0;

for (int i = 0; i <= array.Length; i++)
{
   while (i < array.Length) 
{
    if (array[i] > max) 
    {
        max = array[i];   
    }     

    if (array[i] < min)
    {
        min = array[i];      
    }
      i++;
}    
d = (max - min);
}
Console.WriteLine($"dif max/min {d}");



