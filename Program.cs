// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
 int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите число: ");
int per = 0;
int temp = num;

while (num > 0)
{
    int num2 = num % 10;
    per = per * 10 + num2;
    num = num / 10;
}
if (temp == per)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
*/

// __________________________________________________________________________________________________________________________________________________________________

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int xA = InputNum("Введите x для А: ");
int yA = InputNum("Введите y для А: ");
int zA = InputNum("Введите z для A: ");
int xB = InputNum("Введите x для B: ");
int yB = InputNum("Введите y для B: ");
int zB = InputNum("Введите z для B: ");

double Root(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double res1 = Math.Pow(zB - zA, 2);
    double res2 = Math.Pow(xB - xA, 2);
    double res3 = Math.Pow(yB - yA, 2);
    double res = Math.Sqrt(res1 + res2 + res3);
    return res;
}

double distance = Root(xA, yA, zA, xB, yB, zB);
// Console.WriteLine(distance);
Console.WriteLine(Math.Round(distance, 2));
*/

//____________________________________________________________________________________________________________________________________________________________________

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num = InputNum("Введите число: ");
for (int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 3)}");
    if (i < num)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(".");
    }
}