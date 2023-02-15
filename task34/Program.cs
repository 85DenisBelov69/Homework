// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int CountNumbers(int[] array)
{
    int count = 0;
    foreach (int elent in array)
    {
        if (elent % 2 == 0 )
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(5, 100, 999);
Console.WriteLine(String.Join(", ", array));
int count = CountNumbers(array);
Console.WriteLine(count);