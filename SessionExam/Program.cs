// Из имеющегося массива сформировать новый с строками менее 3 символов

Console.Clear();
string[] GetArray = new string[5] { "111", "2", "333", "aaa", "wxwx" };
string[] NewArray = new string[GetArray.Length];

void CountNumbers(string[] GetArray, string[] NewArray)
{
    int count = 0;

    for (int i = 0; i < GetArray.Length; i++)
    {
        if (GetArray[i].Length <= 3)
        {
            NewArray[count] = GetArray[i];

            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

Console.WriteLine(String.Join(", ", GetArray));
CountNumbers(GetArray, NewArray);
Console.WriteLine(" элементы <= 3 символов: ");
PrintArray(NewArray);