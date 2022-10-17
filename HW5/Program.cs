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
 int RandomPositivArr(int[] arr)
 {
    int count=0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2==0)
        count++;
    }
    return count;
 }
 Console.Write("Введите количество трёхзначных чисел в массиве: ");

/*int num =Convert.ToInt32(Console.ReadLine());
int[]arr=CreateRandomArray(num, 100, 999);
ShowArray(arr);
Console.WriteLine($"Созданный Вами массив имеет - {RandomPositivArr(arr)} чётных числа");
*/