// Генерация массива из случайных целых чисел:
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        int randomValue = new Random().Next(minValue, maxValue+1);
        newArray[i] = randomValue;
    }
    return newArray;
}

// Генерация массива из случайных дробных чисел:
double[] CreateRandomDoubleArray(int size, double minValue, double maxValue)
{
    double[] newArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        double randomDoubleValue = new Random().NextDouble()*(maxValue-minValue)+minValue;
        newArray[i] = randomDoubleValue;
    }
    return newArray;
}

// Вывод массива целых чисел в консоль:
void ShowArray(int[] array)
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

// Нахождение максимального элемента массива:
double MaxArrayValue(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
    }
    return max;
}

// Нахождение минимального элемента массива:
double MinArrayValue(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<min) min = array[i];
    }
    return min;
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int CountOfPozitive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Задача 34. Выводит кол-во положительных чисел в массиве из 3-значных чисел.");
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, 100,999);
Console.WriteLine("Кол-во чётных чисел в массиве");
ShowArray(array);
Console.Write("Равно "+CountOfPozitive(array)+"\n");


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumCountPozitive(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum+=array[i];
    }
    return sum;
}


Console.WriteLine("Задача 36. Выводит сумму элементов, стоящих на чётных позициях в массиве.");
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, -10,10);
Console.WriteLine("Сумма элементов на чётных позициях в массиве");
ShowArray(array);
Console.Write("Равна "+SumCountPozitive(array)+"\n");


// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double DifferentValue(double[] array)
{
    double max = MaxArrayValue(array);
    double min = MinArrayValue(array);
    return max - min;

}

Console.WriteLine("Задача 38. Задаёт массив из вещественных чисел. Выводит разницу между максимальным и минимальным элементом массива.");
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateRandomDoubleArray(size, -10,10);
Console.WriteLine("Разница между максимальным и минимальным элементами в массиве");
ShowDoubleArray(array);
Console.Write("Равна "+DifferentValue(array)+"\n");


// Доп. Задача: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] ProductSimmetria(int[] array)
{   
    int output_array_size = 0;
    if (array.Length%2 == 0) output_array_size = array.Length/2;
    else output_array_size = (array.Length/2)+1;
    int[] output_array = new int[output_array_size];


    for (int i = 0; i < output_array_size; i++)
    {   
        if (array.Length%2 != 0 && i == output_array_size - 1) output_array[i] = array[i];
        else output_array[i] = array[i]*array[(array.Length-1)-i];
    }

    return output_array;
}

Console.WriteLine("Доп Задача. Находит произведения симметричных пар чисел массива.");
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, 1,10);
Console.WriteLine("Массив: ");
ShowArray(array);
Console.WriteLine("Произведения симметричных пар:");
ShowArray(ProductSimmetria(array));
