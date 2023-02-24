//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.

Console.Clear();



void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"####### DEFAULT MATRIX #######");
int[,] array = GetArray(row, col, 0, 9);
PrintArray(array);

int[] myArray = new int[16];
int z = 0;
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
        myArray[z] = array[i, j];
        z++;
    }

for (int i = 0; i < myArray.Length; i++) { }
int[] result = myArray.OrderBy(i => i).ToArray();
for (int i = 0; i < result.Length; i++) { }

Console.WriteLine($"####### SORTED MATRIX #######");

int[,] sortMyMatrix = new int[4, 4];
int k = 0;
for (int i = 0; i < sortMyMatrix.GetLength(0); i++)
{
    for (int j = 0; j < sortMyMatrix.GetLength(1); j++)
    {
        sortMyMatrix[i, j] = result[k];
        Console.Write($"{sortMyMatrix[i, j]}\t");
        k++;
    }
    Console.WriteLine($"\n");
}

