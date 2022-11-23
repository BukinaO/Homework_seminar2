// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int randomNumber = new Random().Next(1, 8);
int Saturday = 6;
int Sunday = 7;
if(randomNumber == Saturday && randomNumber == Sunday)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
