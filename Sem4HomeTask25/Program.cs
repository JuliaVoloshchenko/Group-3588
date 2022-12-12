//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int Pow(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = a * res;
    }

    return res;
}
int number1 = ReadData("Введите число A:");
int number2 = ReadData("Введите число B:");
int res = Pow(number1, number2);
PrintData("Результат=" + res);
