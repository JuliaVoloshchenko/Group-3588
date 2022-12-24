//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Метод считывания данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

//Метод распечатывания двумерного массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Метод поиска строки массива с минимальной суммой элементов
int MinRow(int[,] arr)
{
    int minindex = -1;
    int minRow = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Sum += arr[i, j];
        }
        if (minRow > Sum)
        {
            minRow = Sum;
            minindex = i;
        }
    }

    return minindex;
}

//Метод, выводящий на печать данные
void PrintData(string msg, int result)
{
    Console.WriteLine(msg + result);
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);
int minRow = MinRow(arr2D);
PrintData("Индекс минимальной строки: ", minRow);