//Напишите цикл, который принимает на вход два числа (A и B) и выводит сумму, разность, произведение, частное 

int number1 = ReadData("Введите число A:");
// int oper = ReadData("Введите операцию:");
int number2 = ReadData("Введите число B:");

int res = Sum(number1, number2);
// int res = Dif(number1, number2);
// int res = Mult(number1, number2);
// int res = Divid(number1, number2);

PrintData("Результат=" + res);


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int Sum(int a, int b)
{
    int res = 0;
    res = a + b;
    return res;
}

int Dif(int a, int b)
{
    int res = 0;
    res = a - b;
    return res;
}

int Mult(int a, int b)
{
    int res = 0;
    res = a * b;
    return res;
}

int Divid(int a, int b)
{
    int res = 0;
    res = a / b;
    return res;
}
