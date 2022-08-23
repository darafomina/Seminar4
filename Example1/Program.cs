// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine ("Программа для возведения  числа А в степень В");

Console.WriteLine ("Введите число А");
var AString = Console.ReadLine();
var numberA = int.Parse(AString!);

Console.WriteLine ("Введите число В");
var BString = Console.ReadLine();
int numberB = int.Parse(BString!);

int i = 1;
int result = 0;
int numberC =numberA;

while ( i < numberB)
{
    numberC = numberC * numberA;
    i++;
    result= numberC;
    
}

Console.WriteLine(result);