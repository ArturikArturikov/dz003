// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

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



/*int num2 = num % 10;
num = num / 10;
int per1 = per * 10;
per1 = per1 + num2;*/





/*int num2 = num % 10;
int res = num2;
num = num / 10;
while (num > 0)
{
    num2 = num % 10;
    num = num / 10;
    res = res * 10;
    res = res + num2;
}
Console.Write(res);*/







/*Console.Write(num % 10);
   while ((num /= 10) != 0)
  Console.Write(num % 10);*/