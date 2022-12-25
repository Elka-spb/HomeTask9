//Task 68.Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
using System;
using static System.Console;
Clear();
Write("Введите m: ");
int m = int.Parse(ReadLine());
Write("Введите n: ");
int n = int.Parse(ReadLine());
WriteLine("A(m,n) = " + Akkerman(m, n));

int Akkerman(int m, int n)
{   if (m == 0) 
        return (n+1);
    else
        if (n == 0 && m > 0) 
            return Akkerman(m-1, 1);
    else 
    return (Akkerman(m-1, Akkerman(m, n-1)));
}