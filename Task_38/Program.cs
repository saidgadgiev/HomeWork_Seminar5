/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.

[3 7 22 2 78] -> 76
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

// Нахождение разницы макс и минимального элемента массива

void RaznostMaksMin(int[] array)
{
    int min = array[0];
    int max = array[0];// 6. 4. 15.
    for (int i = 1; i < array.Length; i++) 
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    Console.WriteLine($" -> {max - min}");
}

int num = CorrectNumber("Enter a number -> ");
int[] array = InitArray(num);
RaznostMaksMin(array);