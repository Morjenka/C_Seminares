﻿// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number <1000)
{
    int res = number % 10;
    Console.WriteLine(res + "= последняя цифра числа" +  number);

}
else
{
    Console.WriteLine("число не трёхзначное");
}