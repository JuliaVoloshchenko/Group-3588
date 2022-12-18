// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int N = ReadData("Введите колличество чисел: ");
int result = CountPosNum(N);
PrintData("Колличество чисел больше 0 = ", result);

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод, выводящий на печать данные пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}
//Метод подсчитывающий колличество положительных чисел
int CountPosNum(int N)
{
    int res = 0;
    while (N > 0)
    {
        if (ReadData("Введите число: ") > 0)
            res++;
        N = N - 1;
    }
    return res;
}