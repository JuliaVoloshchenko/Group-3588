﻿//Написать программу, которая будет примать 2 числа и выводить, является ли второе число кратным первому, если нет то выводит остаток от деления
//int number1 = int.Parse(Console.ReadLine()??"0");
//int number2 = int.Parse(Console.ReadLine()??"0");

//int result = number2
//Console.WriteLine(number1);
int number1 = int.Parse(Console.ReadLine()??"0");
//Console.WriteLine(number1);

int number2 = int.Parse(Console.ReadLine()??"0");
//Console.WriteLine(number2);

int result = number2%number1;

if (result == 0)
{
    Console.WriteLine("Второе число делится на первое без остатка");
}
else
{
    Console.WriteLine("Второе число не крастно первому. Остаток от деления " + result);
}
