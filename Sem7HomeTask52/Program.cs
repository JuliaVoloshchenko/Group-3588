// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Метод считывающий данные, введенные пользователем
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
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

//Метод распечатывания одномерного массива
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Метод находит среднее арифметическое в каждом столбце
int[] AwgCol(int[,]arr)
{
    int [] awr = new int[arr.GetLength(1)];
    for(int j=0; j<arr.GetLength(1); j++)
    {
        for(int i=0; i<arr.GetLength(0); i++)
        {
            awr[j]+=arr[i,j];
        }
    awr[j]=awr[j]/ arr.GetLength(0);
    }
    return awr;
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);
int [] arr = AwgCol(arr2D);
Print1DArr(arr);