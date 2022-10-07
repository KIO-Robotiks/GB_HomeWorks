// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

string Palindrom(int number_5)
{
    string palindrom;

    if (number_5 < 10000 || number_5 > 99999) palindrom = "не 5-значное число!";
    else
    {
        if (number_5/1000 == ((number_5%100)%10*10+(number_5%100)/10)) palindrom = "палиндром";
    else palindrom = "не палиндром";
    }

    return palindrom;
}

Console.WriteLine("Задача 19. Определяет является ли 5-значное число палиндромом.");
Console.WriteLine("Введите 5-значное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {number} это {Palindrom(number)}");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance_3D(double x1,double y1,double z1,double x2,double y2,double z2)
{
    double katet_1 = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((z2-z1),2));
    double katet_2 = y2-y1;

    double distance_3D = Math.Sqrt(Math.Pow(katet_1,2)+Math.Pow(katet_2,2));

    return Math.Round(distance_3D, 2);
}

Console.WriteLine("Задача 21. Находит расстояние в 3D пространстве.");
Console.WriteLine("Введите координату X первой точки:");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки:");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки:");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки:");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки:");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки:");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Растояние между точками равно {Distance_3D(x1,y1,z1,x2,y2,z2)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void TableCubes(int N)
{
    int count = 1;
    while(count<=N)
    {
        Console.Write(count+"  |  ");
        Console.WriteLine(Math.Pow(count,3));
        count++;
    }
}

Console.WriteLine("Задача 23. Выдаёт таблицу кубов от 1 до N.");
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
TableCubes(N);