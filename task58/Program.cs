// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.Clear();

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

int[,] multiplication(int[,] array1, int[,] array2)
{
    int[,] FinalArray = new int[array1.GetLength(0), array2.GetLength(1)];
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for ( int j = 0; j < array2.GetLength(1); j++)
            {
                for ( int k = 0; k < array2.GetLength(0); k++)
                {
                    FinalArray[i,j] += array1[i,k] * array2[k,j];
                }
            }
        }
        return FinalArray;

    }
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array1 = GetArray(row, col, 0, 10);
PrintArray(array1);
Console.WriteLine();
Console.Write("Введите кол-во строк: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col2 = int.Parse(Console.ReadLine()!);
int[,] array2 = GetArray(row2, col2, 0, 10);
PrintArray(array2);
int[,] result = multiplication(array1, array2);
Console.WriteLine("итог после умножения");
PrintArray(result);