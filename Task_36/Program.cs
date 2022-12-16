/*
Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

// Ввести размер массива
int CorrectNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while(! isCorrect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result)) isCorrect = true;
        else Console.WriteLine("Enter correct number");
    }
    return result;
}

// Получить массив из случайных чисел

int[] InitArray(int num)
{
    int[] number = new int [num];
    Random rnd = new Random();
    Console.Write("[");
    for (int i = 0; i < num; i++)
    {
        number[i] = rnd.Next(-100, 100);
        Console.Write(number[i] + (i < number.Length-1 ?", ":""));
    }
    Console.Write("]");
    return number;
}

// Находит сумму элементов, стоящих на нечётных позициях.

void SumElementov(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) count = count + array[i];
        
    }
    Console.Write($" -> {count}");
}

int num = CorrectNumber("Enter a number -> ");
int[] array = InitArray(num);
SumElementov(array);