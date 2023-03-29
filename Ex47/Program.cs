// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int columns = Convert.ToInt32(Console.ReadLine());
double d = 0.1;
double [,] array = new double [rows,columns];
for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
     array[i,j] = new Random().Next(-100,100);
     array[i,j] = array[i,j]*d;
     Console.Write("{0,6:F2}", array[i,j], "   ");
  }
  Console.WriteLine();
}