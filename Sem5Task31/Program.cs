//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int arrLen = ReadData("Введите длину массива:");
int min = ReadData("Введите min значание:");
int max = ReadData("Введите max значение:");

int[] arr = GenArr(arrLen);

PrintData("Сгененрированный массив:",arr);


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

int[] GenArr(int num)
{
    int[] arr = new int[num];
    int count1 = min;
    int count2 = max;
   
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min,max+1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
