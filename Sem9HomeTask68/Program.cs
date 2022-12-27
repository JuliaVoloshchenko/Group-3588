// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

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

//Рекурсивный метод вычисления функции Аккермана для малых значений
int AkkermanFunc(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AkkermanFunc(n - 1, 1);
    else
        return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));
}

int m = ReadData("Введите число m, которое должно быть <= 3: ");
int n = ReadData("Введите число n, которое должно быть <= 11: ");
int function = AkkermanFunc(m, n);
PrintResult(function);