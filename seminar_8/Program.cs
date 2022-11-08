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

// Вывод 2x-массива целых чисел в консоль:
void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            int num = array[i,j];
            if (num <10) Console.Write("0"+num+" ");
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Сортирует строки 2D массива по убыванию:
int[,] SortRows2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            int maxPosition = j;

            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i,k] > array[i,maxPosition]) maxPosition = k;
            }

        int temporary = array[i,j];
        array[i,j] = array[i,maxPosition];
        array[i,maxPosition] = temporary;
        }
    }

    return array;
}

// Находит в 2D массиве строку с наименьшей суммой элементов:
int MinRowSum2DArray(int[,] array)
{
    int row = 1;
    int sumMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            if (i == 0) sumMin = sum;
        }

        if (sum < sumMin)
        {
            sumMin = sum;
            // Console.WriteLine(sumMin);
            row = i + 1;
        }
    }
    return row;
}

// Складывает 2 матрицы:
int[,] WorkMatrix(int[,] array1, int[,] array2)
{
    int[,] sumArray = new int[array1.GetLength(0), array2.GetLength(1)];

    // m = rows sumArray.
    // n = columns sumArray.
    // i = colums array1.

    for (int m = 0; m < sumArray.GetLength(0); m++)
    {
        for (int n = 0; n < sumArray.GetLength(1); n++)
        {
            for (int i = 0; i < array1.GetLength(1); i++)
            {   
                // Console.WriteLine($"m = {m}, n = {n}, i = {i}");
                sumArray[m, n] += array1[m, i] * array2[i, n];
            }
        }
    }
    return sumArray;
}

// Вывод 3x-массива целых чисел в консоль с добавлением индексов:
void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Проверяет существует ли Значение в 3D массиве:
bool Find3DArrayValue(int number, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array [i,j,k] == number) return true;
            }
        }
    }
    return false;
}

// Создаёт 3D массив не повторяющихся чисел:
int[,,] Create3DUniqueArray(int rows, int columns, int depths, int minValue, int maxValue)
{
    int[,,] array3D = new int[rows,columns,depths];
    int randomValue;

    for (int i = 0; i < rows; i++)
    {   
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depths; k++)
            {   
                do
                {
                randomValue = new Random().Next(minValue, maxValue + 1);
                }while(Find3DArrayValue(randomValue, array3D));
                array3D[i, j, k] = randomValue;
            }
        }
    }
    return array3D;
}

// Запарочным образом создаёт спирально заполненный массив:
int[,] Create2DSpiralArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int[] result = new int[3];
    int step = rows-1;
    int current = 1;
    int steps = (rows*2)-1;

    int posX = 0;
    int posY = 0;

    int[] Move(int steps, string direction, int startX, int startY, int[,] array, int startNum)
    {   
        int[] result = new int[3];

        if (direction == "Rigth")
        {
        for (int i = 0; i < steps; i++)
            {   

                array[startY, startX] = startNum;
                startX++;
                startNum++;           
            }
        }

        if (direction == "Left")
        {
        for (int i = 0; i < steps; i++)
            {
                array[startY, startX] = startNum;
                startX--;
                startNum++;           
            }
        }

        if (direction == "Down")
        {
            for (int i = 0; i < steps; i++)
            {
                array[startY, startX] = startNum;
                startY++;
                startNum++;           
            }
        }

        if (direction == "Up")
        {
            for (int i = 0; i < steps; i++)
            {
                array[startY, startX] = startNum;
                startY--;
                startNum++;           
            }
        }

        if (direction == "One Shot")
        {
            array[startY, startX] = startNum;
        }

        result[0] = startX;
        result[1] = startY;
        result[2] = startNum;

        return result;
    }

    while(true)
    {
        result = Move(step,"Rigth",posX,posY,array,current);

        posX = result[0];
        posY = result[1];
        current = result[2];
        
        result = Move(step,"Down",posX,posY,array,current);

        posX = result[0];
        posY = result[1];
        current = result[2];

        result = Move(step,"Left",posX,posY,array,current);

        posX = result[0];
        posY = result[1];
        current = result[2];

        result = Move(step,"Up",posX,posY,array,current);

        posX = result[0]+1;
        posY = result[1]+1;
        current = result[2];
        
        step = step-2;
        if (step == 0)
        {
            Move(step,"One Shot",posX,posY,array,current);
        }
        if (step < 0)
        {
            break;
        }
    }

    return array;
}

// Создаёт спирально заполненный массив универсально:
int[,] Create2DSpiral(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    int posX = 0;
    int posY = 0;
    int num = 1;
    int numMax = rows*columns;

    while(true)
    {   
        //Rigth
        for (int i = 0; i < columns-1; i++)
        {   

            array[posY, posX] = num;
            num++;
            posX++;
            if (num > numMax) break;
        }

        //Down
        for (int i = 0; i < rows-1; i++)
        {
            array[posY, posX] = num;
            num++;
            posY++;
            if (num > numMax) break;
        }

        //Left
        for (int i = 0; i < columns-1; i++)
        {
            array[posY, posX] = num;
            num++;
            posX--;
            if (num > numMax) break;
        }

        //Up
        for (int i = 0; i < rows-1; i++)
        {
            array[posY, posX] = num;
            num++;
            posY--;
            if (num > numMax) break;
        }

        rows=rows-2;
        columns=columns-2;
        posX++;
        posY++;

        // One Shot
        if (rows == 1 && rows==columns)
        {
            array[posY, posX] = num;
        }
        if (rows < 0 || columns < 0) break;
    }
    return array;
}

void Task54()
{
    // Задача 54: Задайте двумерный массив. 
    // Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2
    Console.Clear();

    Console.WriteLine("Задача 54. Упорядочивает по убыванию элементы строк двумерного массива.");
    Console.Write("Зададим массив...");
    Console.Write("Введите кол-во строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = Create2DRandomArray(rows, columns, 1, 9);
    Console.WriteLine("Исходный массив:");
    Show2DArray(array);
    SortRows2DArray(array);
    Console.WriteLine("Результирующий массив:");
    Show2DArray(array);
}

void Task56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. 
    // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
    Console.Clear();

    Console.WriteLine("Задача 56. Находит строку с наименьшей суммой элементов в двумерном массиве.");
    Console.WriteLine("Зададим массив...");
    Console.Write("Введите кол-во строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = Create2DRandomArray(rows, columns, 1, 9);
    Show2DArray(array);
    Console.WriteLine("Строка с минимальной суммой элементов: " + MinRowSum2DArray(array));
}

void Task58()
{
    // Задача 58: Задайте две матрицы. 
    // Напишите программу, которая будет находить произведение двух матриц.
    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18
    Console.Clear();

    Console.WriteLine("Задача 58. Находит произведение двух матриц.");
    Console.WriteLine("Зададим матрицы...");

    Console.Write("Введите кол-во строк 1й матрицы: ");
    int rows1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов 1 матрицы (кол-во строк 2й будет таким же(!)): ");
    int columns1, rows2;
    columns1 = rows2 = Convert.ToInt32(Console.ReadLine());
    int[,] array1 = Create2DRandomArray(rows1, columns1, 1, 4);

    Console.Write("Введите кол-во столбцов 2 матрицы: ");
    int columns2 = Convert.ToInt32(Console.ReadLine());
    int[,] array2 = Create2DRandomArray(rows2, columns2, 1, 4);

    Console.WriteLine("1я матрица:");
    Show2DArray(array1);

    Console.WriteLine("2я матрица:");
    Show2DArray(array2);

    Console.WriteLine("Произведение матриц:");
    Show2DArray(WorkMatrix(array1, array2));
}

void Task60()
{
    // Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    // Массив размером 2 x 2 x 2
    // 66(0,0,0) 25(0,1,0)
    // 34(1,0,0) 41(1,1,0)
    // 27(0,0,1) 90(0,1,1)
    // 26(1,0,1) 55(1,1,1)
    Console.Clear();

    Console.WriteLine("Задача 60. Выводит построчно элементы 3х-массива.");
    Console.Write("Зададим массив...");
    Console.Write("Введите ширину 3D массива (строки): ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите высоту 3D массива (столбцы): ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите глубину 3D массива (...): ");
    int depths = Convert.ToInt32(Console.ReadLine());
    int[,,] array = Create3DUniqueArray(rows, columns, depths, 10, 99);
    Show3DArray(array);
}

void Task62()
{
    // Задача 62. Напишите программу, которая заполнит спирально массив.
    // Например, на выходе получается вот такой массив:
    // 01 02 03 04
    // 12 13 14 05
    // 11 16 15 06
    // 10 09 08 07
    Console.Clear();

    Console.WriteLine("Задача 62. Спирально заполняет массив 4*4.");
    Console.Write("Введите кол-во строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = Create2DSpiral(rows, columns);
    Show2DArray(array);
}

// Run HomeWork Menu:
while (true)
{
    Console.Clear();
    Console.WriteLine("     < Домашнее задание к Семинару №8 >");
    Console.Write("Введите номер задачи (54,56,58,60,62) или введите q для выхода: ");
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
    if (num == 54) Task54();
    else if (num == 56) Task56();
    else if (num == 58) Task58();
    else if (num == 60) Task60();
    else if (num == 62) Task62();
    else
    {
        Console.Clear();
        Console.WriteLine("Такой задачи в этом ДЗ нет.");
    }

    Console.WriteLine("Для продолжения нажмите Enter.");
    Console.ReadLine();
}
