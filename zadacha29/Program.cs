int[] Array = GetArray(8);
Console.WriteLine($"[{string.Join(";", Array)}]");

int[] GetArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(1, 15);
    }
    return Array;
}
