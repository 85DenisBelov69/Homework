// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

Console.Clear();

void FillArraySpiral(int[,] array, int n)
{
    int i = 0;
    int j = 0;
    int sum = 1;
    for (int a = 0; a < n * n; a++)
    {
        int k = 0;
        do { array[i, j++] = sum++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = sum++;
        for (k = 0; k < n - 1; k++) array[i, j--] = sum++;
        for (k = 0; k < n - 1; k++) array[i--, j] = sum++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
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

Console.Write("Введите количество строк и столбцов: ");
int num = int.Parse(Console.ReadLine()!);
int[,] array1 = new int[num, num];
FillArraySpiral(array1, num);
PrintArray(array1);
