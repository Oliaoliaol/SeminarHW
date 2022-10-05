/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*Console.Write("Запишите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Запишите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max;
if (a>b)
{
  max=b;
}
else max=a; 

Console.WriteLine($"Наибольшее число {b}, Наименьшее число {a}");
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int n1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второ число: ");
int n2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3=Convert.ToInt32(Console.ReadLine());
int max;
if (n1>n2)
{
   max=n1;
}
else max=n2;
if (n2>n3)
{
   max=n2;
}
else max=n3;
if (n1>n3)
{
   max=n1;
}
else max=n3;
Console.WriteLine("Наибольшее число " + max);

