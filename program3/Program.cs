// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Задайте количество сторок m :");
int sizeM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов n :");
int sizeN = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[sizeM, sizeN];

ArrayRandomNumbers(array);// Заполнение массива числами.
PrintArray(array);//Вывод массива на экран.
ArithmeticMean(array, sizeM);//Нахождение среднего арифметического элементов в каждом столбце.

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Массив заполненный случайными целыми числами:");
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

void ArithmeticMean(int[,] array, int sizeM) 
{
    Console.WriteLine("Cреднее арифметическое элементов в каждом столбце");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double artihmetic = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            {
                artihmetic = (artihmetic + array[i, j]);
            }
    artihmetic = artihmetic / sizeM;
    Console.Write(artihmetic + "; ");
}
Console.WriteLine();
}