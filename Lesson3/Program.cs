﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32 (Console.ReadLine());
int i = 1;
double cube;
while (i<=N)
{
     cube = Math.Pow(i,3);
     Console.WriteLine(i + " | "+ cube);
     i++;
}