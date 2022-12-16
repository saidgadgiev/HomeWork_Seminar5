/*
Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

//Получить массив рандомными трехзначными числами

int[] InitArray(int num)
{
    int[] number = new int[num];
    Random rnd = new Random();
    Console.Write("[");
    for (int i = 0; i < number.Length; i++)
    {
        number[i]=rnd.Next(100,999);
        Console.Write(number[i] + (i < number.Length-1 ?", ":""));
    }
    Console.Write("]");
    return number;
}

InitArray(5);