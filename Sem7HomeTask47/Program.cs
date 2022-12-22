//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m = ReadData("Введите количество строк ");
int n = ReadData("Введите количество столбцов ");
double[,] arr2D = new double[m, n];
Random rnd = new Random();
Fill2DArray(arr2D);
Print2DArray(arr2D);

// //Метод считывает данные введенные пользователем
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод печати двухмерного массива
void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Метод генерации и заполнение двумерного массива
void Fill2DArray(double[,] matrix)
{

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(1, 100) / 10.0);
        }
    }
}