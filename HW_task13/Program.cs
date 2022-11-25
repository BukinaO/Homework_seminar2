// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int Number = new Random().Next(1, 100000);

string numberText = number.ToString();



if(number<100)

{    

    Console.WriteLine("третьей цифры нет");

}

else

{

    Console.WriteLine(numberText[2]);

}
