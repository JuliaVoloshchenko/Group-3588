// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//Метод генерации массива случайных чисел

int[] arr = GenArray(15, 1, 100);
Print1DArr(arr);
int result = SumOdd(arr);
PrintData("Сумма элементов с нечетным индексом = ", result);

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
//Метод печати результата в консоль
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
//Метод нахождения суммы элементов с нечетным индексом
int SumOdd(int[] arr)
{
    int res = 0;
    int i = 1;
    while (i < arr.Length)
    {
        res += arr[i];
        i = i + 2;
    }
    return res;
}