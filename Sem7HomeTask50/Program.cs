//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

//Метод окращивания данных в консоле
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

//Метод распечатывания цветного двумерного массива
void Print2DArrayColor(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write(matrix[i, j] + " ");
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

//Метод поиска элемента массива
int SearchElem(int[,]arr2D, int x, int y)
{
    int elem = -1;
    if(x<arr2D.GetLength(0) && y<arr2D.GetLength(1))
    {
        elem = arr2D[x,y];

    }
    else
    {
        Console.WriteLine("Нет такого элемента");
    }
    return elem;
}

//Метод распечатывания результата
void PrintData(string msg, int result)
{   
    Console.WriteLine(msg + result);
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int coord1 = ReadData("Введите координату X элемента ");
int coord2 = ReadData("Введите координату Y элемента ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);
int Element = SearchElem(arr2D,coord1,coord2);
PrintData("Значение элемента = ", Element);