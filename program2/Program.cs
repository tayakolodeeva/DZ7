//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите позицию элемента в столбце m :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в строке n :");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[10, 10];

ArrayRandomNumbers(array);// Заполнение массива числами.
FindAnArrayElement(array, n, m);// Нахождение элемента по позиции в массиве.
PrintArray(array);//Вывод массива на экран.

void ArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100,100);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void FindAnArrayElement(double[,] array, int n, int m)
{
    if (n > array.GetLength(0) || m > array.GetLength(1))
    {
        Console.WriteLine("Элемента на введенной вами позиции нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента из {n} строки и {m} столбца равно {array[n-1,m-1]}");
        Console.WriteLine("Для подтверждения посмотрим на созданный массив :");
    }
}