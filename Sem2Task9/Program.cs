//Написать программу, которая выводит случайное число из отрезка 10-99 и показывает наибольшее число
System.Random numberSintezator = new System.Random();

int number = numberSintezator.Next(10, 100);

Console.WriteLine(number);

int firstNumber = number / 10;
int secondNumber = number % 10;

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}

