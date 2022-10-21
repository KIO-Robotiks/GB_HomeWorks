// Вывод массива дробных чисел в консоль:
void ShowDoubleArray(double[] array)
{   
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        if(i!=array.Length-1)Console.Write(array[i]+",");
        else Console.Write(array[i]);
    }
    Console.Write("}");
    Console.WriteLine();
}


// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void SumOfPozitive(int M)
// {   
//     string number = "";
//     int sum = 0;
//     for (int i = 0; i < M; i++)
//     {
//         number = Console.ReadLine();
//         try
//         {
//             if (Convert.ToInt32(number) > 0) sum++;
//         }
//         catch
//         {
//             Console.WriteLine("Это не число");
//             i--;
//         }
//     }
//     Console.WriteLine($"Кол-во положительных чисел из {M} = {sum}");
// }

// Console.WriteLine("Задача 41. Считает кол-во введённых чисел больше 0.");
// Console.WriteLine("Сколько чисел вы хотите ввести?");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Вводите числа и нажимайте Enter.");
// SumOfPozitive(M);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] GetX(double k1, double b1, double k2, double b2)
{
    double x = Math.Round((b2-b1)/(k1-k2),2);
    double y = Math.Round(k1*x + b1,2);

    return new double[2] {x,y};
}


Console.WriteLine("Задача 43. Находит точку пересечения двух прямых.");
Console.Write("Введите коэф наклона 1й прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите пересечение с Y 1й прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэф наклона 2й прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите пересечение с Y 2й прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] X = GetX(k1, b1, k2, b2);
ShowDoubleArray(X);
