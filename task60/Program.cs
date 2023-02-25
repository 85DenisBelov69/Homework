//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Напишите программу, которая будет построчно 
//выводить массив, добавляя индексы каждого элемента.


Console.Clear();

int[,,] GetArray(int row, int column, int heigh)
{
    int[,,] result = new int[row, column, heigh];
    int count = 10;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < heigh; k++)
            {
                result[i, j, k] = count++;
            }
        }
    }
     return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}, {i},{j},{k}\t ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите высоту: ");
int height = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,,] array = GetArray(row, col, height);
PrintArray(array);

