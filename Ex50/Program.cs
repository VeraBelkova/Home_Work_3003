﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


int [,] array = new int [rows,columns];
for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    array[i,j] = new Random().Next(0,10);
     Console.Write(array[i,j] + " ");
  }
  Console.WriteLine();
}
Console.WriteLine("Введите двухзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int N1 =0;
int N2 =0;
N1 = N/10;
N2 = N%10;

if (N1 > array.GetLength(0) || N2 > array.GetLength(1) )
{
  Console.WriteLine("такого числа в массиве нет");
}
else
{
  Console.Write(array[N1,N2]);
}