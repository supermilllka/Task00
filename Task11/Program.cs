﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 - > 72
//918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное трехзначное число => {number}");

int firstDigit = number/100;

int thirdDigit= number%10;
int result = firstDigit*10+thirdDigit;

Console.WriteLine($"Результат {number} -> {result}");


