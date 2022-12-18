// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double k1 = ReadData("Введите значение K1: ");
double b1 = ReadData("Введите значение B1: ");
double k2 = ReadData("Введите значение K2: ");
double b2 = ReadData("Введите значение B2: ");
double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;
PrintData($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод, выводящий на печать данные пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}