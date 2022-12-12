//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int SumDigits(int num)
{
     int res = 0;
    while(num>0)
    {
        res=res+num%10;
        num=num/10;

    }
    return res;
}
int number = ReadData("Введите число:");
int res = SumDigits(number);
PrintData("Сумма цифр в числе=" + res);

