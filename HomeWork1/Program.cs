﻿// ДЗ 1
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input  a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine ("max = " + n1);
}
else
{
Console.WriteLine ("max = " + n2);
}

*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input  a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;
if (max < n2)
{
    max = n2;
    
}

if (max < n3)
{
    max = n3;
    
}

Console.WriteLine ("max = " + max );

*/

//Зад Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

/*
Console.Write("Input a number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1%2==0)
{
    Console.WriteLine ( "число " + n1  + " является четным ");
}
else
{
Console.WriteLine ( "число " + n1  + " является нечетным ");
}

*/

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Input a positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;

while(current<= n)
{
    if (current%2==0)
        Console.Write(current + " ");
    current++;
}

