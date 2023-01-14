Console.WriteLine("Введи число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма числа {number} равна {Getsum(number)}");


int Getsum(int number)
{
    int sum = 0;
    int N = 0;
    while (number != 0)
    {
        N = number % 10;
        sum = sum + N;
        number = number / 10;
    }
    return sum;
}


