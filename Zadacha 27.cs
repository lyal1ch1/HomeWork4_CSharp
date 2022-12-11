//Задача № 27

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
num = Math.Abs(num);
int Summa = 0;
int kolCift()
{

    while (num > 9)
    {

        Summa = Summa + num % 10;

        num = num / 10;
    }

    Summa = Summa + num % 10;

    return Summa;
}

Console.WriteLine("Результат:" + kolCift());

