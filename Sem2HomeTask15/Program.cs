//Вводим число
int number = int.Parse(Console.ReadLine() ?? "0");

//Проверяем, является ли оно трехзначным
if (number < 8 && number > 0)
{
    if (number > 5) 
    {
    //Выводим в консоле результат
    Console.WriteLine("выходной");
    }
    else
{
        //Выводим в консоле
     Console.WriteLine("рабочий");
}
}
