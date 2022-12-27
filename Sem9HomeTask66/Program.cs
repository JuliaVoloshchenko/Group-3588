//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

//Рекурентный метод нахождения суммы чисел строки
int SumMNRec(int M, int N)
{
    if (M >= N)
    {
        return N;
    }
    else
    {
        return M + SumMNRec(M + 1, N);
    }
}


int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");
int Sum = SumMNRec(M, N);
PrintResult(Sum);