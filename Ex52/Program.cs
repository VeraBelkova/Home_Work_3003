﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество сторк: ");
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

double N = 0;
double sum = 0;

for (int j = 0; j < array.GetLength(1); j++)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    sum += array[i,j];
  }
  N = sum/array.GetLength(0);
  Console.Write($"{N}; ");
  sum = 0;
}



