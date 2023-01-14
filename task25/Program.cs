// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int A, int B)
{
    int degree = A;
    if (B == 0)
    {
        degree = 1;
    }
    else
    {
        for (int i = 1; i <= B-1; i++)
        {
            degree *= A;
        }
        
    }
    return degree;
}

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
int degree = Degree(A, B);
Console.WriteLine("Число " + A + " в степени " + B + " равно " + degree);
