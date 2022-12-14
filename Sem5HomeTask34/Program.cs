// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] arr = GenArray(10, 100, 1000);
Print1DArr(arr);
int result = CountEven(arr);
PrintData("Количество четных чисел:", result);

//Метод генерации массива случайных чисел
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}
//Метод распечатывание одномерного массива
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}
//Метод подсчета четных чисел в массиве
int CountEven(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            res++;
    }

    return res;
}
//Метод печати результата в консоль
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}