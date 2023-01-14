Console.WriteLine("Введите число:");
double A = double.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
Console.Write($" {A} в степени {B} -> {Getdegree(A,B)}");

double Getdegree(double A, int B)
{
    double result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;

    }
    return result;
}
