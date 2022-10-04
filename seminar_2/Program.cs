// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumber(int num)
{
    int second = (num%100)/10;
    return second;
}

Console.WriteLine("Задача 10. Выводит 2ю цифру трёхзначного числа.");
Console.WriteLine("Ввведите 3х-значное число:");
int number = Convert.ToInt32(Console.ReadLine());

int secondOfThrid = SecondNumber(number);
Console.WriteLine($"Second number of {number} is {secondOfThrid}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
// 645 -> 5
//
// 78 -> третьей цифры нет
//
// 32679 -> 6

string ThridNumber(string num)
{
    string thrid;

    try
        {
            thrid = Convert.ToString(num[2]);
        }
    catch (Exception)
        {
            thrid = "В этом числе третьей цифры нет.";
        }

    return thrid;
}

Console.WriteLine("Задача 13. Выводит 3ю цифру числа или говорит, что её нет.");
Console.WriteLine("Ввведите любое число:");
string number3 = Console.ReadLine();

string thrid = ThridNumber(number3);
Console.WriteLine(thrid);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//
// 6 -> да
// 7 -> да
// 1 -> нет

string WeekEnd(int num)
{
    string result;
        if (num == 6 || num == 7)
            result = "Это выходной";
        else if (num >0 && num <6)
            result = "Это обычный день.";
        else
            result = $"В неделе не {num} дней!";

    return result;
}

Console.WriteLine("Задача 15. Определяет выходной ли номер дня недели.");
Console.WriteLine("Ввведите порядковый номер дня недели:");
int numberWeek = Convert.ToInt32(Console.ReadLine());

string weekend = WeekEnd(numberWeek);
Console.WriteLine(weekend);
