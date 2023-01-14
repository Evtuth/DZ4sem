// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число, которое вы хотите добавить в массив: ");
        int A = Convert.ToInt32(Console.ReadLine());
        array[i] = A;
    }
    return array;
}

int[] array1 = new int[8];
array1 = FillArray(array1);

for(int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }