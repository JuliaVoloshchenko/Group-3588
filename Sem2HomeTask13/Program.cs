﻿//Вводим число
int number = int.Parse(Console.ReadLine() ?? "0");


//Вводим условие
if (number > 99)
{
    //Превращаем число в массив
    Char[]dijits = number.ToString(). ToCharArrey().;

    //Выводим в консоле результат
    Console.WriteLine(dijits[2]);
}
else
{
    //Выводим в консоле, что в числе нет третьей цифры
    Console.WriteLine("в числе нет третьей цифры");

}