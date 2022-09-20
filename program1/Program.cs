// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте размер массива m :");
int sizeM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте размер массива n :");
int sizeN = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[sizeM, sizeN];

ArrayRandomNumbers(array);// Заполнение массива числами.
PrintArray(array);//Вывод массива на экран.

void ArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble()*200, 2);
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