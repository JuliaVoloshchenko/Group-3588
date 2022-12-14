// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



double[] arr = GenArray(15, 1, 100);
Print1DArr(arr);
MinMax(arr);
PrintData(arr) = maxValue - minValue;


double minValue = maxValue;
double maxValue = minValue;

double[] GenArray(double len, double minValue, double maxValue)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}
//Метод распечатывание одномерного массива
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}
//Метод печати результата в консоль
void PrintData(string res, double value)
{
    Console.WriteLine(res);
}
//Метод нахождения min и max значения
void MinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxValue)
            maxValue = arr[i];
        if (arr[i] < minValue)
            minValue = arr[i];
    }
}