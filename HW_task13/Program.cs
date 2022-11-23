// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Hello, World!");
int randomNumber = new Random(). Next(1, 100000);
int ThirdDigit = randomNumber/100;
if(randomNumber<100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine("ThirdDigit");
}