//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*Console.Write("Ведите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >=100 && num < 1000)
{
    int LastDigit = num /10 %10;
    Console.WriteLine($"Вторая цифра трехзначного числа это {num} is {LastDigit}");
}
else 
    Console.WriteLine("Некорректное число");
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*Console.Write("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >=100 && num < 1000)
{
    int threeDigit = num % 10;
    Console.WriteLine($"Третья цифра трехзначного числа это {num} это {threeDigit}");
}
else 
    Console.WriteLine("Третья цифра в числе отсутствует");
    if(num>1000)
    {
        int threeDigit = num % 100 /10;
        Console.WriteLine($"Третья цифра четырехзначного числа это {num} это {threeDigit}");
    }
    */
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*Console.Write("Введи цифру, от одного до семи: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void  CheckingTheDayOfTheWeek (int dayNumber) 
{
    if (dayNumber == 6 || dayNumber == 7) 
    {
        Console.WriteLine("Этот день выходной");
    }
    else 
        Console.WriteLine("Это рабочий день");
    
}
CheckingTheDayOfTheWeek(dayNumber);
*/