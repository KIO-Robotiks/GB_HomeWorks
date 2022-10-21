// Генерация 2x-массива из случайных целых чисел:
int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int randomValue = new Random().Next(minValue, maxValue + 1);
            newArray[i, j] = randomValue;
        }
    }
    return newArray;
}

// Генерация 2x-массива из случайных дробных чисел:
double[,] Create2DRandomDoubleArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double randomDoubleValue = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1);
            newArray[i, j] = randomDoubleValue;
        }
    }
    return newArray;
}

// Вывод 2x-массива целых чисел в консоль:
void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Вывод 2x-массива дробных чисел в консоль:
void Show2DDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int lengthValue = Convert.ToString(array[i, j]).Length;

            if (lengthValue == 4) Console.Write(" " + array[i, j]);
            else if (lengthValue == 3) Console.Write("  " + array[i, j]);
            else if (lengthValue == 2) Console.Write(" " + array[i, j] + "  ");
            else if (lengthValue == 1) Console.Write("  " + array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

// Вывод массива дробных чисел в консоль:
void ShowDoubleArray(double[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i]);
    }
    Console.Write("}");
    Console.WriteLine();
}

// Нахождение и вывод хначения элемента массива по его адресу:
void FindElement(int[,] array, int row, int column)
{
    try
    {
        Console.WriteLine($"Значение элемента {row} строка, {column} столбец = {array[row - 1, column - 1]}.");
    }
    catch
    {
        Console.WriteLine($"Элемента по адресу {row} строка, {column} столбец НЕТ.");
    }
}

// Нахождение суммы элементов столбцов массива:
double[] FindSumElementsColumn(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        newArray[j] = Math.Round(sum / array.GetLength(0), 1);
    }
    return newArray;
}


void Task47()
{
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9
    Console.Clear();

    Console.WriteLine("Задача 47. Выводит массив m*n случайных вещественных чисел.");
    Console.Write("Введите кол-во строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] array = Create2DRandomDoubleArray(rows, columns, -7, 10);
    Show2DDoubleArray(array);
}

void Task50()
{
    // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 1 7 -> числа с такими индексами в массиве нет
    Console.Clear();

    Console.WriteLine("Задача 50. Выводит значение элемента по его позиции.");
    Console.Write("Введите строку элемента: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец элемента: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] array = Create2DRandomArray(10, 7, 1, 9);
    Show2DArray(array);
    FindElement(array, row, column);
}

void Task52()
{
    // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    Console.Clear();

    Console.WriteLine("Задача 52. Находит среднее арифметическое элементов в столбцах массива.");
    Console.WriteLine("Зададим массив...");
    Console.Write("Введите кол-во строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбецов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = Create2DRandomArray(rows, columns, 1, 9);
    Show2DArray(array);
    Console.WriteLine("Средние арифметические столбцов");
    ShowDoubleArray(FindSumElementsColumn(array));
}

while (true)
{
    Console.Clear();
    Console.WriteLine("     < Домашнее задание к Семинару №7 >");
    Console.Write("Введите номер задачи (47,50,52) или введите q для выхода: ");
    int num;

    try
    {
        num = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("До встречи на следующем семинаре!");
        break;
    }
    if (num == 47) Task47();
    else if (num == 50) Task50();
    else if (num == 52) Task52();
    else
    {
        Console.Clear();
        Console.WriteLine("Такой задачи в этом ДЗ нет.");
    }

    Console.WriteLine("Для продолжения нажмите Enter.");
    Console.ReadLine();
}