//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
int num = ReadData("Введите пятизначное число: ");
bool result = PalinTest(num);
PrintData("Является ли число палиндромом?", result);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод проверки, является ли число палиндромом
bool PalinTest(int num)
{
    bool result = false;
    result = (num / 10000 == num % 10) && ((num / 1000) % 10 == (num / 10) % 10);
    return result;
}

// Метод вывода данных
void PrintData(string msg, bool result)
{
    Console.WriteLine(msg + result);
}
