﻿/*Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.*/

Console.Write("Введите пятизначное число: ");
int x = int.Parse(Console.ReadLine());
if ((x / 10000) == (x % 10) && ((x / 1000) % 10) == ((x / 10) % 10))
{
    Console.WriteLine("число является палиндромом");
}
else
{
    Console.WriteLine("число не является палиндромом");
}