// Task 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());
WriteLine(SumNumbers(m, n));

int SumNumbers(int m, int n)
{   if (m == n) 
        return n;
    return (n + SumNumbers(m, n-1));
}
