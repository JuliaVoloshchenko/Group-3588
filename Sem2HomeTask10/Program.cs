//Вводим число
int number = int.Parse(Console.ReadLine() ?? "0");

//Проверяем, является ли оно трехзначным
if (number < 1000 && number > 99)
{
//Производим вычисления
    int result = (number / 10) % 10;

//Выводим в консоле результат
    Console.WriteLine(result);
}
    else
{
//Выводим в консоле, что число не является трехзначным
    Console.WriteLine("Число не является трехзначным");

}