//Вводим число
int number = int.Parse(Console.ReadLine() ?? "0");


//Вводим условие
if (number > 99)
{
    //Превращаем число в массив
    Char[]digits = number.toString().toChar(Arrey).;

    //Выводим в консоле результат
    Console.WriteLine(digits[2]);
}
else
{
    //Выводим в консоле, что в числе нет третьей цифры
    Console.WriteLine("в числе нет третьей цифры");

}