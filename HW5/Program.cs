int[] CreateRandomArray(int size, int minVal, int maxVal) 
{
  int[] array = new int[size];
  
  for (int i = 0; i < size; i++)
      array[i] = new Random().Next(minVal, maxVal + 1);
  return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int SumOfNegatives(int[]array)
{
    int sum =0;
    for(int i =0; i < array.Length; i++)
    {
        if(array[i]<0)
          sum += array[i];
    }
return sum;
}
int []CreateArray(int size)
{
  int[]array =new int[size];
  Console.WriteLine("Creating array: ");
  for(int i = 0; i < size; i++)
  {
    Console.Write($"Введите {i + 1} элементов массива: ");
    array[i]=Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("Полный!");
  return array;
}
/*Console.Write("Input a number of elements: ");
int size =Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max =Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size,min,max);
ShowArray(myArray);

int result =SumOfNegatives(myArray);
Console.WriteLine("Сумма отрицательных элементов " + result);*/
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
 int RandomPositivArr(int[] array)
 {
    int count=0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2==0)
        count++;
    }
    return count;
 }
 Console.Write("Введите количество трёхзначных чисел в массиве: ");

/*int num =Convert.ToInt32(Console.ReadLine());
int[]arr=CreateRandomArray(num, 100, 999);
ShowArray(array);
Console.WriteLine($"Созданный Вами массив имеет - {RandomPositivArr(array)} чётных числа");
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int SumArrayPosition(int[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if((i + 1) % 2 != 0) 
            count += array[i];
    return count;
}

Console.Write("Введите количество чисел в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array  = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine($"Массив размером {size} с значениями внутри от {min} до {max} элементов, сумма элементов нечётных позиций равна {SumArrayPosition(array)}");