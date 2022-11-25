// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit = number/10%10;

if(number > 99 && number < 1000)

{

    Console.Write(SecondDigit);
}
