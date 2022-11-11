int RecurseShowNatural(int N)
{
    if (N == 1) return 1;
    else
    {
        System.Console.Write(N+", ");
        return RecurseShowNatural(N - 1);
    }
}

int SumNumbers(int M, int N)
{
    if (M == N) return M;
    if (N < M) return 0;
    else
    {
        return M + N + SumNumbers(M + 1, N - 1);
    }
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return m;
}

void Task64()
{
    // Задача 64: Задайте значение N.
    // Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
    // Выполнить с помощью рекурсии.

    // N = 5 -> "5, 4, 3, 2, 1"
    // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

    Console.Clear();

    Console.WriteLine("Задача 64. Выводит рекурсией натуральные числа от N до 1.");
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Натуральные числа от {N} до 1.");
    System.Console.WriteLine(RecurseShowNatural(N));
}

void Task66()
{
    // Задача 66: Задайте значения M и N.
    // Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    // M = 1; N = 15 -> 120
    // M = 4; N = 8. -> 30

    Console.Clear();

    Console.WriteLine("Задача 66. Находит сумму чисел от M до N.");
    Console.Write("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Сумма натуральных чисел от {M} до {N} = ");
    System.Console.WriteLine(SumNumbers(M, N));
}

void Task68()
{
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
    // Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29

    Console.Clear();

    Console.WriteLine("Задача 68. Вычисляет функцию Аккермана.");
    Console.Write("Введите число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"A({m}, {n}) = ");
    System.Console.WriteLine(AkkermanFunction(m, n));
}

// Run HomeWork Menu:
while (true)
{
    Console.Clear();
    Console.WriteLine("     < Домашнее задание к Семинару №9 >");
    Console.Write("Введите номер задачи (64, 66, 68) или введите q для выхода: ");
    string num = Console.ReadLine();

    if (num == "q")
    {
        System.Console.WriteLine("До встречи!");
        break;
    }
    else if (num == "64") Task64();
    else if (num == "66") Task66();
    else if (num == "68") Task68();
    else continue;

    Console.WriteLine("Для продолжения нажмите Enter.");
    Console.ReadLine();
}