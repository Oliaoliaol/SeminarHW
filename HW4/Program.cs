//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*double Exponentiation(double a, double b)
{
double c = Math.Pow(a,b);
return c;
}
Console.Write("Введите число: ");
int a1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b1 =Convert.ToInt32(Console.ReadLine());
Console.Write($"Ответ: {Exponentiation(a1,b1)}");
*/
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int SumNumber(int num)
{
int res = 0;
int sum = 0;
while(num > 0 )
    {
        sum=num % 10;
        num= num/10;
        res = sum + res;
    }
    return res;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = SumNumber(a) ;
Console.Write($"Сумма цифр в числе {a}: {b}");
*/
//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*int[] CreateArray(int size) //int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i =0; i < size; i++)
    array[i]=new Random().Next(1,30);
    return array;
}
void ShowArray(int[] array)
{
    for( int i=0; i < array.Length; i++)
    Console.Write(array[i] + " ");
       
}
Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray =CreateArray(size);
ShowArray(myArray);     
*/