// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//
// 3, 5 -> 243 (3⁵)
//
// 2, 4 -> 16

int Pow(int A, int B)
{   
    int C = A;

    for (int i = 1; i < B; i++)
    {
        C=C*A;
    }
    return C;
}

Console.WriteLine("Задача 25. Возводит A в степень B.");
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} равно {Pow(A,B)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//
// 452 -> 11
//
// 82 -> 10
//
// 9012 -> 12

int SumNum(string num)
{   
    int sum = 0;
    int numLength = num.Length;
    
    for (int i = 0; i < numLength; i++)
    {   
        string number = Convert.ToString(num[i]);
        sum+=Convert.ToInt32(number);
    }

    return sum;
}

Console.WriteLine("Задача 27. Выдаёт сумму цифр в числе.");
Console.Write("Введите число: ");
string num = Console.ReadLine();

Console.WriteLine($"Сумма цифр в числе {num} равнa {SumNum(num)}");


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
//
// m = 5 -> [1, 2, 5, 7, 19]
//
// m = 3 -> [6, 1, 33]

void WriteMass(int size)
{   
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,101);
    }

    for (int i = 0; i < size; i++)
    {   
        if (i<size-1) Console.Write(array[i]+".");
        else Console.Write(array[i]);
    }
    Console.WriteLine();
}

Console.WriteLine("Задача 29. Выводит массив из m элементов.");
Console.Write("Введите число m: ");
int size = Convert.ToInt32(Console.ReadLine());

WriteMass(size);