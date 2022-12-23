//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
    array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[i,j] + "\t  ");
    Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
 int num1 = Convert.ToInt32(Console.ReadLine());
 int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 > m && num2 > n)
    Console.WriteLine("такого числа нет");
    else
    {
    object c = array.GetValue(num1, num2);
    Console.WriteLine(c);
    }
