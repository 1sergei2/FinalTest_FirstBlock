Console.Clear();
string[] array = new string[5] {"123", "456", "789", "hello", "world"};
string[] array1 = new string[array.Length];
void SecondArrayWithIF(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array1[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array, array1);
PrintArray(array1);