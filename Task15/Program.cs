﻿/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите число от 1 до 7: ");
string a = Console.ReadLine();
if (a=="1"|| a=="2" || a=="3" || a=="4" || a=="5" )
{
  Console.WriteLine("нет");

}
else if (a=="6" || a=="7")
{
  Console.WriteLine("да");

}

else 
{
    Console.WriteLine("Данные не корректны"); 

}