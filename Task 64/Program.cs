// Task 64. Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M. 
//Выполнить с помощью рекурсии.
using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(m, n));

string PrintNumbers(int m, int n)
{   if (n == m) 
        return n.ToString();
    return (n + " " + PrintNumbers(m, n-1));
}