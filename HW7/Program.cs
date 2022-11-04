//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int[,] CreateRandom2dArray() 
{
  Console.Write("Input a number of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minVal = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxVal = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[rows, columns];
  for(int i = 0; i < rows; i++) 
    for (int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minVal, maxVal + 1);
  return array;
}
/*void Show2dArray(int[,] array)  
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
string StockIndex2dArray(int[,] array, int row, int column)
{
    return array.GetLength(0) <= row && array.GetLength(1) <= column ? "No this element in this 2d array" : $"Yes this element [{row}, {column}] 2d array stock in and have value - {array[row, column]}";
}

 int[,] array = CreateRandom2dArray();

Console.WriteLine(StockIndex2dArray(array, 5, 5));
