// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine ("Введите число ");
var numberAString = Console.ReadLine();
int numberA = int.Parse(numberAString!);

int numberB =0;
int numberC =0;
while (numberA > 0)
{
    numberB = numberA%10;
    numberA = numberA/10;
    numberC += numberB;
}

Console.WriteLine(numberC);