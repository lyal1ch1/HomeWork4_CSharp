Console.WriteLine("Введите размер массива:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число массива:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число массива:");
int max = int.Parse(Console.ReadLine()!);
int[] array = new int[length];

void FillArray()
{
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray()
{
    for (int i = 0; i < length; i++)
    {
        Console.Write(" " + array[i]);
    }
}
FillArray();
PrintArray();