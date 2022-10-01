string[] array = new string[5] {"123", "456", "789", "hello", "world"};
string[] array1 = new string[array.Length];
void SecondArrayWithIF(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array1[count] = array1[i];
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