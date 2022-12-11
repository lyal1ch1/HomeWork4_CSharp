//Задача № 25
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("В какую степень возвести?");
int Pow = int.Parse(Console.ReadLine()!);
int result = 1;
int Power()
{   

    if (Pow == 0)
    {
      result = 1;  
    }
    for (int i = 0; i < Pow; i++)
    {
        result = num * result ;
    }

    return result;
}

Console.WriteLine("Результат:" + Power() );

