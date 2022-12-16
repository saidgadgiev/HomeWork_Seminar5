/*
Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

//получить размер массива

int CorrectNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while(! isCorrect)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result)) isCorrect = true;
        else Console.WriteLine("Enter correct number");
    }
    return result;
}

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

//Показывает количество четных чисел

void PrintArry(int[] array)
{
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) count = count + 1;
    }
    Console.WriteLine(count);
}

int num = CorrectNumber("Enter a number -> ");
int[] array = InitArray(num);
PrintArry(array);