// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

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
void FindElement( int[,] inArray, int Row, int Col)
{
    if (inArray.GetLength(0) > Row && inArray.GetLength(1) > Col)
    Console.WriteLine($"искомое число: {inArray[Row, Col]}");
    else
    Console.WriteLine("такого числа не существует");
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col, -10, 10);
Console.WriteLine("введите номер строки: ");
int Row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("введите номер столбца: ");
int Col = Convert.ToInt32(Console.ReadLine()) - 1;
PrintArray(array);
Console.WriteLine();
FindElement(array, Row, Col);