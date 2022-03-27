void FillArray(int[] collection)
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        collection[i] = new Random().Next();
        i++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    for(int pos = 0; pos < count - 1; pos++)
    {
        Console.Write($"{col[pos]}, ");
    }
    for(int pos = count - 1; pos < count; pos++)
    {
        Console.Write($"{col[pos]} ");
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);


