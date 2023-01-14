// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int A)
{
    int sum = 0;
    while (A > 0)
    {
        sum += A % 10;
        A = A / 10;
    }
    return sum;
}

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = Sum(A);
Console.WriteLine("Сумма цифр числа " + A + " равна " + sum);