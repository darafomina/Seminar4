// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int[] array = new int[8];
    
for (var i = 0; i < 8; i++)
{
    Console.WriteLine("\nВведите элемент массива под индексом: " + i );
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nВывод массива: ");
Console.Write("[");
for (var i = 0; i < 8; i++)
{
    Console.Write(array[i]);
    if (i != 7)
    Console.Write(", ");
}
 Console.Write("]");
Console.WriteLine();