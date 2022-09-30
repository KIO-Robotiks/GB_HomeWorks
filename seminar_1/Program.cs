// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Задача 2. Находит максимальное число из двух.");
Console.WriteLine("Ввведите 2 числа:");
try
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        if (a>b)
        {
            Console.WriteLine("max = "+a);
        }
        else
        {
            Console.WriteLine("max = "+b);
        }
    }
    catch (Exception)
    {
        Console.WriteLine("некорректный ввод.");
    }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задача 4. Находит максимальное число из трёх.");
Console.WriteLine("Ввведите 3 числа:");
try
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int max = a;
        if (b>max)
        {
            max = b;
        }
        if (c>max)
        {
            max = c;
        }
        Console.WriteLine("max = "+max);
    }
    catch (Exception)
    {
        Console.WriteLine("некорректный ввод.");
    }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Задача 6. Понимает чётное ли число.");
Console.WriteLine("Ввведите число:");
try
    {
        int a = Convert.ToInt32(Console.ReadLine());
        if (a%2==0)
        {
            Console.WriteLine("Да. Число чётное.");
        }
        else
        {
            Console.WriteLine("Нет. Число не чётное.");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("некорректный ввод.");
    }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Задача 8. Выводит все чётные числа от 1 до N");
Console.WriteLine("Ввведите число N:");
try
    {
        int N = Convert.ToInt32(Console.ReadLine());
        if(N<0)
        {
            N = -N;
            Console.WriteLine("Вероятно вы имели в виду "+N);
        }
        if(N<2)
        {
            Console.WriteLine("Чётных чисел от 1 до этого числа нет :(");
        }
        int count = 1;

        while(count<=N)
        {
            if(count%2==0)
            {
                Console.Write("/"+count);
            }
            count++;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("некорректный ввод.");
    }
