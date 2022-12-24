// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int m = ReadData("Введите число строк 1-й матрицы: ");
int n = ReadData("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = ReadData("Введите число столбцов 2-й матрицы: ");

int[,] firstarray2D = Fill2DArray(m, n, 10, 99);
Console.WriteLine("Первая матрица:");
Print2DArray(firstarray2D);
Console.WriteLine();
int[,] secondarray2D = Fill2DArray(n, p, 10, 99);
Console.WriteLine("Вторая матрица:");
Print2DArray(secondarray2D);
Console.WriteLine();
int[,] resultarray2D = new int[m, p];
MultiplyMatrix(firstarray2D, secondarray2D, resultarray2D);
Console.WriteLine("Произведение первой и второй матриц:");
Print2DArray(resultarray2D);

//Метод считывания данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
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

//Метод нахождения произведения двух матриц
void MultiplyMatrix(int[,] firstMatrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
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