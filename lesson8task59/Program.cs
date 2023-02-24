// Задача 59: Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива

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

int[] MinElementToArray2D(int[,] array)
{
    
    int min = array[0, 0];
    int minRow = 0;
    int minCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                minRow = i;
                minCol = j;
            }

        }
    }
    return new int[] { minRow, minCol };
}

int[,] DelArray(int[,] array, int[] minIndexis)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int col = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minIndexis[0]) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j != minIndexis[1])
            {
                result[row, col] = array[i, j];
                col++;
            }

        }
        row++;
        col = 0;

    }
    return result;
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col, -10, 10);
PrintArray(array);
Console.WriteLine();
int[] minIndexis = MinElementToArray2D(array);
int[,] Result = DelArray(array, minIndexis);
PrintArray(Result);