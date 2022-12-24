//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int lists = ReadData("Введите количество листов: ");
int[,,] arr3D = Fill3DArray(row, column, lists, 10, 99);
Print3DArray(arr3D);
// List<int>num = new (List<int>);
// for(int i=0; i<90; i++)
// {
//     num.Add(10+i);
// }
// GenNum(arr3D);



//Метод считывания данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод распечатывания двумерного массива
void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + " ");
            }
        }
        Console.WriteLine();
    }
}

// Универсальный метод генерации и заполнения трехмерного массива
int[,,] Fill3DArray(int countRow, int countColumn, int countLists, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,,] array3D = new int[countRow, countColumn, countLists];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < countLists; k++)
            {
                array3D[i, j, k] = rand.Next(topBorder, downBorder + 1);
            }
        }
    }
    return array3D;
}

// int GenNum(List<int>num)
// {
//     int index= new Random().Next(0, num.length);
//     int outNum = num[index];
//     num.RemoveAt(index);
//     return outNum;
// }