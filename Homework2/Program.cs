﻿Console.WriteLine("Введите три числа");
int num1 = int.Parse(Console.ReadLine()); ;
int num2 = int.Parse(Console.ReadLine()); ;
int num3 = int.Parse(Console.ReadLine()); ;

int max = num1;
if (num2 > num1)
{
     max = num2;
}
if (num3 > max)
{
     max = num3;
}
Console.WriteLine("Масимальное число " + max);